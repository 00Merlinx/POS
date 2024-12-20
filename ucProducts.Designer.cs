namespace RestaurantManagementSystem
{
    partial class ucProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProducts));
            this.ProductName = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.AllowParentOverrides = false;
            this.ProductName.AutoEllipsis = false;
            this.ProductName.CursorType = System.Windows.Forms.Cursors.Default;
            this.ProductName.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.ProductName.Location = new System.Drawing.Point(12, 2);
            this.ProductName.Name = "ProductName";
            this.ProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductName.Size = new System.Drawing.Size(102, 47);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "Shawarma Rice \r\nwith Chesse";
            this.ProductName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ProductName);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(126, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel ProductName;
    }
}
