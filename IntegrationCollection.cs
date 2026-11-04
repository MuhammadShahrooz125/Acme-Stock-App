using Xunit;

namespace IntegrationTest;

[CollectionDefinition("Integration")]
public class IntegrationCollection : ICollectionFixture<CustomWebApplicationFactory>
{

}