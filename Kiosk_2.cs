using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_Kiosk
{
    public partial class Kiosk_2 : Form
    {
        public Kiosk_1 kiosk1Instance { get; set; }
        public Kiosk_2()
        {
            InitializeComponent();
            
        }
        public string strOrder1 = null;
        private void ckb_Shot_CheckedChanged(object sender, EventArgs e)
        {            
            int shot = int.Parse(lb_Shot.Text);
            if (ckb_Shot.Checked)
            {
                kiosk1Instance.totalprice += shot;            
            }
            else kiosk1Instance.totalprice -= shot;
        }
        private void ckb_2Shot_CheckedChanged(object sender, EventArgs e)
        {            
            int shot2 = int.Parse(lb_2Shot.Text);
            if (ckb_2Shot.Checked)
            {
                kiosk1Instance.totalprice += shot2;
            }
            else kiosk1Instance.totalprice -= shot2;
        }
        private void ckb_Syrup_CheckedChanged(object sender, EventArgs e)
        {            
            int syrup = int.Parse(lb_Syrup.Text);
            if (ckb_Syrup.Checked)
            {
                kiosk1Instance.totalprice += syrup;
            }
            else kiosk1Instance.totalprice -= syrup;
        }
        private void ckb_Honey_CheckedChanged(object sender, EventArgs e)
        {            
            int honey = int.Parse(lb_Honey.Text);
            if (ckb_Honey.Checked)
            {
                kiosk1Instance.totalprice += honey;
            }
            else kiosk1Instance.totalprice -= honey;
        }
        private void btn_Choice_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
