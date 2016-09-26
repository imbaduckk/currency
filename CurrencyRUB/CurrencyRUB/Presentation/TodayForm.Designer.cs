namespace CurrencyRUB
{
    partial class TodayForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.lblEUR = new System.Windows.Forms.Label();
            this.lblUSDdif = new System.Windows.Forms.Label();
            this.lblEURdif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "EUR";
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Location = new System.Drawing.Point(40, 80);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(35, 13);
            this.lblUSD.TabIndex = 1;
            this.lblUSD.Text = "label3";
            // 
            // lblEUR
            // 
            this.lblEUR.AutoSize = true;
            this.lblEUR.Location = new System.Drawing.Point(164, 80);
            this.lblEUR.Name = "lblEUR";
            this.lblEUR.Size = new System.Drawing.Size(35, 13);
            this.lblEUR.TabIndex = 1;
            this.lblEUR.Text = "label3";
            // 
            // lblUSDdif
            // 
            this.lblUSDdif.AutoSize = true;
            this.lblUSDdif.Location = new System.Drawing.Point(40, 112);
            this.lblUSDdif.Name = "lblUSDdif";
            this.lblUSDdif.Size = new System.Drawing.Size(35, 13);
            this.lblUSDdif.TabIndex = 2;
            this.lblUSDdif.Text = "label3";
            // 
            // lblEURdif
            // 
            this.lblEURdif.AutoSize = true;
            this.lblEURdif.Location = new System.Drawing.Point(164, 112);
            this.lblEURdif.Name = "lblEURdif";
            this.lblEURdif.Size = new System.Drawing.Size(35, 13);
            this.lblEURdif.TabIndex = 2;
            this.lblEURdif.Text = "label3";
            // 
            // TodayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblEURdif);
            this.Controls.Add(this.lblUSDdif);
            this.Controls.Add(this.lblEUR);
            this.Controls.Add(this.lblUSD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TodayForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TodayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblUSD;
        public System.Windows.Forms.Label lblUSDdif;
        public System.Windows.Forms.Label lblEURdif;
        public System.Windows.Forms.Label lblEUR;
    }
}

