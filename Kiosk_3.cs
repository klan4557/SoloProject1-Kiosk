using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_Kiosk
{
    public partial class Kiosk_3 : Form
    {

        public Kiosk_1 kiosk1Instance { get; set; }
        public Kiosk_3()
        {
            InitializeComponent();
        }
        private void btn_Card_Click(object sender, EventArgs e)
        {
            if (!IsAnyStampSelected())
            {
                MessageBox.Show("스탬프 적립여부를 선택하지 않았습니다. 여부를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("카드결제로 결제 진행합니다.");
            Close();
        }
        private void btn_Kakao_Click(object sender, EventArgs e)
        {
            if (!IsAnyStampSelected())
            {
                MessageBox.Show("스탬프 적립여부를 선택하지 않았습니다. 여부를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("카카오페이로 결제 진행합니다.");
            Close();
        }
        private void btn_Payco_Click(object sender, EventArgs e)
        {
            if (!IsAnyStampSelected())
            {
                MessageBox.Show("스탬프 적립여부를 선택하지 않았습니다. 여부를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("페이코로 결제 진행합니다.");
            Close();
        }
        private void btn_Naver_Click(object sender, EventArgs e)
        {
            if (!IsAnyStampSelected())
            {
                MessageBox.Show("스탬프 적립여부를 선택하지 않았습니다. 여부를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("네이버페이로 결제 진행합니다.");
            Close();
        }
        private void btn_Stamp_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked == true)
                MessageBox.Show("스탬프를 한개 적립합니다.");
            else if(radioDisAgree.Checked == true)
                MessageBox.Show("적립하지 않습니다.");
            else MessageBox.Show("적립 여부를 선택해주세요.");
        }
        private void bnt_Coupon_Click(object sender, EventArgs e)
        {
            if (!IsAnyStampSelected())
            {
                MessageBox.Show("스탬프 적립여부를 선택하지 않았습니다. 여부를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            MessageBox.Show("쿠폰을 사용합니다.");
            Close();
        }
        public bool IsAnyStampSelected()
        {
            // 스탬프 적립 여부를 판단해서 아무것도 입력하지 않았으면 입력 문구 출력
            return
                radioAgree.Checked ||
                radioDisAgree.Checked ;
                
        }
    }
}
