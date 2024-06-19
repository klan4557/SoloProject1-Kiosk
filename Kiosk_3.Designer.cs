namespace _00_Kiosk
{
    partial class Kiosk_3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kiosk_3));
            groupBox1 = new System.Windows.Forms.GroupBox();
            btn_Card = new System.Windows.Forms.Button();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btn_Naver = new System.Windows.Forms.Button();
            btn_Payco = new System.Windows.Forms.Button();
            btn_Kakao = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            imageList1 = new System.Windows.Forms.ImageList(components);
            groupBox3 = new System.Windows.Forms.GroupBox();
            bnt_Coupon = new System.Windows.Forms.Button();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            btn_Stamp = new System.Windows.Forms.Button();
            radioDisAgree = new System.Windows.Forms.RadioButton();
            radioAgree = new System.Windows.Forms.RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Card);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(246, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "카드결제";
            // 
            // btn_Card
            // 
            btn_Card.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Card.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btn_Card.Location = new System.Drawing.Point(32, 106);
            btn_Card.Name = "btn_Card";
            btn_Card.Size = new System.Drawing.Size(183, 35);
            btn_Card.TabIndex = 1;
            btn_Card.Text = "카드결제  삼성페이/LG페이";
            btn_Card.UseVisualStyleBackColor = true;
            btn_Card.Click += btn_Card_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._110;
            pictureBox4.Location = new System.Drawing.Point(64, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(124, 70);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Naver);
            groupBox2.Controls.Add(btn_Payco);
            groupBox2.Controls.Add(btn_Kakao);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(425, 157);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "간편결제";
            // 
            // btn_Naver
            // 
            btn_Naver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btn_Naver.Location = new System.Drawing.Point(307, 117);
            btn_Naver.Name = "btn_Naver";
            btn_Naver.Size = new System.Drawing.Size(103, 34);
            btn_Naver.TabIndex = 3;
            btn_Naver.Text = "네이버페이";
            btn_Naver.UseVisualStyleBackColor = true;
            btn_Naver.Click += btn_Naver_Click;
            // 
            // btn_Payco
            // 
            btn_Payco.ForeColor = System.Drawing.Color.Red;
            btn_Payco.Location = new System.Drawing.Point(160, 117);
            btn_Payco.Name = "btn_Payco";
            btn_Payco.Size = new System.Drawing.Size(103, 34);
            btn_Payco.TabIndex = 2;
            btn_Payco.Text = "페이코";
            btn_Payco.UseVisualStyleBackColor = true;
            btn_Payco.Click += btn_Payco_Click;
            // 
            // btn_Kakao
            // 
            btn_Kakao.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Kakao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btn_Kakao.Location = new System.Drawing.Point(16, 117);
            btn_Kakao.Name = "btn_Kakao";
            btn_Kakao.Size = new System.Drawing.Size(103, 34);
            btn_Kakao.TabIndex = 1;
            btn_Kakao.Text = "카카오페이";
            btn_Kakao.UseVisualStyleBackColor = true;
            btn_Kakao.Click += btn_Kakao_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(295, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(124, 70);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(150, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(124, 70);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._21;
            pictureBox1.Location = new System.Drawing.Point(6, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(124, 70);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bnt_Coupon);
            groupBox3.Controls.Add(pictureBox5);
            groupBox3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.Location = new System.Drawing.Point(12, 343);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(188, 153);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "기타결제";
            // 
            // bnt_Coupon
            // 
            bnt_Coupon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            bnt_Coupon.Location = new System.Drawing.Point(42, 113);
            bnt_Coupon.Name = "bnt_Coupon";
            bnt_Coupon.Size = new System.Drawing.Size(103, 34);
            bnt_Coupon.TabIndex = 1;
            bnt_Coupon.Text = "쿠폰 사용";
            bnt_Coupon.UseVisualStyleBackColor = true;
            bnt_Coupon.Click += bnt_Coupon_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(32, 26);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(124, 70);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_Stamp);
            groupBox4.Controls.Add(radioDisAgree);
            groupBox4.Controls.Add(radioAgree);
            groupBox4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.Location = new System.Drawing.Point(222, 369);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(215, 107);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "스탬프 적립 여부";
            // 
            // btn_Stamp
            // 
            btn_Stamp.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Stamp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btn_Stamp.Location = new System.Drawing.Point(68, 78);
            btn_Stamp.Name = "btn_Stamp";
            btn_Stamp.Size = new System.Drawing.Size(75, 23);
            btn_Stamp.TabIndex = 2;
            btn_Stamp.Text = "확인";
            btn_Stamp.UseVisualStyleBackColor = true;
            btn_Stamp.Click += btn_Stamp_Click;
            // 
            // radioDisAgree
            // 
            radioDisAgree.AutoSize = true;
            radioDisAgree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioDisAgree.Location = new System.Drawing.Point(113, 37);
            radioDisAgree.Name = "radioDisAgree";
            radioDisAgree.Size = new System.Drawing.Size(87, 24);
            radioDisAgree.TabIndex = 1;
            radioDisAgree.TabStop = true;
            radioDisAgree.Text = "적립안함";
            radioDisAgree.UseVisualStyleBackColor = true;
            // 
            // radioAgree
            // 
            radioAgree.AutoSize = true;
            radioAgree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioAgree.Location = new System.Drawing.Point(7, 37);
            radioAgree.Name = "radioAgree";
            radioAgree.Size = new System.Drawing.Size(57, 24);
            radioAgree.TabIndex = 0;
            radioAgree.TabStop = true;
            radioAgree.Text = "적립";
            radioAgree.UseVisualStyleBackColor = true;
            // 
            // Kiosk_3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(468, 531);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Name = "Kiosk_3";
            Text = "Kiosk_3";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Card;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Kakao;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Naver;
        private System.Windows.Forms.Button btn_Payco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bnt_Coupon;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Stamp;
        private System.Windows.Forms.RadioButton radioDisAgree;
        private System.Windows.Forms.RadioButton radioAgree;
    }
}