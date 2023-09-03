namespace GorselProgramlama.Screens.CustomersScreens
{
    partial class CustomerStorageManagementScreen
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.customerStorageManagementAddStorageScreen1 = new GorselProgramlama.Screens.CustomersScreens.CustomerStorageManagementAddStorageScreen();
            this.customerStorageManagementDeleteStorageScreen1 = new GorselProgramlama.Screens.CustomersScreens.CustomerStorageManagementDeleteStorageScreen();
            this.customerStorageManagementEditStorageScreen1 = new GorselProgramlama.Screens.CustomersScreens.CustomerStorageManagementEditStorageScreen();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(800, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(409, 44);
            this.button2.TabIndex = 12;
            this.button2.Text = "Depo Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(0, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(405, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Depo Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tedarik Yönetimi Sistemi";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(403, 70);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(405, 44);
            this.button3.TabIndex = 13;
            this.button3.Text = "Depo Düzenle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // customerStorageManagementAddStorageScreen1
            // 
            this.customerStorageManagementAddStorageScreen1.BackColor = System.Drawing.Color.Peru;
            this.customerStorageManagementAddStorageScreen1.Location = new System.Drawing.Point(221, 121);
            this.customerStorageManagementAddStorageScreen1.Name = "customerStorageManagementAddStorageScreen1";
            this.customerStorageManagementAddStorageScreen1.Size = new System.Drawing.Size(807, 502);
            this.customerStorageManagementAddStorageScreen1.TabIndex = 14;
            // 
            // customerStorageManagementDeleteStorageScreen1
            // 
            this.customerStorageManagementDeleteStorageScreen1.BackColor = System.Drawing.Color.Peru;
            this.customerStorageManagementDeleteStorageScreen1.Location = new System.Drawing.Point(221, 121);
            this.customerStorageManagementDeleteStorageScreen1.Name = "customerStorageManagementDeleteStorageScreen1";
            this.customerStorageManagementDeleteStorageScreen1.Size = new System.Drawing.Size(807, 502);
            this.customerStorageManagementDeleteStorageScreen1.TabIndex = 15;
            // 
            // customerStorageManagementEditStorageScreen1
            // 
            this.customerStorageManagementEditStorageScreen1.BackColor = System.Drawing.Color.Peru;
            this.customerStorageManagementEditStorageScreen1.Location = new System.Drawing.Point(177, 121);
            this.customerStorageManagementEditStorageScreen1.Name = "customerStorageManagementEditStorageScreen1";
            this.customerStorageManagementEditStorageScreen1.Size = new System.Drawing.Size(807, 502);
            this.customerStorageManagementEditStorageScreen1.TabIndex = 16;
            // 
            // CustomerStorageManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1207, 604);
            this.Controls.Add(this.customerStorageManagementEditStorageScreen1);
            this.Controls.Add(this.customerStorageManagementDeleteStorageScreen1);
            this.Controls.Add(this.customerStorageManagementAddStorageScreen1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerStorageManagementScreen";
            this.Text = "CustomerStorageManagementScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private CustomerStorageManagementAddStorageScreen customerStorageManagementAddStorageScreen1;
        private CustomerStorageManagementDeleteStorageScreen customerStorageManagementDeleteStorageScreen1;
        private CustomerStorageManagementEditStorageScreen customerStorageManagementEditStorageScreen1;
    }
}