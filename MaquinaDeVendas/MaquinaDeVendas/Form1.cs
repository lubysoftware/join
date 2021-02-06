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
    public partial class Form1 : Form
    {
        public int totalvendas = 0;
        public float money = 0;
        public List<string> Bebidas = new List<string>();
        public List<float> Bebidas_preço = new List<float>();
        public List<int> Bebidas_quantidade = new List<int>();


        public void carregar_dados()
        {
            lab_money.Text = String.Format("{0:c}", money);
            lb_bebida.DataSource = null;
            lb_valor.DataSource = null;
            lb_qnt.DataSource = null;
            lb_bebida.DataSource = Bebidas;
            lb_valor.DataSource = Bebidas_preço;
            lb_qnt.DataSource = Bebidas_quantidade;
            lab_totalvendas.Text = Convert.ToString(totalvendas);
        }

        public Form1()
        {
            InitializeComponent();

            carregar_dados();

        }

        private void carteiraDoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_carteira form_Carteira = new form_carteira(this);
            form_Carteira.Show();
            
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_estoque form_estoque = new Form_estoque(this);
            form_estoque.Show();
        }

        private void bt_comprar_Click(object sender, EventArgs e)
        {
            int i;
            if (lb_bebida.SelectedIndex == -1 & lb_qnt.SelectedIndex == -1 & lb_valor.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum elemento encontrado para comprar!!");
                return;
            }
            else if (lb_bebida.SelectedIndex != -1 | lb_qnt.SelectedIndex != -1)
            {
                if (lb_bebida.SelectedIndex == -1)
                {
                    i = lb_qnt.SelectedIndex;
                }
                else i = lb_bebida.SelectedIndex;

            }
            else
            {
                i = lb_valor.SelectedIndex;
            }

            int[] aux = Bebidas_quantidade.ToArray();
            
            if(aux[i] <= 0)
            {
                MessageBox.Show("Não há quantidade necessaria para realizar essa compra!!");
                return;
            }

            if (Bebidas_preço.ElementAt(i) > money)
            {
                MessageBox.Show("Valor insuficiente para a compra!!\n Valor que falta é de : " + (Bebidas_preço.ElementAt(i) - money));

                return;
            }

            aux[i]--;
            Bebidas_quantidade = aux.ToList();
            totalvendas++;
            money -= Bebidas_preço.ElementAt(i);
            MessageBox.Show("Compra realizada com sucesso!!\n O valor restante é de: " + money);
            carregar_dados();
        }
    }
}
