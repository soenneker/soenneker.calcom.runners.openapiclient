using Soenneker.Tests.HostedUnit;

namespace Soenneker.CalCom.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CalComOpenApiClientRunnerTests : HostedUnitTest
{
    public CalComOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
