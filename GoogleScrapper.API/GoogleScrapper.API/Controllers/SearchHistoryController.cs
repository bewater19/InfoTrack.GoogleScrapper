using GoogleScrapper.Application.Queries.GetSearch;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoogleScrapper.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchHistoryController : ControllerBase
    {
        private readonly ILogger<SearchHistoryController> _logger;
        private readonly IMediator _mediator;

        public SearchHistoryController(IMediator mediator, ILogger<SearchHistoryController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetSearchHistoryQuery()));
        }
    }
}
