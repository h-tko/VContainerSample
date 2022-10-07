# VContainerSample
VContainerを試してみたやつ

## vscode設定手順

### unity側

1. メニューの Edit > Project Settingsを開く
2. Playerタブを選択し、Api Compatibility Levelを「.Net Framework」に変更
3. メニューの Unity > Preferencesを開く
4. External Toolsタブを選択し、ExternalScriptEditorを「Visual Studio Code」に変更
5. チェックボックを以下のようにする

<img width="496" alt="image" src="https://user-images.githubusercontent.com/24465810/194561981-3f89621d-eebf-4e67-9fe0-c26e0c05fb0c.png">

6. Regenerate project filesボタンをクリックしてcsprojファイルを作り直す

### ミドルウェア

1. monoの最新版がインストールされているかチェック（which monoして出てこなかったらbrew install monoする）

### vscode側

1. 以下の拡張機能をインストール

- c#
- Unity Tools
- Debugger for Unity
- Unity Code Snippets

2. settingsファイルを修正（command + shift + p押して「Open User Settings」と入力してサジェストされたやつを開く
3. 「設定の検索」に「omnisharp」と入力

デフォルトから変更する箇所は以下

<img width="573" alt="image" src="https://user-images.githubusercontent.com/24465810/194563148-8af34ee4-9c26-45c7-872e-b39829e3e4b0.png">

<img width="551" alt="image" src="https://user-images.githubusercontent.com/24465810/194563210-793febc6-551f-4ec0-8e35-a08272b4aa61.png">

4. omnisharpを再起動（command + shift + p押して「restart omnisharp」と入力してサジェストされたやつをクリック）
