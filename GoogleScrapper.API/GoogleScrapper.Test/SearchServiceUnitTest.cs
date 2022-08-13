using GoogleScrapper.Domain.Models;
using GoogleScrapper.Domain.Services;
using Xunit.Abstractions;

namespace GoogleScrapper.Test
{
    public class SearchServiceUnitTest
    {
        private readonly ITestOutputHelper output;

        public SearchServiceUnitTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        /// <summary>
        /// test GoogleSearchTop100 method by data
        /// </summary>
        /// <param name="searchPhase"></param>
        /// <param name="matchUrl"></param>
        /// <param name="expectedResult"></param>
        /// <returns></returns>
        /// <remarks>Google search results may vary time to time</remarks>
        [Theory]
        [InlineData("land registry searches", "www.infotrack.co.uk", "11")]
        [InlineData("land registry searches", "not.a.correct.link", "0")]
        [InlineData("t", "t", "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100")]
        public async Task TestGoogleSearchTop100(string searchPhrase, string matchUrl, string expectedResult)
        {
            //Arrange
            SearchService searchService = new SearchService();

            //Act
            SearchResult searchResult = await searchService.GoogleSearchTop100Async(searchPhrase, matchUrl);

            //Assert
            output.WriteLine("searchResult:" + searchResult.Ranks);
            output.WriteLine("expectedResult:" + expectedResult);
            Assert.True(searchResult.Ranks.Equals(expectedResult));

        }
    }
}