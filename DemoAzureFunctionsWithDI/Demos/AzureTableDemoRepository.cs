namespace DemoAzureFunctionsWithDI.Demos;

/// <summary>
/// Azure Table の Demo へのデータアクセスを実現します
/// </summary>
public sealed class AzureTableDemoRepository : IDemoRepository
{
    /// <inheritdoc/>
    public async Task<Demo?> GetAsync()
    {
        Demo demo = new(
            "AzureTableDemo",
            "This data was taken from Azure Tablaes.");

        return await Task.FromResult(demo);
    }
}
