using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_Kiosk
{
    public partial class Kiosk_4 : Form
    {
        public Kiosk_1 kiosk1Instance { get; set; }
        public Kiosk_4()
        {
            InitializeComponent();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (radioPrint.Checked == false && radioNotPrint.Checked == false)
            {
                MessageBox.Show("영수증 출력여부를 체크해주세요.");
                return;
            }
            else if (radioPrint.Checked == true)
                MessageBox.Show("영수증을 출력합니다");
            else MessageBox.Show("영수증을 출력하지 않습니다.");
            Close();
        }
    }
}
