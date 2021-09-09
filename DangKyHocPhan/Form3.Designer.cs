namespace DangKyHocPhan
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.butquay = new System.Windows.Forms.Button();
            this.buttiep = new System.Windows.Forms.Button();
            this.label_thongbao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thanh Toán";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(23, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(221, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Đóng trực tiếp tại trung tâm";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(23, 130);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(241, 24);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Chuyển khoản qua ngân hàng";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // butquay
            // 
            this.butquay.Location = new System.Drawing.Point(40, 179);
            this.butquay.Name = "butquay";
            this.butquay.Size = new System.Drawing.Size(84, 26);
            this.butquay.TabIndex = 9;
            this.butquay.Text = "Quay lại";
            this.butquay.UseVisualStyleBackColor = true;
            this.butquay.Click += new System.EventHandler(this.butquay_Click);
            // 
            // buttiep
            // 
            this.buttiep.Location = new System.Drawing.Point(146, 179);
            this.buttiep.Name = "buttiep";
            this.buttiep.Size = new System.Drawing.Size(84, 26);
            this.buttiep.TabIndex = 10;
            this.buttiep.Text = "Tiếp theo";
            this.buttiep.UseVisualStyleBackColor = true;
            this.buttiep.Click += new System.EventHandler(this.buttiep_Click);
            // 
            // label_thongbao
            // 
            this.label_thongbao.AutoSize = true;
            this.label_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thongbao.ForeColor = System.Drawing.Color.Red;
            this.label_thongbao.Location = new System.Drawing.Point(20, 18);
            this.label_thongbao.Name = "label_thongbao";
            this.label_thongbao.Size = new System.Drawing.Size(45, 16);
            this.label_thongbao.TabIndex = 11;
            this.label_thongbao.Text = "label2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 235);
            this.Controls.Add(this.label_thongbao);
            this.Controls.Add(this.buttiep);
            this.Controls.Add(this.butquay);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button butquay;
        private System.Windows.Forms.Button buttiep;
        private System.Windows.Forms.Label label_thongbao;
    }
}