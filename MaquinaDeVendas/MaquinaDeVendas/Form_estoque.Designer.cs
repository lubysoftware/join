
namespace MaquinaDeVendas
{
    partial class Form_estoque
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
            this.lb_bebida = new System.Windows.Forms.ListBox();
            this.bt_adicionarB = new System.Windows.Forms.Button();
            this.bt_removerB = new System.Windows.Forms.Button();
            this.tb_bebida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.ListBox();
            this.lb_qnt = new System.Windows.Forms.ListBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.tb_qnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_reabstecer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_bebida
            // 
            this.lb_bebida.FormattingEnabled = true;
            this.lb_bebida.Location = new System.Drawing.Point(12, 23);
            this.lb_bebida.Name = "lb_bebida";
            this.lb_bebida.Size = new System.Drawing.Size(172, 264);
            this.lb_bebida.TabIndex = 0;
            // 
            // bt_adicionarB
            // 
            this.bt_adicionarB.Location = new System.Drawing.Point(12, 357);
            this.bt_adicionarB.Name = "bt_adicionarB";
            this.bt_adicionarB.Size = new System.Drawing.Size(91, 23);
            this.bt_adicionarB.TabIndex = 1;
            this.bt_adicionarB.Text = "Adicionar";
            this.bt_adicionarB.UseVisualStyleBackColor = true;
            this.bt_adicionarB.Click += new System.EventHandler(this.bt_adicionarB_Click);
            // 
            // bt_removerB
            // 
            this.bt_removerB.Location = new System.Drawing.Point(12, 386);
            this.bt_removerB.Name = "bt_removerB";
            this.bt_removerB.Size = new System.Drawing.Size(91, 23);
            this.bt_removerB.TabIndex = 2;
            this.bt_removerB.Text = "Remover";
            this.bt_removerB.UseVisualStyleBackColor = true;
            this.bt_removerB.Click += new System.EventHandler(this.bt_removerB_Click);
            // 
            // tb_bebida
            // 
            this.tb_bebida.Location = new System.Drawing.Point(109, 315);
            this.tb_bebida.Name = "tb_bebida";
            this.tb_bebida.Size = new System.Drawing.Size(172, 20);
            this.tb_bebida.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bebida : ";
            // 
            // lb_valor
            // 
            this.lb_valor.FormattingEnabled = true;
            this.lb_valor.Location = new System.Drawing.Point(190, 23);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(59, 264);
            this.lb_valor.TabIndex = 6;
            // 
            // lb_qnt
            // 
            this.lb_qnt.FormattingEnabled = true;
            this.lb_qnt.Location = new System.Drawing.Point(255, 23);
            this.lb_qnt.Name = "lb_qnt";
            this.lb_qnt.Size = new System.Drawing.Size(26, 264);
            this.lb_qnt.TabIndex = 7;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(181, 341);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(100, 20);
            this.tb_preco.TabIndex = 8;
            // 
            // tb_qnt
            // 
            this.tb_qnt.Location = new System.Drawing.Point(181, 367);
            this.tb_qnt.Name = "tb_qnt";
            this.tb_qnt.Size = new System.Drawing.Size(100, 20);
            this.tb_qnt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantos";
            // 
            // bt_reabstecer
            // 
            this.bt_reabstecer.Location = new System.Drawing.Point(12, 415);
            this.bt_reabstecer.Name = "bt_reabstecer";
            this.bt_reabstecer.Size = new System.Drawing.Size(91, 23);
            this.bt_reabstecer.TabIndex = 12;
            this.bt_reabstecer.Text = "Reabastecer";
            this.bt_reabstecer.UseVisualStyleBackColor = true;
            this.bt_reabstecer.Click += new System.EventHandler(this.bt_reabstecer_Click);
            // 
            // Form_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.bt_reabstecer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_qnt);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.lb_qnt);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_bebida);
            this.Controls.Add(this.bt_removerB);
            this.Controls.Add(this.bt_adicionarB);
            this.Controls.Add(this.lb_bebida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_estoque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_estoque_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_bebida;
        private System.Windows.Forms.Button bt_adicionarB;
        private System.Windows.Forms.Button bt_removerB;
        private System.Windows.Forms.TextBox tb_bebida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_valor;
        private System.Windows.Forms.ListBox lb_qnt;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.TextBox tb_qnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_reabstecer;
    }
}