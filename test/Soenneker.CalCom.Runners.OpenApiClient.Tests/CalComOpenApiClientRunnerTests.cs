using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.CalCom.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class CalComOpenApiClientRunnerTests : FixturedUnitTest
{
    public CalComOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
