namespace _00_Kiosk
{
    partial class Kiosk_4
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
            btn_Check = new System.Windows.Forms.Button();
            radioNotPrint = new System.Windows.Forms.RadioButton();
            radioPrint = new System.Windows.Forms.RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            groupBox1.Controls.Add(btn_Check);
            groupBox1.Controls.Add(radioNotPrint);
            groupBox1.Controls.Add(radioPrint);
            groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(31, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(313, 189);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "영수증 출력여부를 선택해주세요";
            // 
            // btn_Check
            // 
            btn_Check.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Check.Location = new System.Drawing.Point(115, 131);
            btn_Check.Name = "btn_Check";
            btn_Check.Size = new System.Drawing.Size(88, 39);
            btn_Check.TabIndex = 2;
            btn_Check.Text = "확인";
            btn_Check.UseVisualStyleBackColor = true;
            btn_Check.Click += btn_Check_Click;
            // 
            // radioNotPrint
            // 
            radioNotPrint.AutoSize = true;
            radioNotPrint.BackColor = System.Drawing.Color.White;
            radioNotPrint.ForeColor = System.Drawing.SystemColors.Desktop;
            radioNotPrint.Location = new System.Drawing.Point(197, 66);
            radioNotPrint.Name = "radioNotPrint";
            radioNotPrint.Size = new System.Drawing.Size(76, 25);
            radioNotPrint.TabIndex = 1;
            radioNotPrint.TabStop = true;
            radioNotPrint.Text = "미출력";
            radioNotPrint.UseVisualStyleBackColor = false;
            // 
            // radioPrint
            // 
            radioPrint.AutoSize = true;
            radioPrint.BackColor = System.Drawing.Color.White;
            radioPrint.ForeColor = System.Drawing.SystemColors.InfoText;
            radioPrint.Location = new System.Drawing.Point(55, 66);
            radioPrint.Name = "radioPrint";
            radioPrint.Size = new System.Drawing.Size(60, 25);
            radioPrint.TabIndex = 0;
            radioPrint.TabStop = true;
            radioPrint.Text = "출력";
            radioPrint.UseVisualStyleBackColor = false;
            // 
            // Kiosk_4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(374, 255);
            Controls.Add(groupBox1);
            Name = "Kiosk_4";
            Text = "Kiosk_4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNotPrint;
        private System.Windows.Forms.RadioButton radioPrint;
        private System.Windows.Forms.Button btn_Check;
    }
}