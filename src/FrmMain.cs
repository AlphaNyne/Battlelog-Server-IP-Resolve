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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EA.Battlelog.IPResolve
{
  public partial class FrmMain : Form
  {
    private string address;

    public FrmMain() =>
      this.InitializeComponent();

    private async void buttonStart_Click(object sender, EventArgs e)
    {
      this.WriteConsole("開始します...");
      this.buttonStart.Enabled = false;
      this.textBoxUrl.Enabled = false;
      this.textBoxResult.ResetText();

      string result = await Task.Run(async () => {

        string address = null;

        try {
          this.WriteConsole("ダウンロード中...");
          string response = await this.GetResponseAsync(this.textBoxUrl.Text);
          this.WriteConsole("応答データの長さ: " + response.Length);
          await Task.Delay(500);

          this.WriteConsole("応答データをオブジェクトに変換します");
          HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
          doc.LoadHtml(response);
          await Task.Delay(500);

          this.WriteConsole("属性'data-ip'を検索しています...");
          HtmlAgilityPack.HtmlNode node = doc.GetElementbyId("server-page");
          await Task.Delay(500);

          try {
            address = node.Attributes["data-ip"].Value;
            this.WriteConsole("見つかりました");
            this.WriteConsole("IP : " + address);
          }
          catch {
            address = "";
            this.WriteConsole("見つかりませんでした");
          }
        }
        catch (Exception ex) {
          MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return address;
      });

      this.address = result;
      this.buttonStart.Enabled = true;
      this.textBoxUrl.Enabled = true;
    }

    private void WriteConsole(string content)
    {
      this.textBoxResult.WriteLine(content + Environment.NewLine);
    }

    private async Task<string> GetResponseAsync(string requestUri)
    {
      if (string.IsNullOrWhiteSpace(requestUri)) {
        throw new ArgumentNullException("requestUri: Parameter is missing a value");
      }

      HttpClient http = new HttpClient();

      try {
        HttpResponseMessage response = await http.GetAsync(requestUri);
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
        Clipboard.SetText(this.address);
      }
      catch {
        MessageBox.Show("クリップボードにコピーできません。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void LinkLabelOpenBattlelog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
      System.Diagnostics.Process.Start("http://battlelog.battlefield.com/bf4/servers/");
  }
}
