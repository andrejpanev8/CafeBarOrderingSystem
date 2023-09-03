namespace CafeBarOrderingSystem
{
    partial class Make_order
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
            this.lvMenuProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvType = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMenuProducts
            // 
            this.lvMenuProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lvMenuProducts.FullRowSelect = true;
            this.lvMenuProducts.HideSelection = false;
            this.lvMenuProducts.Location = new System.Drawing.Point(12, 43);
            this.lvMenuProducts.MultiSelect = false;
            this.lvMenuProducts.Name = "lvMenuProducts";
            this.lvMenuProducts.Size = new System.Drawing.Size(231, 290);
            this.lvMenuProducts.TabIndex = 0;
            this.lvMenuProducts.UseCompatibleStateImageBehavior = false;
            this.lvMenuProducts.View = System.Windows.Forms.View.Details;
            this.lvMenuProducts.SelectedIndexChanged += new System.EventHandler(this.lvMenuProducts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product:";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price:";
            this.columnHeader3.Width = 110;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(432, 286);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(100, 47);
            this.btnAddToOrder.TabIndex = 1;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(553, 286);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(100, 47);
            this.btnViewOrder.TabIndex = 2;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(432, 260);
            this.nupQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(221, 20);
            this.nupQuantity.TabIndex = 3;
            this.nupQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(427, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(432, 43);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(221, 175);
            this.tbDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDescription.Location = new System.Drawing.Point(427, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(168, 26);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Special request:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(244, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type:";
            // 
            // lvType
            // 
            this.lvType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvType.FullRowSelect = true;
            this.lvType.HideSelection = false;
            this.lvType.Location = new System.Drawing.Point(249, 43);
            this.lvType.MultiSelect = false;
            this.lvType.Name = "lvType";
            this.lvType.Size = new System.Drawing.Size(172, 290);
            this.lvType.TabIndex = 9;
            this.lvType.UseCompatibleStateImageBehavior = false;
            this.lvType.View = System.Windows.Forms.View.Details;
            this.lvType.SelectedIndexChanged += new System.EventHandler(this.lvType_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 200;
            // 
            // Make_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 356);
            this.Controls.Add(this.lvType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lvMenuProducts);
            this.Name = "Make_order";
            this.Text = "Make order";
            this.Load += new System.EventHandler(this.Make_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMenuProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvType;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}