namespace GorselProgramlama
{
    partial class FirstScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstScreen));
            this.btn_SupplierLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CustomerLogin = new System.Windows.Forms.Button();
            this.btn_AdminLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SupplierLogin
            // 
            this.btn_SupplierLogin.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SupplierLogin.Location = new System.Drawing.Point(586, 244);
            this.btn_SupplierLogin.Name = "btn_SupplierLogin";
            this.btn_SupplierLogin.Size = new System.Drawing.Size(166, 88);
            this.btn_SupplierLogin.TabIndex = 9;
            this.btn_SupplierLogin.Text = "Tedarikçi Girişi";
            this.btn_SupplierLogin.UseVisualStyleBackColor = true;
            this.btn_SupplierLogin.Click += new System.EventHandler(this.btn_SupplierLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(194, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tedarik Yönetimi Uygulaması";
            // 
            // btn_CustomerLogin
            // 
            this.btn_CustomerLogin.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CustomerLogin.Location = new System.Drawing.Point(307, 244);
            this.btn_CustomerLogin.Name = "btn_CustomerLogin";
            this.btn_CustomerLogin.Size = new System.Drawing.Size(166, 88);
            this.btn_CustomerLogin.TabIndex = 10;
            this.btn_CustomerLogin.Text = "Müşteri Girişi";
            this.btn_CustomerLogin.UseVisualStyleBackColor = true;
            this.btn_CustomerLogin.Click += new System.EventHandler(this.btn_CustomerLogin_Click);
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AdminLogin.Location = new System.Drawing.Point(49, 244);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(166, 88);
            this.btn_AdminLogin.TabIndex = 8;
            this.btn_AdminLogin.Text = "Admin Girişi";
            this.btn_AdminLogin.UseVisualStyleBackColor = true;
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 98);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FirstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_SupplierLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CustomerLogin);
            this.Controls.Add(this.btn_AdminLogin);
            this.Name = "FirstScreen";
            this.Text = "SupplyManagementSystem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SupplierLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CustomerLogin;
        private System.Windows.Forms.Button btn_AdminLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}