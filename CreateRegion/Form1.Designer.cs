namespace CreateRegion {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            this.BaseText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.RegionCheck = new System.Windows.Forms.CheckBox();
            this.CommentCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BaseText
            // 
            this.BaseText.Location = new System.Drawing.Point(12, 12);
            this.BaseText.Multiline = true;
            this.BaseText.Name = "BaseText";
            this.BaseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BaseText.Size = new System.Drawing.Size(563, 397);
            this.BaseText.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(500, 415);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 2;
            this.ExecuteButton.Text = "実行";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // RegionCheck
            // 
            this.RegionCheck.AutoSize = true;
            this.RegionCheck.Checked = true;
            this.RegionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RegionCheck.Location = new System.Drawing.Point(12, 419);
            this.RegionCheck.Name = "RegionCheck";
            this.RegionCheck.Size = new System.Drawing.Size(83, 16);
            this.RegionCheck.TabIndex = 3;
            this.RegionCheck.Text = "Region生成";
            this.RegionCheck.UseVisualStyleBackColor = true;
            // 
            // CommentCheck
            // 
            this.CommentCheck.AutoSize = true;
            this.CommentCheck.Checked = true;
            this.CommentCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CommentCheck.Location = new System.Drawing.Point(101, 419);
            this.CommentCheck.Name = "CommentCheck";
            this.CommentCheck.Size = new System.Drawing.Size(105, 16);
            this.CommentCheck.TabIndex = 4;
            this.CommentCheck.Text = "修飾コメント生成";
            this.CommentCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(587, 444);
            this.Controls.Add(this.CommentCheck);
            this.Controls.Add(this.RegionCheck);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.BaseText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BaseText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.CheckBox RegionCheck;
        private System.Windows.Forms.CheckBox CommentCheck;
    }
}

