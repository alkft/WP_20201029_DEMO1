namespace WP_2020_01_HW02_A32000
{
    partial class frmGame
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.labLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDraw.Location = new System.Drawing.Point(411, 28);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(146, 126);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "抽";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(372, 169);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(303, 357);
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // rtbLog
            // 
            this.rtbLog.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbLog.Location = new System.Drawing.Point(23, 169);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(263, 357);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "1\n2\n3\n";
            // 
            // labLog
            // 
            this.labLog.AutoSize = true;
            this.labLog.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLog.Location = new System.Drawing.Point(45, 69);
            this.labLog.Name = "labLog";
            this.labLog.Size = new System.Drawing.Size(156, 64);
            this.labLog.TabIndex = 3;
            this.labLog.Text = "歷程";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labLog);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.btnDraw);
            this.Name = "frmGame";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label labLog;
    }
}

