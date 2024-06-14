namespace Do_An_Paint
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
            this.plMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VeDaGiac = new System.Windows.Forms.CheckBox();
            this.btnBrush = new System.Windows.Forms.Button();
            this.mauhinh = new System.Windows.Forms.PictureBox();
            this.maunetve = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daGiaccoChu = new System.Windows.Forms.Button();
            this.cTron = new System.Windows.Forms.Button();
            this.hTroncoChu = new System.Windows.Forms.Button();
            this.hTron = new System.Windows.Forms.Button();
            this.HCNMau = new System.Windows.Forms.Button();
            this.hElipMau = new System.Windows.Forms.Button();
            this.hElip = new System.Windows.Forms.Button();
            this.HCN = new System.Windows.Forms.Button();
            this.duongThang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.doday = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mauhinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maunetve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doday)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.White;
            this.plMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plMain.Location = new System.Drawing.Point(157, 3);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1224, 740);
            this.plMain.TabIndex = 0;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.VeDaGiac);
            this.panel2.Controls.Add(this.btnBrush);
            this.panel2.Controls.Add(this.mauhinh);
            this.panel2.Controls.Add(this.maunetve);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.daGiaccoChu);
            this.panel2.Controls.Add(this.cTron);
            this.panel2.Controls.Add(this.hTroncoChu);
            this.panel2.Controls.Add(this.hTron);
            this.panel2.Controls.Add(this.HCNMau);
            this.panel2.Controls.Add(this.hElipMau);
            this.panel2.Controls.Add(this.hElip);
            this.panel2.Controls.Add(this.HCN);
            this.panel2.Controls.Add(this.duongThang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.doday);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 494);
            this.panel2.TabIndex = 1;
            // 
            // VeDaGiac
            // 
            this.VeDaGiac.AutoSize = true;
            this.VeDaGiac.Location = new System.Drawing.Point(6, 360);
            this.VeDaGiac.Name = "VeDaGiac";
            this.VeDaGiac.Size = new System.Drawing.Size(78, 17);
            this.VeDaGiac.TabIndex = 24;
            this.VeDaGiac.Text = "Vẽ đa giác";
            this.VeDaGiac.UseVisualStyleBackColor = true;
            // 
            // btnBrush
            // 
            this.btnBrush.Location = new System.Drawing.Point(3, 331);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(75, 23);
            this.btnBrush.TabIndex = 23;
            this.btnBrush.Text = "Brush";
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // mauhinh
            // 
            this.mauhinh.Location = new System.Drawing.Point(100, 343);
            this.mauhinh.Name = "mauhinh";
            this.mauhinh.Size = new System.Drawing.Size(51, 45);
            this.mauhinh.TabIndex = 22;
            this.mauhinh.TabStop = false;
            this.mauhinh.Click += new System.EventHandler(this.mauhinh_Click);
            // 
            // maunetve
            // 
            this.maunetve.Location = new System.Drawing.Point(6, 226);
            this.maunetve.Name = "maunetve";
            this.maunetve.Size = new System.Drawing.Size(51, 45);
            this.maunetve.TabIndex = 21;
            this.maunetve.TabStop = false;
            this.maunetve.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Màu hinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Màu nét vẽ:";
            // 
            // daGiaccoChu
            // 
            this.daGiaccoChu.Location = new System.Drawing.Point(3, 152);
            this.daGiaccoChu.Name = "daGiaccoChu";
            this.daGiaccoChu.Size = new System.Drawing.Size(148, 23);
            this.daGiaccoChu.TabIndex = 15;
            this.daGiaccoChu.Text = "Đa giác có chữ";
            this.daGiaccoChu.UseVisualStyleBackColor = true;
            // 
            // cTron
            // 
            this.cTron.Location = new System.Drawing.Point(3, 123);
            this.cTron.Name = "cTron";
            this.cTron.Size = new System.Drawing.Size(148, 23);
            this.cTron.TabIndex = 13;
            this.cTron.Text = "Cung tròn";
            this.cTron.UseVisualStyleBackColor = true;
            this.cTron.Click += new System.EventHandler(this.cTron_Click);
            // 
            // hTroncoChu
            // 
            this.hTroncoChu.Location = new System.Drawing.Point(3, 181);
            this.hTroncoChu.Name = "hTroncoChu";
            this.hTroncoChu.Size = new System.Drawing.Size(148, 23);
            this.hTroncoChu.TabIndex = 12;
            this.hTroncoChu.Text = "Hình tròn có chữ";
            this.hTroncoChu.UseVisualStyleBackColor = true;
            this.hTroncoChu.Click += new System.EventHandler(this.hTroncoChu_Click);
            // 
            // hTron
            // 
            this.hTron.Location = new System.Drawing.Point(3, 94);
            this.hTron.Name = "hTron";
            this.hTron.Size = new System.Drawing.Size(148, 23);
            this.hTron.TabIndex = 11;
            this.hTron.Text = "Hình tròn";
            this.hTron.UseVisualStyleBackColor = true;
            this.hTron.Click += new System.EventHandler(this.hTron_Click);
            // 
            // HCNMau
            // 
            this.HCNMau.Location = new System.Drawing.Point(3, 302);
            this.HCNMau.Name = "HCNMau";
            this.HCNMau.Size = new System.Drawing.Size(148, 23);
            this.HCNMau.TabIndex = 10;
            this.HCNMau.Text = "Hình chữ nhật có màu";
            this.HCNMau.UseVisualStyleBackColor = true;
            this.HCNMau.Click += new System.EventHandler(this.HCNMau_Click);
            // 
            // hElipMau
            // 
            this.hElipMau.Location = new System.Drawing.Point(3, 275);
            this.hElipMau.Name = "hElipMau";
            this.hElipMau.Size = new System.Drawing.Size(148, 23);
            this.hElipMau.TabIndex = 9;
            this.hElipMau.Text = "Hình elip có màu";
            this.hElipMau.UseVisualStyleBackColor = true;
            this.hElipMau.Click += new System.EventHandler(this.hElipMau_Click);
            // 
            // hElip
            // 
            this.hElip.Location = new System.Drawing.Point(3, 65);
            this.hElip.Name = "hElip";
            this.hElip.Size = new System.Drawing.Size(148, 23);
            this.hElip.TabIndex = 8;
            this.hElip.Text = "Hình elip";
            this.hElip.UseVisualStyleBackColor = true;
            this.hElip.Click += new System.EventHandler(this.hElip_Click);
            // 
            // HCN
            // 
            this.HCN.Location = new System.Drawing.Point(3, 36);
            this.HCN.Name = "HCN";
            this.HCN.Size = new System.Drawing.Size(148, 23);
            this.HCN.TabIndex = 7;
            this.HCN.Text = "Hình chữ nhật";
            this.HCN.UseVisualStyleBackColor = true;
            this.HCN.Click += new System.EventHandler(this.HCN_Click);
            // 
            // duongThang
            // 
            this.duongThang.Location = new System.Drawing.Point(3, 7);
            this.duongThang.Name = "duongThang";
            this.duongThang.Size = new System.Drawing.Size(148, 23);
            this.duongThang.TabIndex = 6;
            this.duongThang.Text = "Đường thẳng";
            this.duongThang.UseVisualStyleBackColor = true;
            this.duongThang.Click += new System.EventHandler(this.duongThang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Độ dày nét vẽ;";
            // 
            // doday
            // 
            this.doday.Location = new System.Drawing.Point(77, 226);
            this.doday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.doday.Name = "doday";
            this.doday.Size = new System.Drawing.Size(74, 20);
            this.doday.TabIndex = 4;
            this.doday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mauhinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maunetve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown doday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hElip;
        private System.Windows.Forms.Button HCN;
        private System.Windows.Forms.Button duongThang;
        private System.Windows.Forms.Button hTroncoChu;
        private System.Windows.Forms.Button hTron;
        private System.Windows.Forms.Button HCNMau;
        private System.Windows.Forms.Button hElipMau;
        private System.Windows.Forms.Button daGiaccoChu;
        private System.Windows.Forms.Button cTron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox maunetve;
        private System.Windows.Forms.PictureBox mauhinh;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.CheckBox VeDaGiac;
    }
}

