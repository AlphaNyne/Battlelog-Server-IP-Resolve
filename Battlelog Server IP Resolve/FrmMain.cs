/*
 * Copyright (c) 2018 AlphaNyne
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EA.Battlelog.IPResolve
{
  public partial class FrmMain : Form
  {
    #region フィールド

    private string _address;

    private UIManager _uiManager;

    #endregion

    #region プロパティ

    private UIManager UIManager {
      get {
        if (this._uiManager == null) {
          this._uiManager = new UIManager();
        }
        return this._uiManager;
      }
      set {
        this._uiManager = value;
      }
    }

    #endregion

    public FrmMain()
    {
      InitializeComponent();

      this.UIManager.AddControl(new Control[] {
        this.buttonOK,
        this.textBoxURL,
        this.linkLabelCopy
      });
    }

    private async void ButtonOK_Click(object sender, EventArgs e)
    {
      WriteConsole("開始します...");
      this.UIManager.Enabled = false;
      this.textBoxResult.ResetText();

      var result = await Task.Run(async () => {
        var ipaddress = "";

        try {
          WriteConsole("ダウンロード中...");
          var content = await GetResponseAsync(this.textBoxURL.Text);
          WriteConsole("応答データの長さ: " + content.Length);
          Thread.Sleep(500);

          WriteConsole("応答データをオブジェクトに変換します");
          var doc = new HtmlAgilityPack.HtmlDocument();
          doc.LoadHtml(content);
          Thread.Sleep(500);

          WriteConsole("属性'data-ip'を検索しています...");
          var node = doc.GetElementbyId("server-page");
          Thread.Sleep(500);

          try {
            ipaddress = node.Attributes["data-ip"].Value;
            WriteConsole("見つかりました");
            WriteConsole("IP: " + ipaddress);
          }
          catch {
            ipaddress = "";
            WriteConsole("見つかりませんでした");
          }
        }
        catch (Exception ex) {
          MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return ipaddress;
      });

      // リセット UI
      this._address = result;
      this.UIManager.Enabled = true;
    }

    private void WriteConsole(string content)
    {
      this.textBoxResult.WriteLine(content + Environment.NewLine);
    }

    private async Task<string> GetResponseAsync(string url)
    {
      if (string.IsNullOrEmpty(url)) {
        throw new ArgumentNullException("The 'url' paramater is missing a value.");
      }

      var http = new HttpClient();
      try {
        var response = await http.GetAsync(url, HttpCompletionOption.ResponseContentRead);
        if (response.IsSuccessStatusCode) {
          return await response.Content.ReadAsStringAsync();
        }
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally {
        http.Dispose();
      }
      return null;
    }

    private void LinkLabelCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try {
        Clipboard.SetText(this._address);
      }
      catch {
        MessageBox.Show("クリップボードにコピーできませんでした。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
