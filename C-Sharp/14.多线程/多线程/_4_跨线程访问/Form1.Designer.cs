namespace _4_跨线程访问
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_chgVal = new System.Windows.Forms.Button();
            this.lbl_val = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_chgVal
            // 
            this.btn_chgVal.Location = new System.Drawing.Point(46, 124);
            this.btn_chgVal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_chgVal.Name = "btn_chgVal";
            this.btn_chgVal.Size = new System.Drawing.Size(133, 40);
            this.btn_chgVal.TabIndex = 1;
            this.btn_chgVal.Text = "开始计时";
            this.btn_chgVal.UseVisualStyleBackColor = true;
            this.btn_chgVal.Click += new System.EventHandler(this.btn_chgVal_Click);
            // 
            // lbl_val
            // 
            this.lbl_val.AutoSize = true;
            this.lbl_val.Font = new System.Drawing.Font("宋体", 30F);
            this.lbl_val.ForeColor = System.Drawing.Color.Red;
            this.lbl_val.Location = new System.Drawing.Point(89, 43);
            this.lbl_val.Name = "lbl_val";
            this.lbl_val.Size = new System.Drawing.Size(37, 40);
            this.lbl_val.TabIndex = 2;
            this.lbl_val.Text = "0";
            this.lbl_val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 184);
            this.Controls.Add(this.lbl_val);
            this.Controls.Add(this.btn_chgVal);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计时器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chgVal;
        private System.Windows.Forms.Label lbl_val;
    }
}

