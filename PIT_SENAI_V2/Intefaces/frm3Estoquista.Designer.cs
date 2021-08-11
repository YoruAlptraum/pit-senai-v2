
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.tlpPesquisarEstoque = new System.Windows.Forms.TableLayoutPanel();
            this.txbPesquisarEstoque = new System.Windows.Forms.TextBox();
            this.btnPesquisarEstoque = new System.Windows.Forms.Button();
            this.tabPesquisa = new System.Windows.Forms.TabControl();
            this.tpProdutos = new System.Windows.Forms.TabPage();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.tlpPesquisarProduto = new System.Windows.Forms.TableLayoutPanel();
            this.txbPesquisarProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.tpFornecedores = new System.Windows.Forms.TabPage();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.tlpPesquisarFornecedor = new System.Windows.Forms.TableLayoutPanel();
            this.txbPesquisarFornecedor = new System.Windows.Forms.TextBox();
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.tlpPesquisarEstoque.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.tlpPesquisarProduto.SuspendLayout();
            this.tpFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.tlpPesquisarFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvEstoque);
            this.splitContainer1.Panel1.Controls.Add(this.tlpPesquisarEstoque);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabPesquisa);
            this.splitContainer1.Size = new System.Drawing.Size(784, 461);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnEntrada, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSaida, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 418);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 43);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEntrada.Location = new System.Drawing.Point(246, 0);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(247, 43);
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
            this.btnSaida.Size = new System.Drawing.Size(246, 43);
            this.btnSaida.TabIndex = 19;
            this.btnSaida.Text = "Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstoque.Location = new System.Drawing.Point(0, 44);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.dgvEstoque.MultiSelect = false;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowTemplate.Height = 40;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(493, 417);
            this.dgvEstoque.TabIndex = 3;
            this.dgvEstoque.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstoque_CellMouseClick);
            // 
            // tlpPesquisarEstoque
            // 
            this.tlpPesquisarEstoque.ColumnCount = 2;
            this.tlpPesquisarEstoque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarEstoque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpPesquisarEstoque.Controls.Add(this.txbPesquisarEstoque, 0, 0);
            this.tlpPesquisarEstoque.Controls.Add(this.btnPesquisarEstoque, 1, 0);
            this.tlpPesquisarEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPesquisarEstoque.Location = new System.Drawing.Point(0, 0);
            this.tlpPesquisarEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisarEstoque.Name = "tlpPesquisarEstoque";
            this.tlpPesquisarEstoque.RowCount = 1;
            this.tlpPesquisarEstoque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarEstoque.Size = new System.Drawing.Size(493, 44);
            this.tlpPesquisarEstoque.TabIndex = 2;
            // 
            // txbPesquisarEstoque
            // 
            this.txbPesquisarEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarEstoque.Location = new System.Drawing.Point(3, 3);
            this.txbPesquisarEstoque.Name = "txbPesquisarEstoque";
            this.txbPesquisarEstoque.Size = new System.Drawing.Size(433, 38);
            this.txbPesquisarEstoque.TabIndex = 1;
            // 
            // btnPesquisarEstoque
            // 
            this.btnPesquisarEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarEstoque.BackgroundImage")));
            this.btnPesquisarEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarEstoque.Location = new System.Drawing.Point(439, 0);
            this.btnPesquisarEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarEstoque.Name = "btnPesquisarEstoque";
            this.btnPesquisarEstoque.Size = new System.Drawing.Size(54, 44);
            this.btnPesquisarEstoque.TabIndex = 2;
            this.btnPesquisarEstoque.Text = " ";
            this.btnPesquisarEstoque.UseVisualStyleBackColor = true;
            this.btnPesquisarEstoque.Click += new System.EventHandler(this.btnPesquisarEstoque_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.tpProdutos);
            this.tabPesquisa.Controls.Add(this.tpFornecedores);
            this.tabPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPesquisa.Location = new System.Drawing.Point(0, 0);
            this.tabPesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.SelectedIndex = 0;
            this.tabPesquisa.Size = new System.Drawing.Size(287, 461);
            this.tabPesquisa.TabIndex = 0;
            // 
            // tpProdutos
            // 
            this.tpProdutos.Controls.Add(this.dgvProdutos);
            this.tpProdutos.Controls.Add(this.tlpPesquisarProduto);
            this.tpProdutos.Location = new System.Drawing.Point(4, 40);
            this.tpProdutos.Name = "tpProdutos";
            this.tpProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProdutos.Size = new System.Drawing.Size(279, 417);
            this.tpProdutos.TabIndex = 0;
            this.tpProdutos.Text = "Produtos";
            this.tpProdutos.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
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
            this.dgvProdutos.Size = new System.Drawing.Size(273, 367);
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
            this.tlpPesquisarProduto.Size = new System.Drawing.Size(273, 44);
            this.tlpPesquisarProduto.TabIndex = 3;
            // 
            // txbPesquisarProduto
            // 
            this.txbPesquisarProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarProduto.Location = new System.Drawing.Point(3, 3);
            this.txbPesquisarProduto.Name = "txbPesquisarProduto";
            this.txbPesquisarProduto.Size = new System.Drawing.Size(220, 38);
            this.txbPesquisarProduto.TabIndex = 1;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarProduto.BackgroundImage")));
            this.btnPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(226, 0);
            this.btnPesquisarProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(47, 44);
            this.btnPesquisarProduto.TabIndex = 2;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // tpFornecedores
            // 
            this.tpFornecedores.Controls.Add(this.dgvFornecedores);
            this.tpFornecedores.Controls.Add(this.tlpPesquisarFornecedor);
            this.tpFornecedores.Location = new System.Drawing.Point(4, 40);
            this.tpFornecedores.Name = "tpFornecedores";
            this.tpFornecedores.Padding = new System.Windows.Forms.Padding(3);
            this.tpFornecedores.Size = new System.Drawing.Size(279, 417);
            this.tpFornecedores.TabIndex = 1;
            this.tpFornecedores.Text = "Fornecedores";
            this.tpFornecedores.UseVisualStyleBackColor = true;
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
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
            this.dgvFornecedores.Size = new System.Drawing.Size(273, 367);
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
            this.tlpPesquisarFornecedor.Size = new System.Drawing.Size(273, 44);
            this.tlpPesquisarFornecedor.TabIndex = 4;
            // 
            // txbPesquisarFornecedor
            // 
            this.txbPesquisarFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarFornecedor.Location = new System.Drawing.Point(3, 3);
            this.txbPesquisarFornecedor.Name = "txbPesquisarFornecedor";
            this.txbPesquisarFornecedor.Size = new System.Drawing.Size(220, 38);
            this.txbPesquisarFornecedor.TabIndex = 1;
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarFornecedor.BackgroundImage")));
            this.btnPesquisarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(226, 0);
            this.btnPesquisarFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(47, 44);
            this.btnPesquisarFornecedor.TabIndex = 2;
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = true;
            this.btnPesquisarFornecedor.Click += new System.EventHandler(this.btnPesquisarFornecedor_Click);
            // 
            // frm3Estoquista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "frm3Estoquista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm3Estoquista_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.tlpPesquisarEstoque.ResumeLayout(false);
            this.tlpPesquisarEstoque.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.tlpPesquisarProduto.ResumeLayout(false);
            this.tlpPesquisarProduto.PerformLayout();
            this.tpFornecedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.tlpPesquisarFornecedor.ResumeLayout(false);
            this.tlpPesquisarFornecedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabPesquisa;
        private System.Windows.Forms.TabPage tpProdutos;
        private System.Windows.Forms.TabPage tpFornecedores;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarEstoque;
        private System.Windows.Forms.TextBox txbPesquisarEstoque;
        private System.Windows.Forms.Button btnPesquisarEstoque;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarProduto;
        private System.Windows.Forms.TextBox txbPesquisarProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarFornecedor;
        private System.Windows.Forms.TextBox txbPesquisarFornecedor;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
    }
}