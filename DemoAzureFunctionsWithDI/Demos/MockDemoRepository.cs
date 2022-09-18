namespace DemoAzureFunctionsWithDI.Demos;

/// <summary>
/// SQL Database の Demo へのデータアクセスを実現します
/// </summary>
public sealed class MockDemoRepository : IDemoRepository
{
    /// <inheritdoc/>
    public async Task<Demo?> GetAsync()
    {
        Demo demo = new(
            "SqlDatabaseDemo",
            "This data was taken from Mockup Database.");

        return await Task.FromResult(demo);
    }
}
