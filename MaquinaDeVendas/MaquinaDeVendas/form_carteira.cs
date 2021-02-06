using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeVendas
{
    public partial class form_carteira : Form
    {
        Form1 fp;
        public form_carteira(Form1 f)
        {
            InitializeComponent();
            fp = f;
            txb_moneyOut.Text = String.Format("{0:c}", f.money);
        }

        private void form_carteira_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_money_Click(object sender, EventArgs e)
        {
        float aux = 0;
            if (txb_moneyIn.Text.ToArray().Length != 0)
            {
                aux += (float.Parse(txb_moneyIn.Text.Replace(" ", null).Replace("$", null).Replace("R", null).Replace(".", null)));
            }
            if (txb_moneyOut.Text.ToArray().Length != 0)
            {
                aux += (float.Parse(txb_moneyOut.Text.Replace(" ", null).Replace("$", null).Replace("R", null).Replace(".", null)));
            }
            txb_moneyOut.Text = String.Format("{0:c}", aux);
            txb_moneyIn.Clear();
            fp.money = aux;
        }

        private void form_carteira_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.lab_money.Text =  String.Format("{0:c}", fp.money);
        }
    }
}
