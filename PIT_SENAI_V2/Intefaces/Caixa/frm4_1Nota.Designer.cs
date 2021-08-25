
namespace PIT_SENAI_V2.Dados
{
    partial class frm4_1Nota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4_1Nota));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpIdOrdem = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTipoDeMovimento = new System.Windows.Forms.ComboBox();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbFormaDePagamento = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.tlpDescricao = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.btnEmitirNota = new System.Windows.Forms.Button();
            this.lblIdOrdem = new System.Windows.Forms.Label();
            this.tlp1.SuspendLayout();
            this.tlpIdOrdem.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.tlpDescricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.tlpIdOrdem, 0, 1);
            this.tlp1.Controls.Add(this.cmbTipoDeMovimento, 0, 0);
            this.tlp1.Controls.Add(this.tlp2, 0, 3);
            this.tlp1.Controls.Add(this.tlpDescricao, 0, 2);
            this.tlp1.Controls.Add(this.btnEmitirNota, 0, 4);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 5;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.Size = new System.Drawing.Size(709, 200);
            this.tlp1.TabIndex = 0;
            // 
            // tlpIdOrdem
            // 
            this.tlpIdOrdem.ColumnCount = 3;
            this.tlpIdOrdem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpIdOrdem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIdOrdem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpIdOrdem.Controls.Add(this.textBox1, 1, 0);
            this.tlpIdOrdem.Controls.Add(this.button1, 2, 0);
            this.tlpIdOrdem.Controls.Add(this.lblIdOrdem, 0, 0);
            this.tlpIdOrdem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIdOrdem.Location = new System.Drawing.Point(0, 40);
            this.tlpIdOrdem.Margin = new System.Windows.Forms.Padding(0);
            this.tlpIdOrdem.Name = "tlpIdOrdem";
            this.tlpIdOrdem.RowCount = 1;
            this.tlpIdOrdem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIdOrdem.Size = new System.Drawing.Size(709, 40);
            this.tlpIdOrdem.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(141, 1);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 38);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PIT_SENAI_V2.Properties.Resources.Search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(669, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbTipoDeMovimento
            // 
            this.cmbTipoDeMovimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTipoDeMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeMovimento.FormattingEnabled = true;
            this.cmbTipoDeMovimento.Items.AddRange(new object[] {
            "Tipo de Movimento"});
            this.cmbTipoDeMovimento.Location = new System.Drawing.Point(1, 1);
            this.cmbTipoDeMovimento.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTipoDeMovimento.Name = "cmbTipoDeMovimento";
            this.cmbTipoDeMovimento.Size = new System.Drawing.Size(707, 39);
            this.cmbTipoDeMovimento.TabIndex = 4;
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Controls.Add(this.cmbFormaDePagamento, 0, 0);
            this.tlp2.Controls.Add(this.lblValor, 1, 0);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(0, 120);
            this.tlp2.Margin = new System.Windows.Forms.Padding(0);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Size = new System.Drawing.Size(709, 40);
            this.tlp2.TabIndex = 7;
            // 
            // cmbFormaDePagamento
            // 
            this.cmbFormaDePagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFormaDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaDePagamento.FormattingEnabled = true;
            this.cmbFormaDePagamento.Items.AddRange(new object[] {
            "Tipo de Pagamento",
            "Dinheiro",
            "Crédito",
            "Débito",
            "Parcelado",
            "A Prazo"});
            this.cmbFormaDePagamento.Location = new System.Drawing.Point(1, 1);
            this.cmbFormaDePagamento.Margin = new System.Windows.Forms.Padding(1);
            this.cmbFormaDePagamento.Name = "cmbFormaDePagamento";
            this.cmbFormaDePagamento.Size = new System.Drawing.Size(352, 39);
            this.cmbFormaDePagamento.TabIndex = 5;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(357, 5);
            this.lblValor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(79, 30);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // tlpDescricao
            // 
            this.tlpDescricao.ColumnCount = 2;
            this.tlpDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDescricao.Controls.Add(this.txbDescricao, 1, 0);
            this.tlpDescricao.Controls.Add(this.lblDescricao, 0, 0);
            this.tlpDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDescricao.Location = new System.Drawing.Point(0, 80);
            this.tlpDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDescricao.Name = "tlpDescricao";
            this.tlpDescricao.RowCount = 1;
            this.tlpDescricao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDescricao.Size = new System.Drawing.Size(709, 40);
            this.tlpDescricao.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(3, 5);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(130, 30);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescricao.Location = new System.Drawing.Point(141, 1);
            this.txbDescricao.Margin = new System.Windows.Forms.Padding(1);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(567, 38);
            this.txbDescricao.TabIndex = 7;
            // 
            // btnEmitirNota
            // 
            this.btnEmitirNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmitirNota.Location = new System.Drawing.Point(0, 160);
            this.btnEmitirNota.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmitirNota.Name = "btnEmitirNota";
            this.btnEmitirNota.Size = new System.Drawing.Size(709, 40);
            this.btnEmitirNota.TabIndex = 9;
            this.btnEmitirNota.Text = "Emitir Nota";
            this.btnEmitirNota.UseVisualStyleBackColor = true;
            // 
            // lblIdOrdem
            // 
            this.lblIdOrdem.AutoSize = true;
            this.lblIdOrdem.Location = new System.Drawing.Point(3, 5);
            this.lblIdOrdem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblIdOrdem.Name = "lblIdOrdem";
            this.lblIdOrdem.Size = new System.Drawing.Size(132, 30);
            this.lblIdOrdem.TabIndex = 2;
            this.lblIdOrdem.Text = "ID Ordem:";
            // 
            // frm4_1Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 200);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm4_1Nota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota";
            this.tlp1.ResumeLayout(false);
            this.tlpIdOrdem.ResumeLayout(false);
            this.tlpIdOrdem.PerformLayout();
            this.tlp2.ResumeLayout(false);
            this.tlp2.PerformLayout();
            this.tlpDescricao.ResumeLayout(false);
            this.tlpDescricao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TableLayoutPanel tlpIdOrdem;
        private System.Windows.Forms.ComboBox cmbTipoDeMovimento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.ComboBox cmbFormaDePagamento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TableLayoutPanel tlpDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Button btnEmitirNota;
        private System.Windows.Forms.Label lblIdOrdem;
    }
}