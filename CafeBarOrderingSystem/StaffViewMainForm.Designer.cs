
namespace CafeBarOrderingSystem
{
    partial class StaffViewMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addProductsMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.finishedOrdersMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.earningsMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductsMenuBtn,
            this.finishedOrdersMenuBtn,
            this.earningsMenuBtn,
            this.productsMenuBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
<<<<<<< HEAD
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
=======
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
>>>>>>> f165c787be891cc56957c126c17986942f68a796
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addProductsMenuBtn
            // 
            this.addProductsMenuBtn.Name = "addProductsMenuBtn";
<<<<<<< HEAD
            this.addProductsMenuBtn.Size = new System.Drawing.Size(86, 20);
=======
            this.addProductsMenuBtn.Size = new System.Drawing.Size(107, 24);
>>>>>>> f165c787be891cc56957c126c17986942f68a796
            this.addProductsMenuBtn.Text = "Add product";
            this.addProductsMenuBtn.Click += new System.EventHandler(this.addProductsMenuBtn_Click);
            // 
            // finishedOrdersMenuBtn
            // 
            this.finishedOrdersMenuBtn.Name = "finishedOrdersMenuBtn";
<<<<<<< HEAD
            this.finishedOrdersMenuBtn.Size = new System.Drawing.Size(101, 20);
=======
            this.finishedOrdersMenuBtn.Size = new System.Drawing.Size(125, 24);
>>>>>>> f165c787be891cc56957c126c17986942f68a796
            this.finishedOrdersMenuBtn.Text = "Finished Orders";
            this.finishedOrdersMenuBtn.Click += new System.EventHandler(this.finishedOrdersMenuBtn_Click);
            // 
            // earningsMenuBtn
            // 
            this.earningsMenuBtn.Name = "earningsMenuBtn";
<<<<<<< HEAD
            this.earningsMenuBtn.Size = new System.Drawing.Size(114, 20);
=======
            this.earningsMenuBtn.Size = new System.Drawing.Size(142, 24);
>>>>>>> f165c787be891cc56957c126c17986942f68a796
            this.earningsMenuBtn.Text = "Earnings overview";
            // 
            // productsMenuBtn
            // 
            this.productsMenuBtn.Name = "productsMenuBtn";
<<<<<<< HEAD
            this.productsMenuBtn.Size = new System.Drawing.Size(94, 20);
=======
            this.productsMenuBtn.Size = new System.Drawing.Size(116, 24);
>>>>>>> f165c787be891cc56957c126c17986942f68a796
            this.productsMenuBtn.Text = "View Products";
            this.productsMenuBtn.Click += new System.EventHandler(this.productsMenuBtn_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.layoutPanel.Location = new System.Drawing.Point(0, 24);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(600, 342);
=======
            this.layoutPanel.Location = new System.Drawing.Point(0, 28);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(800, 422);
>>>>>>> f165c787be891cc56957c126c17986942f68a796
            this.layoutPanel.TabIndex = 1;
            this.layoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutPanel_Paint);
            // 
            // StaffViewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffViewMainForm";
            this.Text = "StaffViewMainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addProductsMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem finishedOrdersMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem earningsMenuBtn;
        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.ToolStripMenuItem productsMenuBtn;
    }
}