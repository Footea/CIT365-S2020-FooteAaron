namespace MegaDesk
{
    partial class DisplayQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuotes));
            this.lbldisplayQuote = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldisplayQuote
            // 
            this.lbldisplayQuote.AutoSize = true;
            this.lbldisplayQuote.Location = new System.Drawing.Point(342, 139);
            this.lbldisplayQuote.Name = "lbldisplayQuote";
            this.lbldisplayQuote.Size = new System.Drawing.Size(35, 13);
            this.lbldisplayQuote.TabIndex = 0;
            this.lbldisplayQuote.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.Location = new System.Drawing.Point(363, 214);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuote.TabIndex = 2;
            this.btnAddQuote.Text = "button2";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // DisplayQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbldisplayQuote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayQuotes";
            this.Text = "DisplayQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldisplayQuote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddQuote;
    }
}