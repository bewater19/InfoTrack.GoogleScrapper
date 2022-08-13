using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Domain.Models
{
    public class SearchResult
    {
        public string SearchPhrase { get; set; }
        public string MatchUrl { get; set; }
        public string Ranks { get; set; }

        public SearchResult(string searchPhase, string matchUrl, string ranks)
        {
            this.SearchPhrase = searchPhase;
            this.MatchUrl = matchUrl;
            this.Ranks = ranks;
        }
    }
}
