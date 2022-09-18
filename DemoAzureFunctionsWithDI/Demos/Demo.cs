namespace DemoAzureFunctionsWithDI.Demos;

/// <summary>
/// デモデータ
/// </summary>
public sealed class Demo
{
    /// <summary>
    /// 名前
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// 説明
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// コンストラクター
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    public Demo(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
