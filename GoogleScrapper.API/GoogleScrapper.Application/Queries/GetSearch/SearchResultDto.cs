using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Application.Queries.GetSearch
{
    public class SearchResultDto
    {
        public int id { get; set; }
        public DateTime CreateTime { get; set; }
        public string SearchPhrase { get; set; }
        public string MatchUrl { get; set; }
        public string Ranks { get; set; }
    }
}
