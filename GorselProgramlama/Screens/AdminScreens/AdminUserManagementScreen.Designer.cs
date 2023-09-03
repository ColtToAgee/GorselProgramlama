namespace GorselProgramlama.Screens.AdminScreens
{
    partial class AdminUserManagementScreen
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
            this.add_User_btn = new System.Windows.Forms.Button();
            this.delete_User_btn = new System.Windows.Forms.Button();
            this.edit_User_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminUserManagementAddUserScreen1 = new GorselProgramlama.Screens.AdminScreens.AdminUserManagementAddUserScreen();
            this.adminUserManagementDeleteUserScreen1 = new GorselProgramlama.Screens.AdminScreens.AdminUserManagementDeleteUserScreen();
            this.adminUserManagementEditUserScreen1 = new GorselProgramlama.Screens.AdminScreens.AdminUserManagementEditUserScreen();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_User_btn
            // 
            this.add_User_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_User_btn.Location = new System.Drawing.Point(-1, 65);
            this.add_User_btn.Name = "add_User_btn";
            this.add_User_btn.Size = new System.Drawing.Size(273, 46);
            this.add_User_btn.TabIndex = 0;
            this.add_User_btn.Text = "Kullanıcı Ekle";
            this.add_User_btn.UseVisualStyleBackColor = true;
            this.add_User_btn.Click += new System.EventHandler(this.add_User_btn_Click);
            // 
            // delete_User_btn
            // 
            this.delete_User_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete_User_btn.Location = new System.Drawing.Point(520, 65);
            this.delete_User_btn.Name = "delete_User_btn";
            this.delete_User_btn.Size = new System.Drawing.Size(282, 46);
            this.delete_User_btn.TabIndex = 2;
            this.delete_User_btn.Text = "Kullanıcı Sil";
            this.delete_User_btn.UseVisualStyleBackColor = true;
            this.delete_User_btn.Click += new System.EventHandler(this.delete_User_btn_Click);
            // 
            // edit_User_btn
            // 
            this.edit_User_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.edit_User_btn.Location = new System.Drawing.Point(266, 65);
            this.edit_User_btn.Name = "edit_User_btn";
            this.edit_User_btn.Size = new System.Drawing.Size(257, 46);
            this.edit_User_btn.TabIndex = 3;
            this.edit_User_btn.Text = "Kullanıcı Düzenle";
            this.edit_User_btn.UseVisualStyleBackColor = true;
            this.edit_User_btn.Click += new System.EventHandler(this.edit_User_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tedarik Yönetimi Sistemi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.adminUserManagementEditUserScreen1);
            this.panel1.Controls.Add(this.adminUserManagementDeleteUserScreen1);
            this.panel1.Controls.Add(this.adminUserManagementAddUserScreen1);
            this.panel1.Location = new System.Drawing.Point(-1, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 416);
            this.panel1.TabIndex = 6;
            // 
            // adminUserManagementAddUserScreen1
            // 
            this.adminUserManagementAddUserScreen1.BackColor = System.Drawing.Color.Tan;
            this.adminUserManagementAddUserScreen1.Location = new System.Drawing.Point(97, 0);
            this.adminUserManagementAddUserScreen1.Name = "adminUserManagementAddUserScreen1";
            this.adminUserManagementAddUserScreen1.Size = new System.Drawing.Size(644, 405);
            this.adminUserManagementAddUserScreen1.TabIndex = 0;
            // 
            // adminUserManagementDeleteUserScreen1
            // 
            this.adminUserManagementDeleteUserScreen1.BackColor = System.Drawing.Color.Tan;
            this.adminUserManagementDeleteUserScreen1.Location = new System.Drawing.Point(105, 8);
            this.adminUserManagementDeleteUserScreen1.Name = "adminUserManagementDeleteUserScreen1";
            this.adminUserManagementDeleteUserScreen1.Size = new System.Drawing.Size(599, 401);
            this.adminUserManagementDeleteUserScreen1.TabIndex = 1;
            // 
            // adminUserManagementEditUserScreen1
            // 
            this.adminUserManagementEditUserScreen1.BackColor = System.Drawing.Color.Tan;
            this.adminUserManagementEditUserScreen1.Location = new System.Drawing.Point(105, 0);
            this.adminUserManagementEditUserScreen1.Name = "adminUserManagementEditUserScreen1";
            this.adminUserManagementEditUserScreen1.Size = new System.Drawing.Size(605, 408);
            this.adminUserManagementEditUserScreen1.TabIndex = 2;
            // 
            // AdminUserManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_User_btn);
            this.Controls.Add(this.delete_User_btn);
            this.Controls.Add(this.add_User_btn);
            this.Name = "AdminUserManagementScreen";
            this.Text = "AdminUserManagementScreen";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_User_btn;
        private System.Windows.Forms.Button delete_User_btn;
        private System.Windows.Forms.Button edit_User_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private AdminUserManagementEditUserScreen adminUserManagementEditUserScreen1;
        private AdminUserManagementDeleteUserScreen adminUserManagementDeleteUserScreen1;
        private AdminUserManagementAddUserScreen adminUserManagementAddUserScreen1;
    }
}