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
            this.SuspendLayout();
            // 
            // btn_Json_Kurgu
            // 
            this.btn_Json_Kurgu.Location = new System.Drawing.Point(586, 381);
            this.btn_Json_Kurgu.Name = "btn_Json_Kurgu";
            this.btn_Json_Kurgu.Size = new System.Drawing.Size(202, 57);
            this.btn_Json_Kurgu.TabIndex = 0;
            this.btn_Json_Kurgu.Text = "Json Data Çek ve Kaydet";
            this.btn_Json_Kurgu.UseVisualStyleBackColor = true;
            this.btn_Json_Kurgu.Click += new System.EventHandler(this.btn_Json_Kurgu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Json_Kurgu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Json_Kurgu;
    }
}

