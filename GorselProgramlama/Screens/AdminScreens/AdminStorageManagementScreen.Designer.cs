namespace GorselProgramlama.Screens.AdminScreens
{
    partial class AdminStorageManagementScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete_User_btn = new System.Windows.Forms.Button();
            this.add_User_btn = new System.Windows.Forms.Button();
            this.edit_User_btn = new System.Windows.Forms.Button();
            this.adminStorageManagementAddStorageScreen1 = new GorselProgramlama.Screens.AdminScreens.AdminStorageManagementAddStorageScreen();
            this.adminStorageManagementDeleteStorageScreen1 = new GorselProgramlama.Screens.AdminScreens.AdminStorageManagementDeleteStorageScreen();
            this.adminStorageManagementEditStorageScreen1 = new GorselProgramlama.Screens.AdminScreens.AdminStorageManagementEditStorageScreen();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tedarik Yönetimi Sistemi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.adminStorageManagementEditStorageScreen1);
            this.panel1.Controls.Add(this.adminStorageManagementDeleteStorageScreen1);
            this.panel1.Controls.Add(this.adminStorageManagementAddStorageScreen1);
            this.panel1.Controls.Add(this.delete_User_btn);
            this.panel1.Controls.Add(this.add_User_btn);
            this.panel1.Controls.Add(this.edit_User_btn);
            this.panel1.Location = new System.Drawing.Point(-1, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 451);
            this.panel1.TabIndex = 11;
            // 
            // delete_User_btn
            // 
            this.delete_User_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete_User_btn.Location = new System.Drawing.Point(518, 0);
            this.delete_User_btn.Name = "delete_User_btn";
            this.delete_User_btn.Size = new System.Drawing.Size(282, 46);
            this.delete_User_btn.TabIndex = 8;
            this.delete_User_btn.Text = "Depo Sil";
            this.delete_User_btn.UseVisualStyleBackColor = true;
            this.delete_User_btn.Click += new System.EventHandler(this.delete_User_btn_Click);
            // 
            // add_User_btn
            // 
            this.add_User_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_User_btn.Location = new System.Drawing.Point(0, 0);
            this.add_User_btn.Name = "add_User_btn";
            this.add_User_btn.Size = new System.Drawing.Size(273, 46);
            this.add_User_btn.TabIndex = 7;
            this.add_User_btn.Text = "Depo Ekle";
            this.add_User_btn.UseVisualStyleBackColor = true;
            this.add_User_btn.Click += new System.EventHandler(this.add_User_btn_Click);
            // 
            // edit_User_btn
            // 
            this.edit_User_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.edit_User_btn.Location = new System.Drawing.Point(267, 0);
            this.edit_User_btn.Name = "edit_User_btn";
            this.edit_User_btn.Size = new System.Drawing.Size(257, 46);
            this.edit_User_btn.TabIndex = 9;
            this.edit_User_btn.Text = "Depo Düzenle";
            this.edit_User_btn.UseVisualStyleBackColor = true;
            this.edit_User_btn.Click += new System.EventHandler(this.edit_User_btn_Click);
            // 
            // adminStorageManagementAddStorageScreen1
            // 
            this.adminStorageManagementAddStorageScreen1.BackColor = System.Drawing.Color.Tan;
            this.adminStorageManagementAddStorageScreen1.Location = new System.Drawing.Point(98, 52);
            this.adminStorageManagementAddStorageScreen1.Name = "adminStorageManagementAddStorageScreen1";
            this.adminStorageManagementAddStorageScreen1.Size = new System.Drawing.Size(605, 408);
            this.adminStorageManagementAddStorageScreen1.TabIndex = 10;
            // 
            // adminStorageManagementDeleteStorageScreen1
            // 
            this.adminStorageManagementDeleteStorageScreen1.BackColor = System.Drawing.Color.Tan;
            this.adminStorageManagementDeleteStorageScreen1.Location = new System.Drawing.Point(98, 52);
            this.adminStorageManagementDeleteStorageScreen1.Name = "adminStorageManagementDeleteStorageScreen1";
            this.adminStorageManagementDeleteStorageScreen1.Size = new System.Drawing.Size(605, 408);
            this.adminStorageManagementDeleteStorageScreen1.TabIndex = 11;
            // 
            // adminStorageManagementEditStorageScreen1
            // 
            this.adminStorageManagementEditStorageScreen1.BackColor = System.Drawing.Color.Tan;
            this.adminStorageManagementEditStorageScreen1.Location = new System.Drawing.Point(98, 52);
            this.adminStorageManagementEditStorageScreen1.Name = "adminStorageManagementEditStorageScreen1";
            this.adminStorageManagementEditStorageScreen1.Size = new System.Drawing.Size(605, 408);
            this.adminStorageManagementEditStorageScreen1.TabIndex = 12;
            // 
            // AdminStorageManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "AdminStorageManagementScreen";
            this.Text = "AdminStorageManagementScreen";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete_User_btn;
        private System.Windows.Forms.Button add_User_btn;
        private System.Windows.Forms.Button edit_User_btn;
        private AdminStorageManagementEditStorageScreen adminStorageManagementEditStorageScreen1;
        private AdminStorageManagementDeleteStorageScreen adminStorageManagementDeleteStorageScreen1;
        private AdminStorageManagementAddStorageScreen adminStorageManagementAddStorageScreen1;
    }
}