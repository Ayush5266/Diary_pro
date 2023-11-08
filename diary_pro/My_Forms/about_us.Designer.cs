
namespace diary_pro.My_Forms
{
    partial class about_us
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about_us));
            this.panel1 = new System.Windows.Forms.Panel();
            this.co_label4 = new System.Windows.Forms.Label();
            this.copy_label3 = new System.Windows.Forms.Label();
            this.ver_label2 = new System.Windows.Forms.Label();
            this.pro_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 1);
            this.panel1.TabIndex = 9;
            // 
            // co_label4
            // 
            this.co_label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.co_label4.Location = new System.Drawing.Point(165, 46);
            this.co_label4.Name = "co_label4";
            this.co_label4.Size = new System.Drawing.Size(246, 59);
            this.co_label4.TabIndex = 8;
            this.co_label4.Text = "Ayush Dhakad";
            this.co_label4.Click += new System.EventHandler(this.co_label4_Click);
            // 
            // copy_label3
            // 
            this.copy_label3.Location = new System.Drawing.Point(186, 326);
            this.copy_label3.Name = "copy_label3";
            this.copy_label3.Size = new System.Drawing.Size(157, 30);
            this.copy_label3.TabIndex = 7;
            this.copy_label3.Text = "All Right Reserved";
            // 
            // ver_label2
            // 
            this.ver_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_label2.Location = new System.Drawing.Point(102, 179);
            this.ver_label2.Name = "ver_label2";
            this.ver_label2.Size = new System.Drawing.Size(280, 30);
            this.ver_label2.TabIndex = 6;
            this.ver_label2.Text = "Version : 2023.2.14";
            // 
            // pro_label1
            // 
            this.pro_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_label1.Location = new System.Drawing.Point(102, 135);
            this.pro_label1.Name = "pro_label1";
            this.pro_label1.Size = new System.Drawing.Size(280, 30);
            this.pro_label1.TabIndex = 5;
            this.pro_label1.Text = "Product Name : PhoneBook";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Programmer : AK";
            // 
            // about_us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(559, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.co_label4);
            this.Controls.Add(this.copy_label3);
            this.Controls.Add(this.ver_label2);
            this.Controls.Add(this.pro_label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "about_us";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.Load += new System.EventHandler(this.about_us_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label co_label4;
        private System.Windows.Forms.Label copy_label3;
        private System.Windows.Forms.Label ver_label2;
        private System.Windows.Forms.Label pro_label1;
        private System.Windows.Forms.Label label1;
    }
}