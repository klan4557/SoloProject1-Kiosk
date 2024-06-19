namespace _00_Kiosk
{
    partial class Kiosk_2
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            lb_Honey = new System.Windows.Forms.Label();
            lb_Syrup = new System.Windows.Forms.Label();
            lb_2Shot = new System.Windows.Forms.Label();
            lb_Shot = new System.Windows.Forms.Label();
            ckb_Honey = new System.Windows.Forms.CheckBox();
            ckb_Syrup = new System.Windows.Forms.CheckBox();
            ckb_2Shot = new System.Windows.Forms.CheckBox();
            ckb_Shot = new System.Windows.Forms.CheckBox();
            btn_Choice = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(lb_Honey);
            groupBox1.Controls.Add(lb_Syrup);
            groupBox1.Controls.Add(lb_2Shot);
            groupBox1.Controls.Add(lb_Shot);
            groupBox1.Controls.Add(ckb_Honey);
            groupBox1.Controls.Add(ckb_Syrup);
            groupBox1.Controls.Add(ckb_2Shot);
            groupBox1.Controls.Add(ckb_Shot);
            groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(78, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(212, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "추가선택사항";
            // 
            // lb_Honey
            // 
            lb_Honey.AutoSize = true;
            lb_Honey.Location = new System.Drawing.Point(127, 206);
            lb_Honey.Name = "lb_Honey";
            lb_Honey.Size = new System.Drawing.Size(32, 17);
            lb_Honey.TabIndex = 1;
            lb_Honey.Text = "700";
            // 
            // lb_Syrup
            // 
            lb_Syrup.AutoSize = true;
            lb_Syrup.Location = new System.Drawing.Point(127, 158);
            lb_Syrup.Name = "lb_Syrup";
            lb_Syrup.Size = new System.Drawing.Size(32, 17);
            lb_Syrup.TabIndex = 1;
            lb_Syrup.Text = "500";
            // 
            // lb_2Shot
            // 
            lb_2Shot.AutoSize = true;
            lb_2Shot.Location = new System.Drawing.Point(127, 103);
            lb_2Shot.Name = "lb_2Shot";
            lb_2Shot.Size = new System.Drawing.Size(40, 17);
            lb_2Shot.TabIndex = 1;
            lb_2Shot.Text = "1000";
            // 
            // lb_Shot
            // 
            lb_Shot.AutoSize = true;
            lb_Shot.Location = new System.Drawing.Point(127, 52);
            lb_Shot.Name = "lb_Shot";
            lb_Shot.Size = new System.Drawing.Size(32, 17);
            lb_Shot.TabIndex = 1;
            lb_Shot.Text = "500";
            // 
            // ckb_Honey
            // 
            ckb_Honey.AutoSize = true;
            ckb_Honey.Location = new System.Drawing.Point(18, 205);
            ckb_Honey.Name = "ckb_Honey";
            ckb_Honey.Size = new System.Drawing.Size(71, 21);
            ckb_Honey.TabIndex = 0;
            ckb_Honey.Text = " 꿀추가";
            ckb_Honey.UseVisualStyleBackColor = true;
            ckb_Honey.CheckedChanged += ckb_Honey_CheckedChanged;
            // 
            // ckb_Syrup
            // 
            ckb_Syrup.AutoSize = true;
            ckb_Syrup.Location = new System.Drawing.Point(18, 158);
            ckb_Syrup.Name = "ckb_Syrup";
            ckb_Syrup.Size = new System.Drawing.Size(89, 21);
            ckb_Syrup.TabIndex = 0;
            ckb_Syrup.Text = " 시럽 추가";
            ckb_Syrup.UseVisualStyleBackColor = true;
            ckb_Syrup.CheckedChanged += ckb_Syrup_CheckedChanged;
            // 
            // ckb_2Shot
            // 
            ckb_2Shot.AutoSize = true;
            ckb_2Shot.Location = new System.Drawing.Point(18, 103);
            ckb_2Shot.Name = "ckb_2Shot";
            ckb_2Shot.Size = new System.Drawing.Size(84, 21);
            ckb_2Shot.TabIndex = 0;
            ckb_2Shot.Text = " 2샷 추가";
            ckb_2Shot.UseVisualStyleBackColor = true;
            ckb_2Shot.CheckedChanged += ckb_2Shot_CheckedChanged;
            // 
            // ckb_Shot
            // 
            ckb_Shot.AutoSize = true;
            ckb_Shot.Location = new System.Drawing.Point(18, 52);
            ckb_Shot.Name = "ckb_Shot";
            ckb_Shot.Size = new System.Drawing.Size(71, 21);
            ckb_Shot.TabIndex = 0;
            ckb_Shot.Text = " 샷추가";
            ckb_Shot.UseVisualStyleBackColor = true;
            ckb_Shot.CheckedChanged += ckb_Shot_CheckedChanged;
            // 
            // btn_Choice
            // 
            btn_Choice.BackColor = System.Drawing.Color.White;
            btn_Choice.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Choice.Location = new System.Drawing.Point(136, 385);
            btn_Choice.Name = "btn_Choice";
            btn_Choice.Size = new System.Drawing.Size(101, 44);
            btn_Choice.TabIndex = 1;
            btn_Choice.Text = "선택완료";
            btn_Choice.UseVisualStyleBackColor = false;
            btn_Choice.Click += btn_Choice_Click;
            // 
            // Kiosk_2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(374, 475);
            Controls.Add(btn_Choice);
            Controls.Add(groupBox1);
            Name = "Kiosk_2";
            Text = "Kiosk_2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Honey;
        private System.Windows.Forms.Label lb_Syrup;
        private System.Windows.Forms.Label lb_2Shot;
        private System.Windows.Forms.Label lb_Shot;
        private System.Windows.Forms.Button btn_Choice;
        public System.Windows.Forms.CheckBox ckb_Honey;
        public System.Windows.Forms.CheckBox ckb_Syrup;
        public System.Windows.Forms.CheckBox ckb_2Shot;
        public System.Windows.Forms.CheckBox ckb_Shot;
    }
}