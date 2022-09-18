# DemoAzureFunctionsWithDI

Azure Functions に Dependency Injection を導入するデモです。（.NET 6）

以下の API を提供します。
- Demo データの取得

以下の依存性切り替えを想定します。
- Azure Table に保管されるデータ
- テスト用のモックアップデータ

## テンプレートプロジェクトからの主な変更点
- Startup クラスで依存性注入を設定
  - コンストラクタで適切な依存関係が構築されます。
- global using を有効化

## 参考
.NET Azure Functions で依存関係の挿入を使用する - Microsoft Docs
https://learn.microsoft.com/ja-jp/azure/azure-functions/functions-dotnet-dependency-injection

---

## おまけ：Functions の簡単なデバッグ方法
- Visual Studio Code の拡張機能「REST Client」をインストール
- Functions プロジェクトを「スタートアッププロジェクト」に設定してデバッグ実行
- 以下を実行します。（ポート番号は各自設定）
```
GET http://localhost:0000/api/GetDemo HTTP/1.1
```
