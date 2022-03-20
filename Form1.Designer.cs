namespace NLCS_Euler
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
            this.btn_timchutrinh = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nhapdinh = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xoacanh = new System.Windows.Forms.Button();
            this.txt_chutrinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbox_matran = new System.Windows.Forms.GroupBox();
            this.label_x = new System.Windows.Forms.Label();
            this.gbox_ngang = new System.Windows.Forms.GroupBox();
            this.gbox_doc = new System.Windows.Forms.GroupBox();
            this.btn_themcanh = new System.Windows.Forms.Button();
            this.txt_qtr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.gbox_matran.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_timchutrinh
            // 
            this.btn_timchutrinh.Location = new System.Drawing.Point(660, 615);
            this.btn_timchutrinh.Name = "btn_timchutrinh";
            this.btn_timchutrinh.Size = new System.Drawing.Size(122, 23);
            this.btn_timchutrinh.TabIndex = 0;
            this.btn_timchutrinh.Text = "Tìm Chu trình";
            this.btn_timchutrinh.UseVisualStyleBackColor = true;
            this.btn_timchutrinh.Click += new System.EventHandler(this.btn_timchutrinh_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(1046, 615);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(84, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(731, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "ỨNG DỤNG TÌM CHU TRÌNH EULER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nhapdinh
            // 
            this.txt_nhapdinh.Location = new System.Drawing.Point(660, 65);
            this.txt_nhapdinh.Name = "txt_nhapdinh";
            this.txt_nhapdinh.Size = new System.Drawing.Size(398, 20);
            this.txt_nhapdinh.TabIndex = 5;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_ok.Location = new System.Drawing.Point(1064, 65);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(66, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập vào số đỉnh của đồ thị (số đỉnh không vượt quá 15)";
            // 
            // btn_xoacanh
            // 
            this.btn_xoacanh.Enabled = false;
            this.btn_xoacanh.Location = new System.Drawing.Point(926, 615);
            this.btn_xoacanh.Name = "btn_xoacanh";
            this.btn_xoacanh.Size = new System.Drawing.Size(89, 23);
            this.btn_xoacanh.TabIndex = 15;
            this.btn_xoacanh.Text = "Xóa cạnh";
            this.btn_xoacanh.UseVisualStyleBackColor = true;
            this.btn_xoacanh.Click += new System.EventHandler(this.btn_xoacanh_Click);
            // 
            // txt_chutrinh
            // 
            this.txt_chutrinh.Location = new System.Drawing.Point(660, 668);
            this.txt_chutrinh.Multiline = true;
            this.txt_chutrinh.Name = "txt_chutrinh";
            this.txt_chutrinh.Size = new System.Drawing.Size(470, 20);
            this.txt_chutrinh.TabIndex = 18;
            this.txt_chutrinh.TextChanged += new System.EventHandler(this.txt_chutrinh_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 652);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Chu trình, đường đi Euler tìm được:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quá trình tìm Chu trình Euler";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // gbox_matran
            // 
            this.gbox_matran.Controls.Add(this.label_x);
            this.gbox_matran.Location = new System.Drawing.Point(660, 147);
            this.gbox_matran.Name = "gbox_matran";
            this.gbox_matran.Size = new System.Drawing.Size(450, 450);
            this.gbox_matran.TabIndex = 21;
            this.gbox_matran.TabStop = false;
            this.gbox_matran.Enter += new System.EventHandler(this.gbox_matran_Enter);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(17, 18);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(0, 13);
            this.label_x.TabIndex = 1;
            // 
            // gbox_ngang
            // 
            this.gbox_ngang.Location = new System.Drawing.Point(660, 104);
            this.gbox_ngang.Name = "gbox_ngang";
            this.gbox_ngang.Size = new System.Drawing.Size(450, 37);
            this.gbox_ngang.TabIndex = 22;
            this.gbox_ngang.TabStop = false;
            // 
            // gbox_doc
            // 
            this.gbox_doc.Location = new System.Drawing.Point(623, 147);
            this.gbox_doc.Name = "gbox_doc";
            this.gbox_doc.Size = new System.Drawing.Size(31, 450);
            this.gbox_doc.TabIndex = 23;
            this.gbox_doc.TabStop = false;
            // 
            // btn_themcanh
            // 
            this.btn_themcanh.Location = new System.Drawing.Point(810, 615);
            this.btn_themcanh.Name = "btn_themcanh";
            this.btn_themcanh.Size = new System.Drawing.Size(86, 23);
            this.btn_themcanh.TabIndex = 24;
            this.btn_themcanh.Text = "Thêm cạnh";
            this.btn_themcanh.UseVisualStyleBackColor = true;
            this.btn_themcanh.Click += new System.EventHandler(this.bt_themcanh_Click);
            // 
            // txt_qtr
            // 
            this.txt_qtr.Location = new System.Drawing.Point(26, 65);
            this.txt_qtr.MaxLength = 1000000;
            this.txt_qtr.Multiline = true;
            this.txt_qtr.Name = "txt_qtr";
            this.txt_qtr.Size = new System.Drawing.Size(559, 623);
            this.txt_qtr.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(44, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "(*Click vào nơi bất kỳ trong quá trình và nhấn nút di chuyển xuống để xem hết)";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(510, 36);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1226, 711);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_qtr);
            this.Controls.Add(this.btn_themcanh);
            this.Controls.Add(this.gbox_doc);
            this.Controls.Add(this.gbox_ngang);
            this.Controls.Add(this.gbox_matran);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_chutrinh);
            this.Controls.Add(this.btn_xoacanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_nhapdinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_timchutrinh);
            this.Name = "Form1";
            this.Text = "Ứng dụng tìm Chu trình Euler";
            this.gbox_matran.ResumeLayout(false);
            this.gbox_matran.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_timchutrinh;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nhapdinh;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_xoacanh;
        private System.Windows.Forms.TextBox txt_chutrinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbox_matran;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.GroupBox gbox_ngang;
        private System.Windows.Forms.GroupBox gbox_doc;
        private System.Windows.Forms.Button btn_themcanh;
        private System.Windows.Forms.TextBox txt_qtr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
    }
}

