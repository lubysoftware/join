
namespace MaquinaDeVendas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.form_ini = new System.Windows.Forms.WebBrowser();
            this.menu_ini = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteiraDoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab_money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_bebida = new System.Windows.Forms.ListBox();
            this.bt_comprar = new System.Windows.Forms.Button();
            this.lb_valor = new System.Windows.Forms.ListBox();
            this.lb_qnt = new System.Windows.Forms.ListBox();
            this.lab_totalvendas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menu_ini.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(393, 518);
            this.webBrowser1.TabIndex = 0;
            // 
            // form_ini
            // 
            this.form_ini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_ini.Location = new System.Drawing.Point(0, 24);
            this.form_ini.MinimumSize = new System.Drawing.Size(20, 20);
            this.form_ini.Name = "form_ini";
            this.form_ini.Size = new System.Drawing.Size(393, 518);
            this.form_ini.TabIndex = 1;
            // 
            // menu_ini
            // 
            this.menu_ini.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menu_ini.Location = new System.Drawing.Point(0, 0);
            this.menu_ini.Name = "menu_ini";
            this.menu_ini.Size = new System.Drawing.Size(393, 24);
            this.menu_ini.TabIndex = 2;
            this.menu_ini.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.carteiraDoClienteToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.adicionarToolStripMenuItem.Text = "Estoque de Produtos";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // carteiraDoClienteToolStripMenuItem
            // 
            this.carteiraDoClienteToolStripMenuItem.Name = "carteiraDoClienteToolStripMenuItem";
            this.carteiraDoClienteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.carteiraDoClienteToolStripMenuItem.Text = "Carteira do Cliente";
            this.carteiraDoClienteToolStripMenuItem.DropDownClosed += new System.EventHandler(this.carteiraDoClienteToolStripMenuItem_Click);
            this.carteiraDoClienteToolStripMenuItem.Click += new System.EventHandler(this.carteiraDoClienteToolStripMenuItem_Click);
            // 
            // lab_money
            // 
            this.lab_money.AutoSize = true;
            this.lab_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_money.Location = new System.Drawing.Point(294, 24);
            this.lab_money.Name = "lab_money";
            this.lab_money.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_money.Size = new System.Drawing.Size(58, 17);
            this.lab_money.TabIndex = 3;
            this.lab_money.Text = "R$ 0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de Bebidas:";
            // 
            // lb_bebida
            // 
            this.lb_bebida.FormattingEnabled = true;
            this.lb_bebida.Location = new System.Drawing.Point(14, 88);
            this.lb_bebida.Name = "lb_bebida";
            this.lb_bebida.Size = new System.Drawing.Size(221, 277);
            this.lb_bebida.TabIndex = 6;
            // 
            // bt_comprar
            // 
            this.bt_comprar.Location = new System.Drawing.Point(264, 383);
            this.bt_comprar.Name = "bt_comprar";
            this.bt_comprar.Size = new System.Drawing.Size(85, 35);
            this.bt_comprar.TabIndex = 7;
            this.bt_comprar.Text = "Comprar";
            this.bt_comprar.UseVisualStyleBackColor = true;
            this.bt_comprar.Click += new System.EventHandler(this.bt_comprar_Click);
            // 
            // lb_valor
            // 
            this.lb_valor.FormattingEnabled = true;
            this.lb_valor.Location = new System.Drawing.Point(260, 88);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(58, 277);
            this.lb_valor.TabIndex = 8;
            // 
            // lb_qnt
            // 
            this.lb_qnt.FormattingEnabled = true;
            this.lb_qnt.Location = new System.Drawing.Point(336, 88);
            this.lb_qnt.Name = "lb_qnt";
            this.lb_qnt.Size = new System.Drawing.Size(29, 277);
            this.lb_qnt.TabIndex = 9;
            // 
            // lab_totalvendas
            // 
            this.lab_totalvendas.AutoSize = true;
            this.lab_totalvendas.Location = new System.Drawing.Point(66, 394);
            this.lab_totalvendas.Name = "lab_totalvendas";
            this.lab_totalvendas.Size = new System.Drawing.Size(13, 13);
            this.lab_totalvendas.TabIndex = 10;
            this.lab_totalvendas.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vendas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Carteira :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_totalvendas);
            this.Controls.Add(this.lb_qnt);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.bt_comprar);
            this.Controls.Add(this.lb_bebida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_money);
            this.Controls.Add(this.form_ini);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menu_ini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu_ini;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menu_ini.ResumeLayout(false);
            this.menu_ini.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser form_ini;
        private System.Windows.Forms.MenuStrip menu_ini;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteiraDoClienteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lab_money;
        private System.Windows.Forms.Button bt_comprar;
        private System.Windows.Forms.Label lab_totalvendas;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox lb_bebida;
        public System.Windows.Forms.ListBox lb_valor;
        public System.Windows.Forms.ListBox lb_qnt;
        private System.Windows.Forms.Label label3;
    }
}

