using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Domain.Models
{
    public class SearchResult
    {
        public int id { get; set; }
        public DateTime CreateTime { get; set; }
        public string SearchPhrase { get; set; }
        public string MatchUrl { get; set; }
        public string Ranks { get; set; }
    }
}
