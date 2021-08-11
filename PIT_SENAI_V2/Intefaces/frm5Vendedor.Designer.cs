
namespace PIT_SENAI_V2.Dados
{
    partial class frm5Vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm5Vendedor));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPesquisarCliente = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.txbPesquisarCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpOrdem = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvItemsDaOrdem = new System.Windows.Forms.DataGridView();
            this.grpCatalogo = new System.Windows.Forms.GroupBox();
            this.tlpProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPesquisarCatalogo = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisarCatalogo = new System.Windows.Forms.Button();
            this.txbPesquisarCatalogo = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.btnNovaOrdem = new System.Windows.Forms.Button();
            this.grpDescricao = new System.Windows.Forms.GroupBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.tlpBotoesBaixo = new System.Windows.Forms.TableLayoutPanel();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tlp1.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.tlpPesquisarCliente.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.grpOrdem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsDaOrdem)).BeginInit();
            this.grpCatalogo.SuspendLayout();
            this.tlpProdutos.SuspendLayout();
            this.tlpPesquisarCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.grpDescricao.SuspendLayout();
            this.tlpBotoesBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.grpCliente, 0, 0);
            this.tlp1.Controls.Add(this.tlp2, 0, 3);
            this.tlp1.Controls.Add(this.btnNovaOrdem, 0, 2);
            this.tlp1.Controls.Add(this.grpDescricao, 0, 1);
            this.tlp1.Controls.Add(this.tlpBotoesBaixo, 0, 4);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 5;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.Size = new System.Drawing.Size(764, 561);
            this.tlp1.TabIndex = 0;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.tlpCliente);
            this.grpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCliente.Location = new System.Drawing.Point(0, 0);
            this.grpCliente.Margin = new System.Windows.Forms.Padding(0);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(0);
            this.grpCliente.Size = new System.Drawing.Size(764, 100);
            this.grpCliente.TabIndex = 3;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Selecionar Cliente:";
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 1;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCliente.Controls.Add(this.tlpPesquisarCliente, 0, 0);
            this.tlpCliente.Controls.Add(this.lblCliente, 0, 1);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(0, 31);
            this.tlpCliente.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 2;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCliente.Size = new System.Drawing.Size(764, 69);
            this.tlpCliente.TabIndex = 0;
            // 
            // tlpPesquisarCliente
            // 
            this.tlpPesquisarCliente.ColumnCount = 2;
            this.tlpPesquisarCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPesquisarCliente.Controls.Add(this.btnPesquisarCliente, 1, 0);
            this.tlpPesquisarCliente.Controls.Add(this.txbPesquisarCliente, 0, 0);
            this.tlpPesquisarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPesquisarCliente.Location = new System.Drawing.Point(0, 0);
            this.tlpPesquisarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisarCliente.Name = "tlpPesquisarCliente";
            this.tlpPesquisarCliente.RowCount = 1;
            this.tlpPesquisarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarCliente.Size = new System.Drawing.Size(764, 38);
            this.tlpPesquisarCliente.TabIndex = 1;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCliente.BackgroundImage")));
            this.btnPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(714, 0);
            this.btnPesquisarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(50, 38);
            this.btnPesquisarCliente.TabIndex = 0;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // txbPesquisarCliente
            // 
            this.txbPesquisarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarCliente.Location = new System.Drawing.Point(0, 0);
            this.txbPesquisarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.txbPesquisarCliente.Name = "txbPesquisarCliente";
            this.txbPesquisarCliente.Size = new System.Drawing.Size(714, 38);
            this.txbPesquisarCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 38);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(100, 31);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.94244F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.05755F));
            this.tlp2.Controls.Add(this.grpOrdem, 1, 0);
            this.tlp2.Controls.Add(this.grpCatalogo, 0, 0);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(0, 212);
            this.tlp2.Margin = new System.Windows.Forms.Padding(0);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Size = new System.Drawing.Size(764, 309);
            this.tlp2.TabIndex = 1;
            // 
            // grpOrdem
            // 
            this.grpOrdem.Controls.Add(this.tableLayoutPanel1);
            this.grpOrdem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOrdem.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrdem.Location = new System.Drawing.Point(549, 0);
            this.grpOrdem.Margin = new System.Windows.Forms.Padding(0);
            this.grpOrdem.MinimumSize = new System.Drawing.Size(230, 0);
            this.grpOrdem.Name = "grpOrdem";
            this.grpOrdem.Padding = new System.Windows.Forms.Padding(0);
            this.grpOrdem.Size = new System.Drawing.Size(230, 309);
            this.grpOrdem.TabIndex = 0;
            this.grpOrdem.TabStop = false;
            this.grpOrdem.Text = "Items da Ordem:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvItemsDaOrdem, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(3, 248);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 30);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // dgvItemsDaOrdem
            // 
            this.dgvItemsDaOrdem.AllowUserToAddRows = false;
            this.dgvItemsDaOrdem.AllowUserToDeleteRows = false;
            this.dgvItemsDaOrdem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsDaOrdem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItemsDaOrdem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsDaOrdem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsDaOrdem.Location = new System.Drawing.Point(0, 0);
            this.dgvItemsDaOrdem.Margin = new System.Windows.Forms.Padding(0);
            this.dgvItemsDaOrdem.Name = "dgvItemsDaOrdem";
            this.dgvItemsDaOrdem.ReadOnly = true;
            this.dgvItemsDaOrdem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsDaOrdem.Size = new System.Drawing.Size(230, 248);
            this.dgvItemsDaOrdem.TabIndex = 1;
            // 
            // grpCatalogo
            // 
            this.grpCatalogo.Controls.Add(this.tlpProdutos);
            this.grpCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCatalogo.Location = new System.Drawing.Point(0, 0);
            this.grpCatalogo.Margin = new System.Windows.Forms.Padding(0);
            this.grpCatalogo.Name = "grpCatalogo";
            this.grpCatalogo.Padding = new System.Windows.Forms.Padding(0);
            this.grpCatalogo.Size = new System.Drawing.Size(549, 309);
            this.grpCatalogo.TabIndex = 2;
            this.grpCatalogo.TabStop = false;
            this.grpCatalogo.Text = "Catálogo:";
            // 
            // tlpProdutos
            // 
            this.tlpProdutos.ColumnCount = 1;
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProdutos.Controls.Add(this.tlpPesquisarCatalogo, 0, 0);
            this.tlpProdutos.Controls.Add(this.btnAdicionar, 0, 2);
            this.tlpProdutos.Controls.Add(this.dgvCatalogo, 0, 1);
            this.tlpProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProdutos.Location = new System.Drawing.Point(0, 31);
            this.tlpProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpProdutos.Name = "tlpProdutos";
            this.tlpProdutos.RowCount = 3;
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProdutos.Size = new System.Drawing.Size(549, 278);
            this.tlpProdutos.TabIndex = 0;
            // 
            // tlpPesquisarCatalogo
            // 
            this.tlpPesquisarCatalogo.ColumnCount = 2;
            this.tlpPesquisarCatalogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarCatalogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPesquisarCatalogo.Controls.Add(this.btnPesquisarCatalogo, 1, 0);
            this.tlpPesquisarCatalogo.Controls.Add(this.txbPesquisarCatalogo, 0, 0);
            this.tlpPesquisarCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPesquisarCatalogo.Location = new System.Drawing.Point(0, 0);
            this.tlpPesquisarCatalogo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisarCatalogo.Name = "tlpPesquisarCatalogo";
            this.tlpPesquisarCatalogo.RowCount = 1;
            this.tlpPesquisarCatalogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarCatalogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPesquisarCatalogo.Size = new System.Drawing.Size(549, 38);
            this.tlpPesquisarCatalogo.TabIndex = 2;
            // 
            // btnPesquisarCatalogo
            // 
            this.btnPesquisarCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCatalogo.BackgroundImage")));
            this.btnPesquisarCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarCatalogo.Location = new System.Drawing.Point(499, 0);
            this.btnPesquisarCatalogo.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarCatalogo.Name = "btnPesquisarCatalogo";
            this.btnPesquisarCatalogo.Size = new System.Drawing.Size(50, 38);
            this.btnPesquisarCatalogo.TabIndex = 0;
            this.btnPesquisarCatalogo.UseVisualStyleBackColor = true;
            this.btnPesquisarCatalogo.Click += new System.EventHandler(this.btnPesquisarCatalogo_Click);
            // 
            // txbPesquisarCatalogo
            // 
            this.txbPesquisarCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarCatalogo.Location = new System.Drawing.Point(0, 0);
            this.txbPesquisarCatalogo.Margin = new System.Windows.Forms.Padding(0);
            this.txbPesquisarCatalogo.Name = "txbPesquisarCatalogo";
            this.txbPesquisarCatalogo.Size = new System.Drawing.Size(499, 38);
            this.txbPesquisarCatalogo.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 238);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(549, 40);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatalogo.Location = new System.Drawing.Point(0, 38);
            this.dgvCatalogo.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(549, 200);
            this.dgvCatalogo.TabIndex = 3;
            this.dgvCatalogo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogo_RowEnter);
            // 
            // btnNovaOrdem
            // 
            this.btnNovaOrdem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovaOrdem.Location = new System.Drawing.Point(0, 172);
            this.btnNovaOrdem.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovaOrdem.Name = "btnNovaOrdem";
            this.btnNovaOrdem.Size = new System.Drawing.Size(764, 40);
            this.btnNovaOrdem.TabIndex = 4;
            this.btnNovaOrdem.Text = "Nova Ordem";
            this.btnNovaOrdem.UseVisualStyleBackColor = true;
            this.btnNovaOrdem.Click += new System.EventHandler(this.btnNovaOrdem_Click);
            // 
            // grpDescricao
            // 
            this.grpDescricao.Controls.Add(this.txbDescricao);
            this.grpDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDescricao.Location = new System.Drawing.Point(0, 100);
            this.grpDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.grpDescricao.Name = "grpDescricao";
            this.grpDescricao.Padding = new System.Windows.Forms.Padding(0);
            this.grpDescricao.Size = new System.Drawing.Size(764, 72);
            this.grpDescricao.TabIndex = 5;
            this.grpDescricao.TabStop = false;
            this.grpDescricao.Text = "Descrição da Ordem:";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDescricao.Location = new System.Drawing.Point(0, 31);
            this.txbDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(764, 38);
            this.txbDescricao.TabIndex = 0;
            // 
            // tlpBotoesBaixo
            // 
            this.tlpBotoesBaixo.ColumnCount = 2;
            this.tlpBotoesBaixo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoesBaixo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoesBaixo.Controls.Add(this.btnDescartar, 0, 0);
            this.tlpBotoesBaixo.Controls.Add(this.btnImprimir, 0, 0);
            this.tlpBotoesBaixo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotoesBaixo.Location = new System.Drawing.Point(0, 521);
            this.tlpBotoesBaixo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotoesBaixo.Name = "tlpBotoesBaixo";
            this.tlpBotoesBaixo.RowCount = 1;
            this.tlpBotoesBaixo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoesBaixo.Size = new System.Drawing.Size(764, 40);
            this.tlpBotoesBaixo.TabIndex = 6;
            // 
            // btnDescartar
            // 
            this.btnDescartar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDescartar.Location = new System.Drawing.Point(382, 0);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(0);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(382, 40);
            this.btnDescartar.TabIndex = 2;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimir.Location = new System.Drawing.Point(0, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(382, 40);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frm5Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 561);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimumSize = new System.Drawing.Size(780, 600);
            this.Name = "frm5Vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp1.ResumeLayout(false);
            this.grpCliente.ResumeLayout(false);
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            this.tlpPesquisarCliente.ResumeLayout(false);
            this.tlpPesquisarCliente.PerformLayout();
            this.tlp2.ResumeLayout(false);
            this.grpOrdem.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsDaOrdem)).EndInit();
            this.grpCatalogo.ResumeLayout(false);
            this.tlpProdutos.ResumeLayout(false);
            this.tlpPesquisarCatalogo.ResumeLayout(false);
            this.tlpPesquisarCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.grpDescricao.ResumeLayout(false);
            this.grpDescricao.PerformLayout();
            this.tlpBotoesBaixo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.GroupBox grpOrdem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvItemsDaOrdem;
        private System.Windows.Forms.GroupBox grpCatalogo;
        private System.Windows.Forms.TableLayoutPanel tlpProdutos;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarCatalogo;
        private System.Windows.Forms.Button btnPesquisarCatalogo;
        private System.Windows.Forms.TextBox txbPesquisarCatalogo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.TextBox txbPesquisarCliente;
        private System.Windows.Forms.Button btnNovaOrdem;
        private System.Windows.Forms.GroupBox grpDescricao;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TableLayoutPanel tlpBotoesBaixo;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnImprimir;
    }
}