# DemoAzureFunctionsWithDI

Azure Functions に Dependency Injection を導入するデモです。

Startup クラスで依存性注入を設定します。
コンストラクタで適切な依存関係が構築されます。

以下の API を提供します。
- Demo データの取得

以下の依存性切り替えを想定します。
- Azure Table に保管されるデータ
- テスト用のモックアップデータ

---

## おまけ：Functions の簡単なデバッグ方法
- Visual Studio Code の拡張機能「REST Client」をインストール
- Functions プロジェクトを「スタートアッププロジェクト」に設定してデバッグ実行
- 以下を実行します。（ポート番号は各自設定）
```
GET http://localhost:0000/api/GetDemo HTTP/1.1
```
