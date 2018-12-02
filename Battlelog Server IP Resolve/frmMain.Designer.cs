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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelHero = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.linkLabelCopy = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(16, 46);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(425, 23);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.Text = "http://battlelog.battlefield.com/bf4/servers/show/pc/e9a4c7d6-85a9-49b3-b7bd-b1ba" +
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
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(314, 78);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(128, 26);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "取得";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Do you hot to this address? xD";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelCopy);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelHero);
            this.Controls.Add(this.textBoxURL);
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

		private System.Windows.Forms.TextBox textBoxURL;
		private System.Windows.Forms.Label labelHero;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.LinkLabel linkLabelCopy;
        private System.Windows.Forms.Label label1;
    }
}

