namespace Robots_RPG
{
    partial class Shop
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
            this.ShopMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShopMenuButton
            // 
            this.ShopMenuButton.Location = new System.Drawing.Point(13, 13);
            this.ShopMenuButton.Name = "ShopMenuButton";
            this.ShopMenuButton.Size = new System.Drawing.Size(254, 72);
            this.ShopMenuButton.TabIndex = 0;
            this.ShopMenuButton.Text = "button1";
            this.ShopMenuButton.UseVisualStyleBackColor = true;
            this.ShopMenuButton.Click += new System.EventHandler(this.ShopMenuButton_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.ShopMenuButton);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShopMenuButton;
    }
}