using GoogleScrapper.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Domain.Interfaces
{
    public interface ISearchService
    {
        Task<SearchResult> GoogleSearchTop100Async(string searchPhrase, string matchUrl);
    }
}
