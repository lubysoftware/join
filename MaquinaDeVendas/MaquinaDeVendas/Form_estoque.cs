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
    public partial class Form_estoque : Form
    {
        Form1 fm;

        public Form_estoque(Form1 fm)
        {
            InitializeComponent();
            this.fm = fm;
            lb_valor.DataSource = fm.Bebidas_preço;
            lb_qnt.DataSource = fm.Bebidas_quantidade;
            lb_bebida.DataSource = fm.Bebidas;
        }

        private void bt_adicionarB_Click(object sender, EventArgs e)
        {
            if(tb_bebida.Text == "" | tb_qnt.Text == ""| tb_preco.Text == "")
            {
                MessageBox.Show("Dados faltando para adicionar");
                return;
            }

            if(int.Parse(tb_qnt.Text) <= 0)
            {
                MessageBox.Show("Impossivel dever produtos para o sistema!!");
                return;
            }

            fm.Bebidas.Add( tb_bebida.Text );
            fm.Bebidas_preço.Add(float.Parse(tb_preco.Text));
            fm.Bebidas_quantidade.Add(int.Parse(tb_qnt.Text));
            tb_bebida.Clear();
            tb_preco.Clear();
            tb_qnt.Clear();
            lb_bebida.DataSource = null;
            lb_bebida.DataSource = fm.Bebidas;
            lb_valor.DataSource = null;
            lb_valor.DataSource = fm.Bebidas_preço;
            lb_qnt.DataSource = null;
            lb_qnt.DataSource = fm.Bebidas_quantidade;
        }

        private void bt_removerB_Click(object sender, EventArgs e)
        {
            int i;
            if (lb_bebida.SelectedIndex == -1 & lb_qnt.SelectedIndex == -1 & lb_valor.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum elemento encontrado para remover");
                return;
            } else if (lb_bebida.SelectedIndex != -1 | lb_qnt.SelectedIndex != -1){
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

            fm.Bebidas_preço.RemoveAt(i);
            fm.Bebidas_quantidade.RemoveAt(i);
            fm.Bebidas.RemoveAt(i);

            lb_bebida.DataSource = null;
            lb_bebida.DataSource = fm.Bebidas;
            lb_valor.DataSource = null;
            lb_valor.DataSource = fm.Bebidas_preço;
            lb_qnt.DataSource = null;
            lb_qnt.DataSource = fm.Bebidas_quantidade;

        }

        private void Form_estoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            fm.lb_bebida.DataSource = null;
            fm.lb_bebida.DataSource = fm.Bebidas;
            fm.lb_valor.DataSource = null;
            fm.lb_valor.DataSource = fm.Bebidas_preço;
            fm.lb_qnt.DataSource = null;
            fm.lb_qnt.DataSource = fm.Bebidas_quantidade;
        }

        private void bt_reabstecer_Click(object sender, EventArgs e)
        {
            int i;
            if (lb_bebida.SelectedIndex == -1 & lb_qnt.SelectedIndex == -1 & lb_valor.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum elemento encontrado para reabastecer");
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

            if(tb_qnt.Text == "")
            {
                MessageBox.Show("Digite no espaço de quantidade o novo estoque!!!");
                return;
            }

            if(int.Parse(tb_qnt.Text) <= 0)
            {
                MessageBox.Show("Impossivel dever produtos para o sistema!!");
                return;
            }

            int[] aux = fm.Bebidas_quantidade.ToArray();
            aux[i] = int.Parse(tb_qnt.Text);
            fm.Bebidas_quantidade = aux.ToList();

            tb_qnt.Clear();

            lb_bebida.DataSource = null;
            lb_bebida.DataSource = fm.Bebidas;
            lb_valor.DataSource = null;
            lb_valor.DataSource = fm.Bebidas_preço;
            lb_qnt.DataSource = null;
            lb_qnt.DataSource = fm.Bebidas_quantidade;

        }
    }
}
