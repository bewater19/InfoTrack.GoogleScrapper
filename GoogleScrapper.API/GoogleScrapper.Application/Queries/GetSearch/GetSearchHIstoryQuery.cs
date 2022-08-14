using AutoMapper;
using GoogleScrapper.Domain.Interfaces;
using GoogleScrapper.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Application.Queries.GetSearch
{
    public class GetSearchHistoryQuery : IRequest<List<SearchResultDto>>
    {

    }

    public class GetSearchQueryHistoryHandler : IRequestHandler<GetSearchHistoryQuery, List<SearchResultDto>>
    {
        private readonly IMapper _mapper;
        private readonly ISearchService _searchService;

        public GetSearchQueryHistoryHandler(IMapper mapper, ISearchService searchService)
        {
            _mapper = mapper;
            _searchService = searchService;
        }

        public async Task<List<SearchResultDto>> Handle(GetSearchHistoryQuery request, CancellationToken cancellationToken)
        {
            List<SearchResult> searchResults = await _searchService.GetSearchHistory();
            List<SearchResultDto> searchResultDtos = _mapper.Map<List<SearchResultDto>>(searchResults);
            return searchResultDtos;
        }
    }
}
