namespace EA.Battlelog.IPResolve {
	partial class FrmMain {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.textBoxUrl = new System.Windows.Forms.TextBox();
      this.labelHero = new System.Windows.Forms.Label();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.labelResult = new System.Windows.Forms.Label();
      this.buttonStart = new System.Windows.Forms.Button();
      this.linkLabelCopy = new System.Windows.Forms.LinkLabel();
      this.linkLabelOpenBattlelog = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // textBoxUrl
      // 
      this.textBoxUrl.Location = new System.Drawing.Point(16, 46);
      this.textBoxUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.textBoxUrl.Name = "textBoxUrl";
      this.textBoxUrl.Size = new System.Drawing.Size(425, 23);
      this.textBoxUrl.TabIndex = 0;
      this.textBoxUrl.Text = "http://battlelog.battlefield.com/bf4/servers/show/pc/e9a4c7d6-85a9-49b3-b7bd-b1ba" +
    "abe6b911/TB-1-NO-Explosive-AutoNuke-QQ181448680-YueLun-com/";
      // 
      // labelHero
      // 
      this.labelHero.AutoSize = true;
      this.labelHero.Location = new System.Drawing.Point(14, 28);
      this.labelHero.Name = "labelHero";
      this.labelHero.Size = new System.Drawing.Size(160, 15);
      this.labelHero.TabIndex = 1;
      this.labelHero.Text = "バトルログ - サーバーページURL";
      // 
      // textBoxResult
      // 
      this.textBoxResult.BackColor = System.Drawing.Color.Black;
      this.textBoxResult.ForeColor = System.Drawing.Color.Lime;
      this.textBoxResult.Location = new System.Drawing.Point(16, 130);
      this.textBoxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.textBoxResult.Multiline = true;
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxResult.Size = new System.Drawing.Size(427, 186);
      this.textBoxResult.TabIndex = 2;
      // 
      // labelResult
      // 
      this.labelResult.AutoSize = true;
      this.labelResult.Location = new System.Drawing.Point(14, 111);
      this.labelResult.Name = "labelResult";
      this.labelResult.Size = new System.Drawing.Size(44, 15);
      this.labelResult.TabIndex = 3;
      this.labelResult.Text = "結果 : ";
      // 
      // buttonStart
      // 
      this.buttonStart.Location = new System.Drawing.Point(314, 78);
      this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(128, 26);
      this.buttonStart.TabIndex = 4;
      this.buttonStart.Text = "取得";
      this.buttonStart.UseVisualStyleBackColor = true;
      this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
      // 
      // linkLabelCopy
      // 
      this.linkLabelCopy.AutoSize = true;
      this.linkLabelCopy.Location = new System.Drawing.Point(405, 326);
      this.linkLabelCopy.Name = "linkLabelCopy";
      this.linkLabelCopy.Size = new System.Drawing.Size(34, 15);
      this.linkLabelCopy.TabIndex = 6;
      this.linkLabelCopy.TabStop = true;
      this.linkLabelCopy.Text = "コピー";
      this.linkLabelCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCopy_LinkClicked);
      // 
      // linkLabelOpenBattlelog
      // 
      this.linkLabelOpenBattlelog.AutoSize = true;
      this.linkLabelOpenBattlelog.Location = new System.Drawing.Point(14, 326);
      this.linkLabelOpenBattlelog.Name = "linkLabelOpenBattlelog";
      this.linkLabelOpenBattlelog.Size = new System.Drawing.Size(71, 15);
      this.linkLabelOpenBattlelog.TabIndex = 7;
      this.linkLabelOpenBattlelog.TabStop = true;
      this.linkLabelOpenBattlelog.Text = "サーバー一覧";
      this.linkLabelOpenBattlelog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOpenBattlelog_LinkClicked);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(456, 352);
      this.Controls.Add(this.linkLabelOpenBattlelog);
      this.Controls.Add(this.linkLabelCopy);
      this.Controls.Add(this.buttonStart);
      this.Controls.Add(this.labelResult);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.labelHero);
      this.Controls.Add(this.textBoxUrl);
      this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Battlelog Server IP Resolve";
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxUrl;
		private System.Windows.Forms.Label labelHero;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.LinkLabel linkLabelCopy;
    private System.Windows.Forms.LinkLabel linkLabelOpenBattlelog;
  }
}

