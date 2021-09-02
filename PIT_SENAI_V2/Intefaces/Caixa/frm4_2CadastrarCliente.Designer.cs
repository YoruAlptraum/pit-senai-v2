
namespace PIT_SENAI_V2.Dados
{
    partial class frm4_2CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4_2CadastrarCliente));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.txbBanco = new System.Windows.Forms.TextBox();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbDocumento = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
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
            this.mns1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiNota = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAtualizarCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPesquisarID = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp1.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.grpContatos.SuspendLayout();
            this.tlpContatos1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.mns1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.btnCadastrar, 0, 3);
            this.tlp1.Controls.Add(this.tlp2, 0, 1);
            this.tlp1.Controls.Add(this.grpContatos, 0, 2);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 4;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.Size = new System.Drawing.Size(635, 596);
            this.tlp1.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 556);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(635, 40);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tlp2
            // 
            this.tlp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Controls.Add(this.txbBanco, 1, 4);
            this.tlp2.Controls.Add(this.txbCep, 1, 3);
            this.tlp2.Controls.Add(this.txbEndereco, 1, 2);
            this.tlp2.Controls.Add(this.txbDocumento, 1, 1);
            this.tlp2.Controls.Add(this.lblNome, 0, 0);
            this.tlp2.Controls.Add(this.lblDocumento, 0, 1);
            this.tlp2.Controls.Add(this.lblEndereço, 0, 2);
            this.tlp2.Controls.Add(this.lblCep, 0, 3);
            this.tlp2.Controls.Add(this.lblBanco, 0, 4);
            this.tlp2.Controls.Add(this.txbNome, 1, 0);
            this.tlp2.Location = new System.Drawing.Point(0, 24);
            this.tlp2.Margin = new System.Windows.Forms.Padding(0);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 5;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.Size = new System.Drawing.Size(635, 200);
            this.tlp2.TabIndex = 1;
            // 
            // txbBanco
            // 
            this.txbBanco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbBanco.Location = new System.Drawing.Point(171, 161);
            this.txbBanco.Margin = new System.Windows.Forms.Padding(1);
            this.txbBanco.Name = "txbBanco";
            this.txbBanco.Size = new System.Drawing.Size(463, 38);
            this.txbBanco.TabIndex = 9;
            // 
            // txbCep
            // 
            this.txbCep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbCep.Location = new System.Drawing.Point(171, 121);
            this.txbCep.Margin = new System.Windows.Forms.Padding(1);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(463, 38);
            this.txbCep.TabIndex = 8;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbEndereco.Location = new System.Drawing.Point(171, 81);
            this.txbEndereco.Margin = new System.Windows.Forms.Padding(1);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(463, 38);
            this.txbEndereco.TabIndex = 7;
            // 
            // txbDocumento
            // 
            this.txbDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDocumento.Location = new System.Drawing.Point(171, 41);
            this.txbDocumento.Margin = new System.Windows.Forms.Padding(1);
            this.txbDocumento.Name = "txbDocumento";
            this.txbDocumento.Size = new System.Drawing.Size(463, 38);
            this.txbDocumento.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(91, 31);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(3, 40);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(155, 31);
            this.lblDocumento.TabIndex = 1;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(3, 80);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(127, 31);
            this.lblEndereço.TabIndex = 2;
            this.lblEndereço.Text = "Endereço:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(3, 120);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(64, 31);
            this.lblCep.TabIndex = 3;
            this.lblCep.Text = "CEP:";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(3, 160);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(90, 31);
            this.lblBanco.TabIndex = 4;
            this.lblBanco.Text = "Banco:";
            // 
            // txbNome
            // 
            this.txbNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbNome.Location = new System.Drawing.Point(171, 1);
            this.txbNome.Margin = new System.Windows.Forms.Padding(1);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(463, 38);
            this.txbNome.TabIndex = 5;
            // 
            // grpContatos
            // 
            this.grpContatos.Controls.Add(this.tlpContatos1);
            this.grpContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContatos.Location = new System.Drawing.Point(0, 224);
            this.grpContatos.Margin = new System.Windows.Forms.Padding(0);
            this.grpContatos.Name = "grpContatos";
            this.grpContatos.Size = new System.Drawing.Size(635, 332);
            this.grpContatos.TabIndex = 2;
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
            this.tlpContatos1.Size = new System.Drawing.Size(629, 295);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 255);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRemoverContato
            // 
            this.btnRemoverContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoverContato.Location = new System.Drawing.Point(314, 0);
            this.btnRemoverContato.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoverContato.Name = "btnRemoverContato";
            this.btnRemoverContato.Size = new System.Drawing.Size(315, 40);
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
            this.btnAdicionarContato.Size = new System.Drawing.Size(314, 40);
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
            this.dgvContatos.Size = new System.Drawing.Size(623, 169);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(629, 80);
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
            this.txbTipoContato.Size = new System.Drawing.Size(507, 38);
            this.txbTipoContato.TabIndex = 10;
            // 
            // txbContato
            // 
            this.txbContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbContato.Location = new System.Drawing.Point(121, 41);
            this.txbContato.Margin = new System.Windows.Forms.Padding(1);
            this.txbContato.Name = "txbContato";
            this.txbContato.Size = new System.Drawing.Size(507, 38);
            this.txbContato.TabIndex = 11;
            // 
            // mns1
            // 
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Size = new System.Drawing.Size(635, 24);
            this.mns1.TabIndex = 6;
            this.mns1.Text = "Menu";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem5.Text = "Sair";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu,
            this.toolStripSeparator1,
            this.tsmiNota,
            this.toolStripSeparator2,
            this.tsmiCadastrar,
            this.tsmiAtualizarCadastro,
            this.toolStripSeparator3,
            this.tsmiPesquisarID,
            this.toolStripSeparator4,
            this.tsmiHistorico});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem6.Text = "Caixa";
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.Size = new System.Drawing.Size(180, 22);
            this.tsmiMenu.Text = "Menu";
            this.tsmiMenu.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiNota
            // 
            this.tsmiNota.Name = "tsmiNota";
            this.tsmiNota.Size = new System.Drawing.Size(180, 22);
            this.tsmiNota.Text = "Nota";
            this.tsmiNota.Click += new System.EventHandler(this.tsmiNota_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiCadastrar
            // 
            this.tsmiCadastrar.Name = "tsmiCadastrar";
            this.tsmiCadastrar.Size = new System.Drawing.Size(180, 22);
            this.tsmiCadastrar.Text = "Cadastrar";
            this.tsmiCadastrar.Click += new System.EventHandler(this.tsmiCadastrar_Click);
            // 
            // tsmiAtualizarCadastro
            // 
            this.tsmiAtualizarCadastro.Name = "tsmiAtualizarCadastro";
            this.tsmiAtualizarCadastro.Size = new System.Drawing.Size(180, 22);
            this.tsmiAtualizarCadastro.Text = "Atualizar Cadastro";
            this.tsmiAtualizarCadastro.Click += new System.EventHandler(this.tsmiAtualizarCadastro_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiPesquisarID
            // 
            this.tsmiPesquisarID.Name = "tsmiPesquisarID";
            this.tsmiPesquisarID.Size = new System.Drawing.Size(180, 22);
            this.tsmiPesquisarID.Text = "Pesquisar ID";
            this.tsmiPesquisarID.Click += new System.EventHandler(this.tsmiPesquisarID_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiHistorico
            // 
            this.tsmiHistorico.Name = "tsmiHistorico";
            this.tsmiHistorico.Size = new System.Drawing.Size(180, 22);
            this.tsmiHistorico.Text = "Histórico";
            this.tsmiHistorico.Click += new System.EventHandler(this.tsmiHistorico_Click);
            // 
            // frm4_2CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 596);
            this.Controls.Add(this.mns1);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm4_2CadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.tlp2.PerformLayout();
            this.grpContatos.ResumeLayout(false);
            this.tlpContatos1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.mns1.ResumeLayout(false);
            this.mns1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.GroupBox grpContatos;
        private System.Windows.Forms.TextBox txbBanco;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbDocumento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txbNome;
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
        private System.Windows.Forms.MenuStrip mns1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNota;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiAtualizarCadastro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiPesquisarID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistorico;
    }
}