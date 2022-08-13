using GoogleScrapper.Domain.Interfaces;
using GoogleScrapper.Domain.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleScrapper.Domain.Services
{
    public class SearchService : ISearchService
    {
        public SearchService() { }

        /// <summary>
        /// This is function to search top 100 result in google.com
        /// </summary>
        /// <param name="searchPhase"></param>
        /// <param name="matchUrl"></param>
        /// <returns>
        /// return the ranks of matchUrl hits the search results
        /// </returns>
        public async Task<SearchResult> GoogleSearchTop100Async(string searchPhrase, string matchUrl)
        {
            string searchUrl = $"http://www.google.com/search?num=100&q={searchPhrase}";
            var result = await new HtmlWeb().LoadFromWebAsync(searchUrl);
            //get nodes of search results
            var nodes = result.DocumentNode.SelectNodes("//html//body//div[@class='g']");
            //get first href link of each node & match the url
            List<int> ranks = nodes == null ? new List<int> { 0 }
                                    : nodes.Select((x, i) => new { i, link = x.Descendants("a").Select(a => a.GetAttributeValue("href", null)).FirstOrDefault() })
                                    .Where(x => x.link != null && x.link.Contains(matchUrl))
                                    .Select(x => x.i + 1)
                                    .ToList();

            SearchResult searchResult = new SearchResult(searchPhrase, matchUrl, ranks.Count() > 0 ? string.Join(",", ranks) : "0");
            return searchResult;
        }
    }
}
