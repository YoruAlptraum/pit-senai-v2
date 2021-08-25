
namespace PIT_SENAI_V2.Dados
{
    partial class frm3Estoquista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3Estoquista));
            this.tlpPesquisarEstoque = new System.Windows.Forms.TableLayoutPanel();
            this.txbPesquisarEstoque = new System.Windows.Forms.TextBox();
            this.btnPesquisarEstoque = new System.Windows.Forms.Button();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPesquisa = new System.Windows.Forms.TabControl();
            this.tlpProdutos = new System.Windows.Forms.TabPage();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.tlpPesquisarProduto = new System.Windows.Forms.TableLayoutPanel();
            this.txbPesquisarProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.tlpFornecedores = new System.Windows.Forms.TabPage();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.tlpPesquisarFornecedor = new System.Windows.Forms.TableLayoutPanel();
            this.txbPesquisarFornecedor = new System.Windows.Forms.TextBox();
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            this.tlp3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEntradaSaida = new System.Windows.Forms.TableLayoutPanel();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.mns1 = new System.Windows.Forms.MenuStrip();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpPesquisarEstoque.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tlpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.tlpPesquisarProduto.SuspendLayout();
            this.tlpFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.tlpPesquisarFornecedor.SuspendLayout();
            this.tlp3.SuspendLayout();
            this.tlpEntradaSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.tlp1.SuspendLayout();
            this.mns1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPesquisarEstoque
            // 
            this.tlpPesquisarEstoque.ColumnCount = 2;
            this.tlpPesquisarEstoque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarEstoque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPesquisarEstoque.Controls.Add(this.txbPesquisarEstoque, 0, 0);
            this.tlpPesquisarEstoque.Controls.Add(this.btnPesquisarEstoque, 1, 0);
            this.tlpPesquisarEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPesquisarEstoque.Location = new System.Drawing.Point(0, 0);
            this.tlpPesquisarEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisarEstoque.Name = "tlpPesquisarEstoque";
            this.tlpPesquisarEstoque.RowCount = 1;
            this.tlpPesquisarEstoque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarEstoque.Size = new System.Drawing.Size(485, 40);
            this.tlpPesquisarEstoque.TabIndex = 2;
            // 
            // txbPesquisarEstoque
            // 
            this.txbPesquisarEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarEstoque.Location = new System.Drawing.Point(1, 1);
            this.txbPesquisarEstoque.Margin = new System.Windows.Forms.Padding(1);
            this.txbPesquisarEstoque.Name = "txbPesquisarEstoque";
            this.txbPesquisarEstoque.Size = new System.Drawing.Size(443, 38);
            this.txbPesquisarEstoque.TabIndex = 1;
            // 
            // btnPesquisarEstoque
            // 
            this.btnPesquisarEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarEstoque.BackgroundImage")));
            this.btnPesquisarEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarEstoque.Location = new System.Drawing.Point(445, 0);
            this.btnPesquisarEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarEstoque.Name = "btnPesquisarEstoque";
            this.btnPesquisarEstoque.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisarEstoque.TabIndex = 2;
            this.btnPesquisarEstoque.Text = " ";
            this.btnPesquisarEstoque.UseVisualStyleBackColor = true;
            this.btnPesquisarEstoque.Click += new System.EventHandler(this.btnPesquisarEstoque_Click);
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Controls.Add(this.tabPesquisa, 1, 0);
            this.tlp2.Controls.Add(this.tlp3, 0, 0);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(3, 27);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Size = new System.Drawing.Size(971, 550);
            this.tlp2.TabIndex = 3;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.tlpProdutos);
            this.tabPesquisa.Controls.Add(this.tlpFornecedores);
            this.tabPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPesquisa.Location = new System.Drawing.Point(485, 0);
            this.tabPesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.SelectedIndex = 0;
            this.tabPesquisa.Size = new System.Drawing.Size(486, 550);
            this.tabPesquisa.TabIndex = 1;
            // 
            // tlpProdutos
            // 
            this.tlpProdutos.Controls.Add(this.dgvProdutos);
            this.tlpProdutos.Controls.Add(this.tlpPesquisarProduto);
            this.tlpProdutos.Location = new System.Drawing.Point(4, 40);
            this.tlpProdutos.Name = "tlpProdutos";
            this.tlpProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tlpProdutos.Size = new System.Drawing.Size(478, 506);
            this.tlpProdutos.TabIndex = 0;
            this.tlpProdutos.Text = "Produtos";
            this.tlpProdutos.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 47);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowTemplate.Height = 40;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(472, 456);
            this.dgvProdutos.TabIndex = 4;
            // 
            // tlpPesquisarProduto
            // 
            this.tlpPesquisarProduto.ColumnCount = 2;
            this.tlpPesquisarProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpPesquisarProduto.Controls.Add(this.txbPesquisarProduto, 0, 0);
            this.tlpPesquisarProduto.Controls.Add(this.btnPesquisarProduto, 1, 0);
            this.tlpPesquisarProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPesquisarProduto.Location = new System.Drawing.Point(3, 3);
            this.tlpPesquisarProduto.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisarProduto.Name = "tlpPesquisarProduto";
            this.tlpPesquisarProduto.RowCount = 1;
            this.tlpPesquisarProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarProduto.Size = new System.Drawing.Size(472, 44);
            this.tlpPesquisarProduto.TabIndex = 3;
            // 
            // txbPesquisarProduto
            // 
            this.txbPesquisarProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarProduto.Location = new System.Drawing.Point(3, 3);
            this.txbPesquisarProduto.Name = "txbPesquisarProduto";
            this.txbPesquisarProduto.Size = new System.Drawing.Size(419, 38);
            this.txbPesquisarProduto.TabIndex = 1;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarProduto.BackgroundImage")));
            this.btnPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(425, 0);
            this.btnPesquisarProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(47, 44);
            this.btnPesquisarProduto.TabIndex = 2;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // tlpFornecedores
            // 
            this.tlpFornecedores.Controls.Add(this.dgvFornecedores);
            this.tlpFornecedores.Controls.Add(this.tlpPesquisarFornecedor);
            this.tlpFornecedores.Location = new System.Drawing.Point(4, 40);
            this.tlpFornecedores.Name = "tlpFornecedores";
            this.tlpFornecedores.Padding = new System.Windows.Forms.Padding(3);
            this.tlpFornecedores.Size = new System.Drawing.Size(478, 506);
            this.tlpFornecedores.TabIndex = 1;
            this.tlpFornecedores.Text = "Fornecedores";
            this.tlpFornecedores.UseVisualStyleBackColor = true;
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFornecedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFornecedores.Location = new System.Drawing.Point(3, 47);
            this.dgvFornecedores.Margin = new System.Windows.Forms.Padding(0);
            this.dgvFornecedores.MultiSelect = false;
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.RowTemplate.Height = 40;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(472, 456);
            this.dgvFornecedores.TabIndex = 5;
            // 
            // tlpPesquisarFornecedor
            // 
            this.tlpPesquisarFornecedor.ColumnCount = 2;
            this.tlpPesquisarFornecedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarFornecedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpPesquisarFornecedor.Controls.Add(this.txbPesquisarFornecedor, 0, 0);
            this.tlpPesquisarFornecedor.Controls.Add(this.btnPesquisarFornecedor, 1, 0);
            this.tlpPesquisarFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPesquisarFornecedor.Location = new System.Drawing.Point(3, 3);
            this.tlpPesquisarFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisarFornecedor.Name = "tlpPesquisarFornecedor";
            this.tlpPesquisarFornecedor.RowCount = 1;
            this.tlpPesquisarFornecedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarFornecedor.Size = new System.Drawing.Size(472, 44);
            this.tlpPesquisarFornecedor.TabIndex = 4;
            // 
            // txbPesquisarFornecedor
            // 
            this.txbPesquisarFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarFornecedor.Location = new System.Drawing.Point(3, 3);
            this.txbPesquisarFornecedor.Name = "txbPesquisarFornecedor";
            this.txbPesquisarFornecedor.Size = new System.Drawing.Size(419, 38);
            this.txbPesquisarFornecedor.TabIndex = 1;
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarFornecedor.BackgroundImage")));
            this.btnPesquisarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(425, 0);
            this.btnPesquisarFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(47, 44);
            this.btnPesquisarFornecedor.TabIndex = 2;
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = true;
            this.btnPesquisarFornecedor.Click += new System.EventHandler(this.btnPesquisarFornecedor_Click);
            // 
            // tlp3
            // 
            this.tlp3.ColumnCount = 1;
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp3.Controls.Add(this.tlpEntradaSaida, 0, 2);
            this.tlp3.Controls.Add(this.dgvEstoque, 0, 1);
            this.tlp3.Controls.Add(this.tlpPesquisarEstoque, 0, 0);
            this.tlp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp3.Location = new System.Drawing.Point(0, 0);
            this.tlp3.Margin = new System.Windows.Forms.Padding(0);
            this.tlp3.Name = "tlp3";
            this.tlp3.RowCount = 3;
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp3.Size = new System.Drawing.Size(485, 550);
            this.tlp3.TabIndex = 2;
            // 
            // tlpEntradaSaida
            // 
            this.tlpEntradaSaida.ColumnCount = 2;
            this.tlpEntradaSaida.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntradaSaida.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntradaSaida.Controls.Add(this.btnEntrada, 1, 0);
            this.tlpEntradaSaida.Controls.Add(this.btnSaida, 0, 0);
            this.tlpEntradaSaida.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpEntradaSaida.Location = new System.Drawing.Point(0, 510);
            this.tlpEntradaSaida.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEntradaSaida.Name = "tlpEntradaSaida";
            this.tlpEntradaSaida.RowCount = 1;
            this.tlpEntradaSaida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntradaSaida.Size = new System.Drawing.Size(485, 40);
            this.tlpEntradaSaida.TabIndex = 21;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEntrada.Location = new System.Drawing.Point(242, 0);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(243, 40);
            this.btnEntrada.TabIndex = 13;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaida.Location = new System.Drawing.Point(0, 0);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(242, 40);
            this.btnSaida.TabIndex = 19;
            this.btnSaida.Text = "Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstoque.Location = new System.Drawing.Point(0, 40);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.dgvEstoque.MultiSelect = false;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowTemplate.Height = 40;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(485, 470);
            this.dgvEstoque.TabIndex = 4;
            this.dgvEstoque.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstoque_CellMouseClick);
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.mns1, 0, 0);
            this.tlp1.Controls.Add(this.tlp2, 0, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Size = new System.Drawing.Size(977, 580);
            this.tlp1.TabIndex = 4;
            // 
            // mns1
            // 
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Size = new System.Drawing.Size(977, 24);
            this.mns1.TabIndex = 4;
            this.mns1.Text = "Menu";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.logOffToolStripMenuItem.Text = "Sair";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // frm3Estoquista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 580);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "frm3Estoquista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm3Estoquista_KeyDown);
            this.tlpPesquisarEstoque.ResumeLayout(false);
            this.tlpPesquisarEstoque.PerformLayout();
            this.tlp2.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tlpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.tlpPesquisarProduto.ResumeLayout(false);
            this.tlpPesquisarProduto.PerformLayout();
            this.tlpFornecedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.tlpPesquisarFornecedor.ResumeLayout(false);
            this.tlpPesquisarFornecedor.PerformLayout();
            this.tlp3.ResumeLayout(false);
            this.tlpEntradaSaida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.mns1.ResumeLayout(false);
            this.mns1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarEstoque;
        private System.Windows.Forms.TextBox txbPesquisarEstoque;
        private System.Windows.Forms.Button btnPesquisarEstoque;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.TabControl tabPesquisa;
        private System.Windows.Forms.TabPage tlpProdutos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarProduto;
        private System.Windows.Forms.TextBox txbPesquisarProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.TabPage tlpFornecedores;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarFornecedor;
        private System.Windows.Forms.TextBox txbPesquisarFornecedor;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        private System.Windows.Forms.TableLayoutPanel tlp3;
        private System.Windows.Forms.TableLayoutPanel tlpEntradaSaida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.MenuStrip mns1;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
    }
}