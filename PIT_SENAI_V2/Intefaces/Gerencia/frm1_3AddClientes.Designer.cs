
namespace PIT_SENAI_V2.Dados
{
    partial class frm1_3AddClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1_3AddClientes));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpContatos = new System.Windows.Forms.GroupBox();
            this.tlpContatos1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoverContato = new System.Windows.Forms.Button();
            this.btnAdicionarContato = new System.Windows.Forms.Button();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.txbTipoContato = new System.Windows.Forms.TextBox();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbDocumento = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAtivo = new System.Windows.Forms.ComboBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.txbBanco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tlp1.SuspendLayout();
            this.grpContatos.SuspendLayout();
            this.tlpContatos1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.grpContatos, 0, 1);
            this.tlp1.Controls.Add(this.btnConfirmar, 0, 2);
            this.tlp1.Controls.Add(this.tlp2, 0, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 3;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.Size = new System.Drawing.Size(574, 607);
            this.tlp1.TabIndex = 0;
            // 
            // grpContatos
            // 
            this.grpContatos.Controls.Add(this.tlpContatos1);
            this.grpContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContatos.Location = new System.Drawing.Point(0, 280);
            this.grpContatos.Margin = new System.Windows.Forms.Padding(0);
            this.grpContatos.Name = "grpContatos";
            this.grpContatos.Size = new System.Drawing.Size(574, 287);
            this.grpContatos.TabIndex = 3;
            this.grpContatos.TabStop = false;
            this.grpContatos.Text = "Contatos:";
            // 
            // tlpContatos1
            // 
            this.tlpContatos1.ColumnCount = 1;
            this.tlpContatos1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContatos1.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpContatos1.Controls.Add(this.dgvContatos, 0, 1);
            this.tlpContatos1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlpContatos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContatos1.Location = new System.Drawing.Point(3, 34);
            this.tlpContatos1.Name = "tlpContatos1";
            this.tlpContatos1.RowCount = 3;
            this.tlpContatos1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpContatos1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContatos1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpContatos1.Size = new System.Drawing.Size(568, 250);
            this.tlpContatos1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRemoverContato, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionarContato, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 210);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRemoverContato
            // 
            this.btnRemoverContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoverContato.Location = new System.Drawing.Point(284, 0);
            this.btnRemoverContato.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoverContato.Name = "btnRemoverContato";
            this.btnRemoverContato.Size = new System.Drawing.Size(284, 40);
            this.btnRemoverContato.TabIndex = 1;
            this.btnRemoverContato.Text = "Remover";
            this.btnRemoverContato.UseVisualStyleBackColor = true;
            this.btnRemoverContato.Click += new System.EventHandler(this.btnRemoverContato_Click);
            // 
            // btnAdicionarContato
            // 
            this.btnAdicionarContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionarContato.Location = new System.Drawing.Point(0, 0);
            this.btnAdicionarContato.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionarContato.Name = "btnAdicionarContato";
            this.btnAdicionarContato.Size = new System.Drawing.Size(284, 40);
            this.btnAdicionarContato.TabIndex = 0;
            this.btnAdicionarContato.Text = "Adicionar";
            this.btnAdicionarContato.UseVisualStyleBackColor = true;
            this.btnAdicionarContato.Click += new System.EventHandler(this.btnAdicionarContato_Click);
            // 
            // dgvContatos
            // 
            this.dgvContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContatos.Location = new System.Drawing.Point(3, 83);
            this.dgvContatos.MultiSelect = false;
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatos.Size = new System.Drawing.Size(562, 124);
            this.dgvContatos.TabIndex = 1;
            this.dgvContatos.SelectionChanged += new System.EventHandler(this.dgvContatos_SelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblTipo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblContato, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txbTipoContato, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbContato, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(568, 80);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(3, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(70, 31);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(3, 40);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(112, 31);
            this.lblContato.TabIndex = 1;
            this.lblContato.Text = "Contato:";
            // 
            // txbTipoContato
            // 
            this.txbTipoContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbTipoContato.Location = new System.Drawing.Point(121, 1);
            this.txbTipoContato.Margin = new System.Windows.Forms.Padding(1);
            this.txbTipoContato.Name = "txbTipoContato";
            this.txbTipoContato.Size = new System.Drawing.Size(446, 38);
            this.txbTipoContato.TabIndex = 10;
            // 
            // txbContato
            // 
            this.txbContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbContato.Location = new System.Drawing.Point(121, 41);
            this.txbContato.Margin = new System.Windows.Forms.Padding(1);
            this.txbContato.Name = "txbContato";
            this.txbContato.Size = new System.Drawing.Size(446, 38);
            this.txbContato.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmar.Location = new System.Drawing.Point(0, 567);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(574, 40);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.13937F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.86063F));
            this.tlp2.Controls.Add(this.cmbVendedor, 1, 4);
            this.tlp2.Controls.Add(this.txbCep, 1, 3);
            this.tlp2.Controls.Add(this.txbEndereco, 1, 2);
            this.tlp2.Controls.Add(this.txbDocumento, 1, 1);
            this.tlp2.Controls.Add(this.txbNome, 1, 0);
            this.tlp2.Controls.Add(this.label1, 0, 0);
            this.tlp2.Controls.Add(this.cmbAtivo, 1, 6);
            this.tlp2.Controls.Add(this.lblAtivo, 0, 6);
            this.tlp2.Controls.Add(this.txbBanco, 1, 5);
            this.tlp2.Controls.Add(this.label9, 0, 5);
            this.tlp2.Controls.Add(this.label2, 0, 1);
            this.tlp2.Controls.Add(this.label3, 0, 2);
            this.tlp2.Controls.Add(this.label4, 0, 3);
            this.tlp2.Controls.Add(this.label5, 0, 4);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(0, 0);
            this.tlp2.Margin = new System.Windows.Forms.Padding(0);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 7;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp2.Size = new System.Drawing.Size(574, 280);
            this.tlp2.TabIndex = 1;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(173, 161);
            this.cmbVendedor.Margin = new System.Windows.Forms.Padding(1);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(400, 39);
            this.cmbVendedor.TabIndex = 4;
            // 
            // txbCep
            // 
            this.txbCep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbCep.Location = new System.Drawing.Point(173, 121);
            this.txbCep.Margin = new System.Windows.Forms.Padding(1);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(400, 38);
            this.txbCep.TabIndex = 3;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbEndereco.Location = new System.Drawing.Point(173, 81);
            this.txbEndereco.Margin = new System.Windows.Forms.Padding(1);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(400, 38);
            this.txbEndereco.TabIndex = 2;
            // 
            // txbDocumento
            // 
            this.txbDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDocumento.Location = new System.Drawing.Point(173, 41);
            this.txbDocumento.Margin = new System.Windows.Forms.Padding(1);
            this.txbDocumento.Name = "txbDocumento";
            this.txbDocumento.Size = new System.Drawing.Size(400, 38);
            this.txbDocumento.TabIndex = 1;
            // 
            // txbNome
            // 
            this.txbNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbNome.Location = new System.Drawing.Point(173, 1);
            this.txbNome.Margin = new System.Windows.Forms.Padding(1);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(400, 38);
            this.txbNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // cmbAtivo
            // 
            this.cmbAtivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtivo.FormattingEnabled = true;
            this.cmbAtivo.Location = new System.Drawing.Point(173, 241);
            this.cmbAtivo.Margin = new System.Windows.Forms.Padding(1);
            this.cmbAtivo.Name = "cmbAtivo";
            this.cmbAtivo.Size = new System.Drawing.Size(400, 39);
            this.cmbAtivo.TabIndex = 6;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(3, 245);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(91, 30);
            this.lblAtivo.TabIndex = 20;
            this.lblAtivo.Text = "Status:";
            // 
            // txbBanco
            // 
            this.txbBanco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbBanco.Location = new System.Drawing.Point(173, 201);
            this.txbBanco.Margin = new System.Windows.Forms.Padding(1);
            this.txbBanco.Name = "txbBanco";
            this.txbBanco.Size = new System.Drawing.Size(400, 38);
            this.txbBanco.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Banco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Vendedor:";
            // 
            // frm1_3AddClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 607);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm1_3AddClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.tlp1.ResumeLayout(false);
            this.grpContatos.ResumeLayout(false);
            this.tlpContatos1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlp2.ResumeLayout(false);
            this.tlp2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.ComboBox cmbAtivo;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbDocumento;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBanco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpContatos;
        private System.Windows.Forms.TableLayoutPanel tlpContatos1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRemoverContato;
        private System.Windows.Forms.Button btnAdicionarContato;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txbTipoContato;
        private System.Windows.Forms.TextBox txbContato;
    }
}