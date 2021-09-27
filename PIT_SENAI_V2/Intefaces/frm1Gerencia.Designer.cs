
namespace PIT_SENAI_V2.Dados
{
    partial class frm1Gerencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1Gerencia));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.mns1 = new System.Windows.Forms.MenuStrip();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFormasDePagamento = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnMenus = new System.Windows.Forms.Button();
            this.tlpSessao = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.tlp1.SuspendLayout();
            this.mns1.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.tlpSessao.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
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
            this.tlp1.Size = new System.Drawing.Size(871, 517);
            this.tlp1.TabIndex = 3;
            // 
            // mns1
            // 
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Size = new System.Drawing.Size(871, 24);
            this.mns1.TabIndex = 3;
            this.mns1.Text = "Menu";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.logOffToolStripMenuItem.Text = "Sair";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77483F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.22516F));
            this.tlp2.Controls.Add(this.pnlBotoes, 0, 0);
            this.tlp2.Controls.Add(this.tlpSessao, 1, 0);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(0, 24);
            this.tlp2.Margin = new System.Windows.Forms.Padding(0);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Size = new System.Drawing.Size(871, 493);
            this.tlp2.TabIndex = 4;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.AutoScroll = true;
            this.pnlBotoes.Controls.Add(this.btnFormasDePagamento);
            this.pnlBotoes.Controls.Add(this.btnCategorias);
            this.pnlBotoes.Controls.Add(this.btnDevolucao);
            this.pnlBotoes.Controls.Add(this.btnProdutos);
            this.pnlBotoes.Controls.Add(this.btnClientes);
            this.pnlBotoes.Controls.Add(this.btnFornecedores);
            this.pnlBotoes.Controls.Add(this.btnFuncionarios);
            this.pnlBotoes.Controls.Add(this.btnMenus);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(294, 493);
            this.pnlBotoes.TabIndex = 0;
            // 
            // btnFormasDePagamento
            // 
            this.btnFormasDePagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormasDePagamento.Image = global::PIT_SENAI_V2.Properties.Resources.Pagamento;
            this.btnFormasDePagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormasDePagamento.Location = new System.Drawing.Point(0, 350);
            this.btnFormasDePagamento.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormasDePagamento.Name = "btnFormasDePagamento";
            this.btnFormasDePagamento.Size = new System.Drawing.Size(294, 70);
            this.btnFormasDePagamento.TabIndex = 7;
            this.btnFormasDePagamento.Text = "Formas de \r\nPagamento";
            this.btnFormasDePagamento.UseVisualStyleBackColor = true;
            this.btnFormasDePagamento.Click += new System.EventHandler(this.btnFormasDePagamento_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.Image = global::PIT_SENAI_V2.Properties.Resources.Categorias;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(0, 300);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(294, 50);
            this.btnCategorias.TabIndex = 6;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevolucao.Image = global::PIT_SENAI_V2.Properties.Resources.Devoluções;
            this.btnDevolucao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucao.Location = new System.Drawing.Point(0, 250);
            this.btnDevolucao.Margin = new System.Windows.Forms.Padding(0);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(294, 50);
            this.btnDevolucao.TabIndex = 5;
            this.btnDevolucao.Text = "Devolução";
            this.btnDevolucao.UseVisualStyleBackColor = true;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.Image = global::PIT_SENAI_V2.Properties.Resources.Produtos;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 200);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(294, 50);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.Image = global::PIT_SENAI_V2.Properties.Resources.Clientes;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 150);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(294, 50);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornecedores.Image = global::PIT_SENAI_V2.Properties.Resources.Fornecedores;
            this.btnFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedores.Location = new System.Drawing.Point(0, 100);
            this.btnFornecedores.Margin = new System.Windows.Forms.Padding(0);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(294, 50);
            this.btnFornecedores.TabIndex = 2;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionarios.Image = global::PIT_SENAI_V2.Properties.Resources.Funcionarios;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 50);
            this.btnFuncionarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(294, 50);
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnMenus
            // 
            this.btnMenus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenus.Image = global::PIT_SENAI_V2.Properties.Resources.Menus;
            this.btnMenus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenus.Location = new System.Drawing.Point(0, 0);
            this.btnMenus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(294, 50);
            this.btnMenus.TabIndex = 0;
            this.btnMenus.Text = "Menus";
            this.btnMenus.UseVisualStyleBackColor = true;
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            // 
            // tlpSessao
            // 
            this.tlpSessao.ColumnCount = 1;
            this.tlpSessao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSessao.Controls.Add(this.pnlTitulo, 0, 0);
            this.tlpSessao.Controls.Add(this.pnlConteudo, 0, 1);
            this.tlpSessao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSessao.Location = new System.Drawing.Point(294, 0);
            this.tlpSessao.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSessao.Name = "tlpSessao";
            this.tlpSessao.RowCount = 2;
            this.tlpSessao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpSessao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSessao.Size = new System.Drawing.Size(577, 493);
            this.tlpSessao.TabIndex = 1;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(577, 50);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(244, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menus";
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 50);
            this.pnlConteudo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(577, 443);
            this.pnlConteudo.TabIndex = 1;
            // 
            // frm1Gerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 517);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm1Gerencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerência:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.mns1.ResumeLayout(false);
            this.mns1.PerformLayout();
            this.tlp2.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.tlpSessao.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.MenuStrip mns1;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnMenus;
        private System.Windows.Forms.TableLayoutPanel tlpSessao;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Button btnFormasDePagamento;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnFuncionarios;
    }
}