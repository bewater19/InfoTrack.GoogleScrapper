using GoogleScrapper.Domain.Interfaces;
using GoogleScrapper.Domain.Models;
using GoogleScrapper.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Infrastructure.Repository
{
    public class SearchRepository : Repository<SearchResult>, ISearchRepository
    {
        public SearchRepository(AppDbContext context)
            : base(context) { }

    }
}
