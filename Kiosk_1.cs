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
    public partial class Kiosk_1 : Form
    {
        public Kiosk_1()
        {
            InitializeComponent();
        }
        /*음료 별 가격 반영*/
        public int totalprice = 0;
        private void radioHotAmeri_CheckedChanged(object sender, EventArgs e)
        {
            int hotame = int.Parse(lb_HotAmeri.Text);
            if (radioHotAmeri.Checked)
            {
                totalprice += hotame;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= hotame;
        }
        private void radioHotCafeLatte_CheckedChanged(object sender, EventArgs e)
        {
            int hotlatte = int.Parse(lb_HotCafeLatte.Text);
            if (radioHotCafeLatte.Checked)
            {
                totalprice += hotlatte;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= hotlatte;
        }
        private void radioHotVanilla_CheckedChanged(object sender, EventArgs e)
        {
            int hotvanilla = int.Parse(lb_HotVanilla.Text);
            if (radioHotVanilla.Checked)
            {
                totalprice += hotvanilla;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= hotvanilla;
        }
        private void radioHotCaramel_CheckedChanged(object sender, EventArgs e)
        {
            int hotcaramel = int.Parse(lb_HotCaramel.Text);
            if (radioHotCaramel.Checked)
            {
                totalprice += hotcaramel;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= hotcaramel;
        }
        private void radioHotCafeMocha_CheckedChanged(object sender, EventArgs e)
        {
            int hotmocha = int.Parse(lb_HotCafeMocha.Text);
            if (radioHotCafeMocha.Checked)
            {
                totalprice += hotmocha;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= hotmocha;
        }
        private void radioHotCondensed_CheckedChanged(object sender, EventArgs e)
        {
            int hotcndensed = int.Parse(lb_HotCondensed.Text);
            if (radioHotCondensed.Checked)
            {
                totalprice += hotcndensed;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= hotcndensed;
        }
        private void radioradioIceAmeri_CheckedChanged(object sender, EventArgs e)
        {
            int iceame = int.Parse(lb_IceAmeri.Text);
            if (radioradioIceAmeri.Checked)
            {
                totalprice += iceame;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= iceame;
        }
        private void radioIceCafeLatte_CheckedChanged(object sender, EventArgs e)
        {
            int icelatte = int.Parse(lb_IceCafeLatte.Text);
            if (radioIceCafeLatte.Checked)
            {
                totalprice += icelatte;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= icelatte;
        }
        private void radioIceVanilla_CheckedChanged(object sender, EventArgs e)
        {
            int icevanilla = int.Parse(lb_IceVanilla.Text);
            if (radioIceVanilla.Checked)
            {
                totalprice += icevanilla;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= icevanilla;
        }
        private void radioIceCaramel_CheckedChanged(object sender, EventArgs e)
        {
            int icecaramel = int.Parse(lb_IceCaramel.Text);
            if (radioIceCaramel.Checked)
            {
                totalprice += icecaramel;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= icecaramel;
        }
        private void radioIceCafeMocha_CheckedChanged(object sender, EventArgs e)
        {
            int icemocha = int.Parse(lb_IceCafeMocha.Text);
            if (radioIceCafeMocha.Checked)
            {
                totalprice += icemocha;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;
            }
            else totalprice -= icemocha;
        }
        private void radioIceCondensed_CheckedChanged(object sender, EventArgs e)
        {
            int icecondensed = int.Parse(lb_IceCondensed.Text);
            if (radioIceCondensed.Checked)
            {
                totalprice += icecondensed;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioLemon.Checked = false;
                radioMojito.Checked = false;
                radioJamong.Checked = false;
                radioAppleTea.Checked = false;
                radioPeach.Checked = false;
                radioEarlGrey.Checked = false;

            }
            else totalprice -= icecondensed;
        }
        private void radioLemon_CheckedChanged(object sender, EventArgs e)
        {
            int lemon = int.Parse(lb_Lemon.Text);
            if (radioLemon.Checked)
            {
                totalprice += lemon;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
            }
            else totalprice -= lemon;
        }
        private void radioMojito_CheckedChanged(object sender, EventArgs e)
        {
            int mojito = int.Parse(lb_Mojito.Text);
            if (radioMojito.Checked)
            {
                totalprice += mojito;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
            }
            else totalprice -= mojito;
        }
        private void radioJamong_CheckedChanged(object sender, EventArgs e)
        {
            int jamong = int.Parse(lb_Jamong.Text);
            if (radioJamong.Checked)
            {
                totalprice += jamong;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
            }
            else totalprice -= jamong;
        }
        private void radioAppleTea_CheckedChanged(object sender, EventArgs e)
        {
            int appletea = int.Parse(lb_AppleTea.Text);
            if (radioAppleTea.Checked)
            {
                totalprice += appletea;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
            }
            else totalprice -= appletea;
        }
        private void radioPeach_CheckedChanged(object sender, EventArgs e)
        {
            int peach = int.Parse(lb_Peach.Text);
            if (radioPeach.Checked)
            {
                totalprice += peach;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
            }
            else totalprice -= peach;
        }
        private void radioEarlGrey_CheckedChanged(object sender, EventArgs e)
        {
            int earlgrey = int.Parse(lb_EarlGrey.Text);
            if (radioEarlGrey.Checked)
            {
                totalprice += earlgrey;
                radioHotAmeri.Checked = false;
                radioHotCafeLatte.Checked = false;
                radioHotVanilla.Checked = false;
                radioHotCaramel.Checked = false;
                radioHotCafeMocha.Checked = false;
                radioHotCondensed.Checked = false;
                radioradioIceAmeri.Checked = false;
                radioIceCafeLatte.Checked = false;
                radioIceVanilla.Checked = false;
                radioIceCaramel.Checked = false;
                radioIceCafeMocha.Checked = false;
                radioIceCondensed.Checked = false;
            }
            else totalprice -= earlgrey;
        }
        private void btn_Order_Click(object sender, EventArgs e)
        {
            // 선택된 음료가 있는지 확인
            if (!IsAnyDrinkSelected())
            {
                MessageBox.Show("음료를 선택하지 않았습니다. 음료를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // 음료를 선택하지 않았으면 더 이상 진행하지 않음
            }

            // Form2 인스턴스 생성
            Kiosk_2 form2 = new Kiosk_2();

            // Form2에 Form1 인스턴스 전달
            form2.kiosk1Instance = this;

            // Form2를 보여줌
            form2.Show();
        }
        public bool IsAnyDrinkSelected()
        {
            // 각 라디오 버튼들의 Checked 상태를 확인하여 선택된 경우 true를 반환
            // 선택되지 않은 경우 false를 반환
            return
                radioHotAmeri.Checked ||
                radioHotCafeLatte.Checked ||
                radioHotVanilla.Checked ||
                radioHotCaramel.Checked ||
                radioHotCafeMocha.Checked ||
                radioHotCondensed.Checked ||
                radioradioIceAmeri.Checked ||
                radioIceCafeLatte.Checked ||
                radioIceVanilla.Checked ||
                radioIceCaramel.Checked ||
                radioIceCafeMocha.Checked ||
                radioIceCondensed.Checked ||
                radioLemon.Checked ||
                radioMojito.Checked ||
                radioJamong.Checked ||
                radioAppleTea.Checked ||
                radioPeach.Checked ||
                radioEarlGrey.Checked;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            radioHotAmeri.Checked = false;
            radioHotCafeLatte.Checked = false;
            radioHotVanilla.Checked = false;
            radioHotCaramel.Checked = false;
            radioHotCafeMocha.Checked = false;
            radioHotCondensed.Checked = false;
            radioradioIceAmeri.Checked = false;
            radioIceCafeLatte.Checked = false;
            radioIceVanilla.Checked = false;
            radioIceCaramel.Checked = false;
            radioIceCafeMocha.Checked = false;
            radioIceCondensed.Checked = false;
            radioLemon.Checked = false;
            radioMojito.Checked = false;
            radioJamong.Checked = false;
            radioAppleTea.Checked = false;
            radioPeach.Checked = false;
            radioEarlGrey.Checked = false;
            tb_OrderList = null;
            tb_TotalPrice = null;
        }
        private void btn_OrderResult_Click(object sender, EventArgs e)
        {
            // 선택된 음료가 있는지 확인
            if (!IsAnyDrinkSelected())
            {
                MessageBox.Show("음료를 선택하지 않았습니다. 음료를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // 음료를 선택하지 않았으면 더 이상 진행하지 않음
            }
            string strOrder = null;
            tb_OrderList.Text = null;

            if (radioHotAmeri.Checked == true)
                strOrder += radioHotAmeri.Text + "\n";
            if (radioHotCafeLatte.Checked == true)
                strOrder += radioHotCafeLatte.Text + "\n";
            if (radioHotVanilla.Checked == true)
                strOrder += radioHotVanilla.Text + "\n";
            if (radioHotCaramel.Checked == true)
                strOrder += radioHotCaramel.Text + "\n";
            if (radioHotCafeMocha.Checked == true)
                strOrder += radioHotCafeMocha.Text + "\n";
            if (radioHotCondensed.Checked == true)
                strOrder += radioHotCondensed.Text + "\n";
            if (radioradioIceAmeri.Checked == true)
                strOrder += radioradioIceAmeri.Text + "\n";
            if (radioIceCafeLatte.Checked == true)
                strOrder += radioIceCafeLatte.Text + "\n";
            if (radioIceVanilla.Checked == true)
                strOrder += radioIceVanilla.Text + "\n";
            if (radioIceCaramel.Checked == true)
                strOrder += radioIceCaramel.Text + "\n";
            if (radioIceCafeMocha.Checked == true)
                strOrder += radioIceCafeMocha.Text + "\n";
            if (radioIceCondensed.Checked == true)
                strOrder += radioIceCondensed.Text + "\n";
            if (radioLemon.Checked == true)
                strOrder += radioLemon.Text + "\n";
            if (radioMojito.Checked == true)
                strOrder += radioMojito.Text + "\n";
            if (radioJamong.Checked == true)
                strOrder += radioJamong.Text + "\n";
            if (radioAppleTea.Checked == true)
                strOrder += radioAppleTea.Text + "\n";
            if (radioPeach.Checked == true)
                strOrder += radioPeach.Text + "\n";
            if (radioEarlGrey.Checked == true)
                strOrder += radioEarlGrey.Text + "\n";

            tb_OrderList.Text = strOrder;
            tb_TotalPrice.Text = totalprice.ToString();
        }
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            // 선택된 음료가 있는지 확인
            if (!IsAnyDrinkSelected())
            {
                MessageBox.Show("음료를 선택하지 않았습니다. 음료를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // 음료를 선택하지 않았으면 더 이상 진행하지 않음
            }

            // Form2 인스턴스 생성
            Kiosk_3 form3 = new Kiosk_3();

            // Form2에 Form1 인스턴스 전달
            form3.kiosk1Instance = this;

            // Form2를 보여줌
            form3.Show();
        }
        private void btn_Complete_Click(object sender, EventArgs e)
        {
            // 선택된 음료가 있는지 확인
            if (!IsAnyDrinkSelected())
            {
                MessageBox.Show("음료를 선택하지 않았습니다. 음료를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // 음료를 선택하지 않았으면 더 이상 진행하지 않음
            }
            // Form2 인스턴스 생성
            Kiosk_4 form4 = new Kiosk_4();

            // Form2에 Form1 인스턴스 전달
            form4.kiosk1Instance = this;

            // Form2를 보여줌
            form4.Show();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}