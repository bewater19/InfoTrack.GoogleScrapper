using AutoMapper;
using GoogleScrapper.Domain.Interfaces;
using GoogleScrapper.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Application.Queries.GetSearch
{
    public class GetSearchQuery : IRequest<SearchResultDto>
    {
        [Required]
        public string SearchPhrase { get; set; }
        [Required]
        public string MatchUrl { get; set; }
    }

    public class GetSearchQueryHandler : IRequestHandler<GetSearchQuery, SearchResultDto>
    {
        private readonly IMapper _mapper;
        private readonly ISearchService _searchService;

        public GetSearchQueryHandler(IMapper mapper, ISearchService searchService)
        {
            _mapper = mapper;
            _searchService = searchService;
        }

        public async Task<SearchResultDto> Handle(GetSearchQuery request, CancellationToken cancellationToken)
        {
            SearchResult searchResult = await _searchService.GoogleSearchTop100Async(request.SearchPhrase, request.MatchUrl);
            SearchResultDto searchResultDto = _mapper.Map<SearchResultDto>(searchResult);
            return searchResultDto;
        }
    }
}
