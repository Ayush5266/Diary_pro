
namespace diary_pro.My_Forms
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.panel5 = new System.Windows.Forms.Panel();
            this.pass_textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usern_label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pass_textBox2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.usern_label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.user_pictureBox1);
            this.panel5.Location = new System.Drawing.Point(80, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 324);
            this.panel5.TabIndex = 8;
            // 
            // pass_textBox2
            // 
            this.pass_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_textBox2.Location = new System.Drawing.Point(115, 235);
            this.pass_textBox2.Name = "pass_textBox2";
            this.pass_textBox2.PasswordChar = '*';
            this.pass_textBox2.Size = new System.Drawing.Size(249, 26);
            this.pass_textBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // usern_label6
            // 
            this.usern_label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usern_label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usern_label6.ForeColor = System.Drawing.Color.DarkRed;
            this.usern_label6.Location = new System.Drawing.Point(115, 187);
            this.usern_label6.Name = "usern_label6";
            this.usern_label6.Size = new System.Drawing.Size(249, 32);
            this.usern_label6.TabIndex = 5;
            this.usern_label6.Text = "-";
            this.usern_label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to Diary Application";
            // 
            // button1
            // 
            this.button1.Image = global::diary_pro.Properties.Resources._34217_close_delete_remove_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(404, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::diary_pro.Properties.Resources._282474_ok_done_check_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(80, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "OK";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user_pictureBox1
            // 
            this.user_pictureBox1.BackColor = System.Drawing.Color.White;
            this.user_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pictureBox1.Location = new System.Drawing.Point(135, 14);
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.Size = new System.Drawing.Size(144, 137);
            this.user_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_pictureBox1.TabIndex = 3;
            this.user_pictureBox1.TabStop = false;
            this.user_pictureBox1.Click += new System.EventHandler(this.user_pictureBox1_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(576, 620);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Diary Pro";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label usern_label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox user_pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass_textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}