using AutoMapper;
using GoogleScrapper.Application.Queries.GetSearch;
using GoogleScrapper.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Application.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SearchResult, SearchResultDto>();
        }
    }
}
