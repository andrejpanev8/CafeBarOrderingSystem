namespace CafeBarOrderingSystem
{
    partial class View_Order
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
            this.lvProductRows = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lblFullPrice = new System.Windows.Forms.Label();
            this.tbFullPrice = new System.Windows.Forms.TextBox();
            this.lblSpecialRequest = new System.Windows.Forms.Label();
            this.tbSpeacialRequest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvProductRows
            // 
            this.lvProductRows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lvProductRows.FullRowSelect = true;
            this.lvProductRows.HideSelection = false;
            this.lvProductRows.Location = new System.Drawing.Point(13, 13);
            this.lvProductRows.Name = "lvProductRows";
            this.lvProductRows.Size = new System.Drawing.Size(553, 360);
            this.lvProductRows.TabIndex = 0;
            this.lvProductRows.UseCompatibleStateImageBehavior = false;
            this.lvProductRows.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price of product";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 100;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(572, 290);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(174, 29);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Delete from order";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(572, 337);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(174, 29);
            this.btnMakeOrder.TabIndex = 2;
            this.btnMakeOrder.Text = "Make order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(572, 241);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(174, 32);
            this.btnCancelOrder.TabIndex = 3;
            this.btnCancelOrder.Text = "Cancel order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // lblFullPrice
            // 
            this.lblFullPrice.AutoSize = true;
            this.lblFullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblFullPrice.Location = new System.Drawing.Point(572, 173);
            this.lblFullPrice.Name = "lblFullPrice";
            this.lblFullPrice.Size = new System.Drawing.Size(106, 26);
            this.lblFullPrice.TabIndex = 4;
            this.lblFullPrice.Text = "Full price:";
            // 
            // tbFullPrice
            // 
            this.tbFullPrice.Location = new System.Drawing.Point(572, 215);
            this.tbFullPrice.Name = "tbFullPrice";
            this.tbFullPrice.ReadOnly = true;
            this.tbFullPrice.Size = new System.Drawing.Size(174, 20);
            this.tbFullPrice.TabIndex = 5;
            // 
            // lblSpecialRequest
            // 
            this.lblSpecialRequest.AutoSize = true;
            this.lblSpecialRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSpecialRequest.Location = new System.Drawing.Point(568, 13);
            this.lblSpecialRequest.Name = "lblSpecialRequest";
            this.lblSpecialRequest.Size = new System.Drawing.Size(171, 26);
            this.lblSpecialRequest.TabIndex = 6;
            this.lblSpecialRequest.Text = "Special Request";
            // 
            // tbSpeacialRequest
            // 
            this.tbSpeacialRequest.Location = new System.Drawing.Point(573, 42);
            this.tbSpeacialRequest.Multiline = true;
            this.tbSpeacialRequest.Name = "tbSpeacialRequest";
            this.tbSpeacialRequest.ReadOnly = true;
            this.tbSpeacialRequest.Size = new System.Drawing.Size(173, 128);
            this.tbSpeacialRequest.TabIndex = 7;
            // 
            // View_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 440);
            this.Controls.Add(this.tbSpeacialRequest);
            this.Controls.Add(this.lblSpecialRequest);
            this.Controls.Add(this.tbFullPrice);
            this.Controls.Add(this.lblFullPrice);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.lvProductRows);
            this.Name = "View_Order";
            this.Text = "View Order";
            this.Load += new System.EventHandler(this.View_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProductRows;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label lblFullPrice;
        private System.Windows.Forms.TextBox tbFullPrice;
        private System.Windows.Forms.Label lblSpecialRequest;
        private System.Windows.Forms.TextBox tbSpeacialRequest;
    }
}