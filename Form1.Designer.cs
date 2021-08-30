
namespace bai1
{
    partial class txtso
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
            this.txtNhap = new System.Windows.Forms.Label();
            this.txtDaySo = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.Label();
            this.txtTongle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.AutoSize = true;
            this.txtNhap.BackColor = System.Drawing.SystemColors.Control;
            this.txtNhap.Location = new System.Drawing.Point(39, 9);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(65, 17);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.Text = "Nhập số:";
            // 
            // txtDaySo
            // 
            this.txtDaySo.AutoSize = true;
            this.txtDaySo.Location = new System.Drawing.Point(39, 62);
            this.txtDaySo.Name = "txtDaySo";
            this.txtDaySo.Size = new System.Drawing.Size(119, 17);
            this.txtDaySo.TabIndex = 1;
            this.txtDaySo.Text = "Dãy số vừa nhập:";
            // 
            // txtTong
            // 
            this.txtTong.AutoSize = true;
            this.txtTong.Location = new System.Drawing.Point(39, 124);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(187, 17);
            this.txtTong.TabIndex = 2;
            this.txtTong.Text = "Tổng các phần tử trong dãy:";
            // 
            // txtTongChan
            // 
            this.txtTongChan.AutoSize = true;
            this.txtTongChan.Location = new System.Drawing.Point(39, 188);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(80, 17);
            this.txtTongChan.TabIndex = 3;
            this.txtTongChan.Text = "Tổng chẵn:";
            // 
            // txtTongle
            // 
            this.txtTongle.AutoSize = true;
            this.txtTongle.Location = new System.Drawing.Point(39, 253);
            this.txtTongle.Name = "txtTongle";
            this.txtTongle.Size = new System.Drawing.Size(60, 17);
            this.txtTongle.TabIndex = 4;
            this.txtTongle.Text = "Tổng lẻ:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(126, 248);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTongle);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtDaySo);
            this.Controls.Add(this.txtNhap);
            this.Name = "txtso";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNhap;
        private System.Windows.Forms.Label txtDaySo;
        private System.Windows.Forms.Label txtTong;
        private System.Windows.Forms.Label txtTongChan;
        private System.Windows.Forms.Label txtTongle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
    }
}

