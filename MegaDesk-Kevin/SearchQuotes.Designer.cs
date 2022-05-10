namespace MegaDesk_Kevin
{
    partial class SearchQuotes
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
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Location = new System.Drawing.Point(449, 630);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(349, 116);
            this.btnCancelSearch.TabIndex = 0;
            this.btnCancelSearch.Text = "Cancel";
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 829);
            this.Controls.Add(this.btnCancelSearch);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelSearch;
    }
}