namespace yoketoruvs20
{
    partial class gameoverLabel
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.stertButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.goLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.titleButton = new System.Windows.Forms.Button();
            this.tempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(12, 63);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(482, 108);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "YOKETORU";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // stertButton
            // 
            this.stertButton.Font = new System.Drawing.Font("Adobe Gothic Std B", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stertButton.Location = new System.Drawing.Point(494, 311);
            this.stertButton.Name = "stertButton";
            this.stertButton.Size = new System.Drawing.Size(294, 100);
            this.stertButton.TabIndex = 1;
            this.stertButton.Text = "START";
            this.stertButton.UseVisualStyleBackColor = true;
            this.stertButton.Click += new System.EventHandler(this.stertButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(634, 429);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(154, 12);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright © 2020  高橋 怜児";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.timeLabel.Location = new System.Drawing.Point(13, 13);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(139, 33);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time 100";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiLabel.Location = new System.Drawing.Point(243, 171);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(380, 64);
            this.hiLabel.TabIndex = 4;
            this.hiLabel.Text = "HighScore 0";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.itemLabel.Location = new System.Drawing.Point(682, 13);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(106, 33);
            this.itemLabel.TabIndex = 5;
            this.itemLabel.Text = "★ : 10";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // goLabel
            // 
            this.goLabel.AutoSize = true;
            this.goLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.goLabel.ForeColor = System.Drawing.Color.Maroon;
            this.goLabel.Location = new System.Drawing.Point(145, 172);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(510, 107);
            this.goLabel.TabIndex = 6;
            this.goLabel.Text = "GAME OVER";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clearLabel.Location = new System.Drawing.Point(27, 63);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(294, 107);
            this.clearLabel.TabIndex = 7;
            this.clearLabel.Text = "CLEAR";
            // 
            // titleButton
            // 
            this.titleButton.Font = new System.Drawing.Font("Adobe Gothic Std B", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleButton.Location = new System.Drawing.Point(254, 311);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(294, 100);
            this.titleButton.TabIndex = 8;
            this.titleButton.Text = "TITLE";
            this.titleButton.UseVisualStyleBackColor = true;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tempLabel.Location = new System.Drawing.Point(623, 108);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(47, 33);
            this.tempLabel.TabIndex = 9;
            this.tempLabel.Text = "卍";
            this.tempLabel.Visible = false;
            // 
            // gameoverLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.stertButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "gameoverLabel";
            this.Text = "YOKETORU";
            this.Load += new System.EventHandler(this.gameoverLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button stertButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label goLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Label tempLabel;
    }
}

