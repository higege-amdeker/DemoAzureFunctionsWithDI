namespace DemoAzureFunctionsWithDI.Demos;

/// <summary>
/// Http Request で Demo を取得する API
/// </summary>
public class GetDemo
{
    /// <summary>
    /// 依存性を注入するインターフェースをメンバーに持ちます
    /// </summary>
    private readonly IDemoRepository _demoRepository;

    /// <summary>
    /// コンストラクター
    /// </summary>
    /// <param name="demoRepository"></param>
    public GetDemo(IDemoRepository demoRepository)
    {
        _demoRepository = demoRepository;
    }

    [FunctionName("GetDemo")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");

        Demo? demo = await _demoRepository.GetAsync();

        if (demo is null)
        {
            return new BadRequestObjectResult(new { message = "demo is null", });
        }

        string responseMessage = $"Data name: {demo.Name}, Description: {demo.Description}";
        log.LogInformation(responseMessage);

        return new OkObjectResult(responseMessage);
    }
}
