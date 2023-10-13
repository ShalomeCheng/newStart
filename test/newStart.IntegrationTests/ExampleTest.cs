using System.Threading.Tasks;
using Xunit;

namespace newStart.IntegrationTests
{
    public class ExampleTest : IClassFixture<DefaultWebAppTestFactory>
    {
        private readonly DefaultWebAppTestFactory defaultWebAppTestFactory;

        public ExampleTest(DefaultWebAppTestFactory defaultWebAppTestFactory)
        {
            this.defaultWebAppTestFactory = defaultWebAppTestFactory;
        }

        [Fact]
        public async Task ExampleGet_Called_HelloReturned()
        {
            using (var client = defaultWebAppTestFactory.CreateClient())
            {
                var response = await client.GetAsync("/example");

                var content = await response.Content.ReadAsStringAsync();

                Assert.Equal("Hello!", content);
            }
        }
    }
}
