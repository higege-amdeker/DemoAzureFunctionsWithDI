namespace DemoAzureFunctionsWithDI.Demos;

/// <summary>
/// SQL Database の Demo へのデータアクセスを実現します
/// </summary>
public class SqldatabaseDemoRepository : IDemoRepository
{
    /// <inheritdoc/>
    public async Task<Demo?> GetAsync()
    {
        Demo demo = new(
            "SqlDatabaseDemo",
            "This data was taken from SQL Database.");

        return await Task.FromResult(demo);
    }
}
