namespace MegaDesk
{
    partial class ViewQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewQuotes));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblViewQuotesForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 445);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(8);
            this.btnReturn.Size = new System.Drawing.Size(150, 42);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblViewQuotesForm
            // 
            this.lblViewQuotesForm.AutoSize = true;
            this.lblViewQuotesForm.BackColor = System.Drawing.Color.SteelBlue;
            this.lblViewQuotesForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblViewQuotesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewQuotesForm.ForeColor = System.Drawing.Color.White;
            this.lblViewQuotesForm.Location = new System.Drawing.Point(156, 9);
            this.lblViewQuotesForm.Name = "lblViewQuotesForm";
            this.lblViewQuotesForm.Padding = new System.Windows.Forms.Padding(10);
            this.lblViewQuotesForm.Size = new System.Drawing.Size(282, 45);
            this.lblViewQuotesForm.TabIndex = 7;
            this.lblViewQuotesForm.Text = "View MegaDesk Quotes";
            this.lblViewQuotesForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 499);
            this.Controls.Add(this.lblViewQuotesForm);
            this.Controls.Add(this.btnReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewQuotes";
            this.Text = "View Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblViewQuotesForm;
    }
}