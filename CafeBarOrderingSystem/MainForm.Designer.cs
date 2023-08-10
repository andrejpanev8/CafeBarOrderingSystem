
namespace CafeBarOrderingSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGuestView = new System.Windows.Forms.Button();
            this.btnStaffView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuestView
            // 
            this.btnGuestView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuestView.Location = new System.Drawing.Point(438, 172);
            this.btnGuestView.Name = "btnGuestView";
            this.btnGuestView.Size = new System.Drawing.Size(160, 107);
            this.btnGuestView.TabIndex = 1;
            this.btnGuestView.Text = "GuestView";
            this.btnGuestView.UseVisualStyleBackColor = true;
            this.btnGuestView.Click += new System.EventHandler(this.btnGuestView_Click);
            // 
            // btnStaffView
            // 
            this.btnStaffView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStaffView.Location = new System.Drawing.Point(202, 172);
            this.btnStaffView.Name = "btnStaffView";
            this.btnStaffView.Size = new System.Drawing.Size(160, 107);
            this.btnStaffView.TabIndex = 0;
            this.btnStaffView.Text = "StaffView";
            this.btnStaffView.UseVisualStyleBackColor = true;
            this.btnStaffView.Click += new System.EventHandler(this.btnStaffView_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuestView);
            this.Controls.Add(this.btnStaffView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "View Choice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuestView;
        private System.Windows.Forms.Button btnStaffView;
    }
}

