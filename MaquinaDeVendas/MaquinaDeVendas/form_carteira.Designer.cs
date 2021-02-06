
namespace MaquinaDeVendas
{
    partial class form_carteira
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
            this.txb_moneyIn = new System.Windows.Forms.TextBox();
            this.btn_money = new System.Windows.Forms.Button();
            this.txb_moneyOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_moneyIn
            // 
            this.txb_moneyIn.Location = new System.Drawing.Point(60, 377);
            this.txb_moneyIn.Name = "txb_moneyIn";
            this.txb_moneyIn.Size = new System.Drawing.Size(122, 20);
            this.txb_moneyIn.TabIndex = 0;
            // 
            // btn_money
            // 
            this.btn_money.Location = new System.Drawing.Point(188, 377);
            this.btn_money.Name = "btn_money";
            this.btn_money.Size = new System.Drawing.Size(64, 20);
            this.btn_money.TabIndex = 1;
            this.btn_money.Text = "Adicionar";
            this.btn_money.UseVisualStyleBackColor = true;
            this.btn_money.Click += new System.EventHandler(this.btn_money_Click);
            // 
            // txb_moneyOut
            // 
            this.txb_moneyOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_moneyOut.Location = new System.Drawing.Point(60, 75);
            this.txb_moneyOut.Multiline = true;
            this.txb_moneyOut.Name = "txb_moneyOut";
            this.txb_moneyOut.Size = new System.Drawing.Size(191, 99);
            this.txb_moneyOut.TabIndex = 2;
            this.txb_moneyOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carteira do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor:";
            // 
            // form_carteira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_moneyOut);
            this.Controls.Add(this.btn_money);
            this.Controls.Add(this.txb_moneyIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "form_carteira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_carteira";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_carteira_FormClosed);
            this.Load += new System.EventHandler(this.form_carteira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_moneyIn;
        private System.Windows.Forms.Button btn_money;
        private System.Windows.Forms.TextBox txb_moneyOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}