namespace GorselProgramlama.Screens.CustomersScreens
{
    partial class CustomerOrderManagementScreen
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
            this.customerOrderManagementNewOrder1 = new GorselProgramlama.Screens.CustomersScreens.CustomerOrderManagementNewOrder();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customerOrderManagementEditAndDeleteOrderScreen1 = new GorselProgramlama.Screens.CustomersScreens.CustomerOrderManagementEditAndDeleteOrderScreen();
            this.SuspendLayout();
            // 
            // customerOrderManagementNewOrder1
            // 
            this.customerOrderManagementNewOrder1.BackColor = System.Drawing.Color.Peru;
            this.customerOrderManagementNewOrder1.Location = new System.Drawing.Point(31, 156);
            this.customerOrderManagementNewOrder1.Margin = new System.Windows.Forms.Padding(5);
            this.customerOrderManagementNewOrder1.Name = "customerOrderManagementNewOrder1";
            this.customerOrderManagementNewOrder1.Size = new System.Drawing.Size(1129, 511);
            this.customerOrderManagementNewOrder1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tedarik Yönetimi Sistemi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(-3, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(584, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sipariş Verme Ekranı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(576, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(628, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sipariş Düzenleme Ve İptal Etme Ekranı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerOrderManagementEditAndDeleteOrderScreen1
            // 
            this.customerOrderManagementEditAndDeleteOrderScreen1.BackColor = System.Drawing.Color.Peru;
            this.customerOrderManagementEditAndDeleteOrderScreen1.Location = new System.Drawing.Point(31, 156);
            this.customerOrderManagementEditAndDeleteOrderScreen1.Margin = new System.Windows.Forms.Padding(5);
            this.customerOrderManagementEditAndDeleteOrderScreen1.Name = "customerOrderManagementEditAndDeleteOrderScreen1";
            this.customerOrderManagementEditAndDeleteOrderScreen1.Size = new System.Drawing.Size(1157, 561);
            this.customerOrderManagementEditAndDeleteOrderScreen1.TabIndex = 10;
            // 
            // CustomerOrderManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1199, 682);
            this.Controls.Add(this.customerOrderManagementEditAndDeleteOrderScreen1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerOrderManagementNewOrder1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerOrderManagementScreen";
            this.Text = "CustomerOrderManagementScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerOrderManagementNewOrder customerOrderManagementNewOrder1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private CustomerOrderManagementEditAndDeleteOrderScreen customerOrderManagementEditAndDeleteOrderScreen1;
    }
}