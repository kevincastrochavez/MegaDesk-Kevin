namespace MegaDesk_Kevin
{
    partial class ViewAllQuotes
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
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.Location = new System.Drawing.Point(452, 610);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(329, 123);
            this.btnCancelAdd.TabIndex = 2;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 829);
            this.Controls.Add(this.btnCancelAdd);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelAdd;
    }
}