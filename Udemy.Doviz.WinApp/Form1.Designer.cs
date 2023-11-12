namespace Udemy.Doviz.WinApp
{
    partial class Form1
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
            this.btn_Json_Kurgu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_USD_alis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_USD_satis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_EUR_alis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_EUR_satis = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_GBP_alis = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_GBP_satis = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd_kurGecmis = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_kurGecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Json_Kurgu
            // 
            this.btn_Json_Kurgu.Location = new System.Drawing.Point(9, 331);
            this.btn_Json_Kurgu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Json_Kurgu.Name = "btn_Json_Kurgu";
            this.btn_Json_Kurgu.Size = new System.Drawing.Size(172, 37);
            this.btn_Json_Kurgu.TabIndex = 0;
            this.btn_Json_Kurgu.Text = "Json Data Çek ve Kaydet";
            this.btn_Json_Kurgu.UseVisualStyleBackColor = true;
            this.btn_Json_Kurgu.Click += new System.EventHandler(this.btn_Json_Kurgu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_USD_alis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_USD_satis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(172, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USD $";
            // 
            // label_USD_alis
            // 
            this.label_USD_alis.AutoSize = true;
            this.label_USD_alis.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_USD_alis.Location = new System.Drawing.Point(92, 52);
            this.label_USD_alis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_USD_alis.Name = "label_USD_alis";
            this.label_USD_alis.Size = new System.Drawing.Size(52, 23);
            this.label_USD_alis.TabIndex = 0;
            this.label_USD_alis.Text = "19.99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ALIŞ";
            // 
            // label_USD_satis
            // 
            this.label_USD_satis.AutoSize = true;
            this.label_USD_satis.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_USD_satis.Location = new System.Drawing.Point(92, 23);
            this.label_USD_satis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_USD_satis.Name = "label_USD_satis";
            this.label_USD_satis.Size = new System.Drawing.Size(52, 23);
            this.label_USD_satis.TabIndex = 0;
            this.label_USD_satis.Text = "19.99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATIŞ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_EUR_alis);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label_EUR_satis);
            this.groupBox2.Location = new System.Drawing.Point(9, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(172, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EUR €";
            // 
            // label_EUR_alis
            // 
            this.label_EUR_alis.AutoSize = true;
            this.label_EUR_alis.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_EUR_alis.Location = new System.Drawing.Point(92, 51);
            this.label_EUR_alis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_EUR_alis.Name = "label_EUR_alis";
            this.label_EUR_alis.Size = new System.Drawing.Size(52, 23);
            this.label_EUR_alis.TabIndex = 0;
            this.label_EUR_alis.Text = "19.99";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(4, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "ALIŞ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "SATIŞ";
            // 
            // label_EUR_satis
            // 
            this.label_EUR_satis.AutoSize = true;
            this.label_EUR_satis.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_EUR_satis.Location = new System.Drawing.Point(92, 22);
            this.label_EUR_satis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_EUR_satis.Name = "label_EUR_satis";
            this.label_EUR_satis.Size = new System.Drawing.Size(52, 23);
            this.label_EUR_satis.TabIndex = 0;
            this.label_EUR_satis.Text = "19.99";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_GBP_alis);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label_GBP_satis);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(9, 224);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(172, 102);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GBP €";
            // 
            // label_GBP_alis
            // 
            this.label_GBP_alis.AutoSize = true;
            this.label_GBP_alis.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_GBP_alis.Location = new System.Drawing.Point(92, 62);
            this.label_GBP_alis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_GBP_alis.Name = "label_GBP_alis";
            this.label_GBP_alis.Size = new System.Drawing.Size(52, 23);
            this.label_GBP_alis.TabIndex = 0;
            this.label_GBP_alis.Text = "19.99";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(4, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "ALIŞ";
            // 
            // label_GBP_satis
            // 
            this.label_GBP_satis.AutoSize = true;
            this.label_GBP_satis.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_GBP_satis.Location = new System.Drawing.Point(92, 32);
            this.label_GBP_satis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_GBP_satis.Name = "label_GBP_satis";
            this.label_GBP_satis.Size = new System.Drawing.Size(52, 23);
            this.label_GBP_satis.TabIndex = 0;
            this.label_GBP_satis.Text = "19.99";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(4, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "SATIŞ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd_kurGecmis);
            this.groupBox4.Location = new System.Drawing.Point(185, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(576, 317);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kur Geçmişi";
            // 
            // grd_kurGecmis
            // 
            this.grd_kurGecmis.AllowUserToAddRows = false;
            this.grd_kurGecmis.AllowUserToDeleteRows = false;
            this.grd_kurGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_kurGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_kurGecmis.Location = new System.Drawing.Point(2, 15);
            this.grd_kurGecmis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grd_kurGecmis.Name = "grd_kurGecmis";
            this.grd_kurGecmis.ReadOnly = true;
            this.grd_kurGecmis.RowHeadersWidth = 51;
            this.grd_kurGecmis.RowTemplate.Height = 24;
            this.grd_kurGecmis.Size = new System.Drawing.Size(572, 300);
            this.grd_kurGecmis.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(772, 374);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_Json_Kurgu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doviz Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_kurGecmis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Json_Kurgu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_USD_alis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_USD_satis;
        private System.Windows.Forms.Label label_EUR_alis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_EUR_satis;
        private System.Windows.Forms.Label label_GBP_alis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_GBP_satis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grd_kurGecmis;
    }
}

