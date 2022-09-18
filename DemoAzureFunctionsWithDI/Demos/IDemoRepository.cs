namespace DemoAzureFunctionsWithDI.Demos;

/// <summary>
/// Demo へのデータアクセスのインターフェイス
/// </summary>
public interface IDemoRepository
{
    /// <summary>
    /// Demo を取得します
    /// </summary>
    /// <returns></returns>
    public Task<Demo?> GetAsync();
}
