
namespace PIT_SENAI_V2.Dados
{
    partial class frm4_5Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4_5Historico));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tabHistoricos = new System.Windows.Forms.TabControl();
            this.tabMovCaixa = new System.Windows.Forms.TabPage();
            this.tlpMovCaixa = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPesquisarMovCaixa = new System.Windows.Forms.TableLayoutPanel();
            this.txbPesquisarMovCaixa = new System.Windows.Forms.TextBox();
            this.btnPesquisarMovCaixa = new System.Windows.Forms.Button();
            this.dgvMovCaixa = new System.Windows.Forms.DataGridView();
            this.tabNotas = new System.Windows.Forms.TabPage();
            this.tlpNotas = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPesquisarNotas = new System.Windows.Forms.TableLayoutPanel();
            this.txbPesquisarNotas = new System.Windows.Forms.TextBox();
            this.btnPesquisarNotas = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.tlp1.SuspendLayout();
            this.mns1.SuspendLayout();
            this.tabHistoricos.SuspendLayout();
            this.tabMovCaixa.SuspendLayout();
            this.tlpMovCaixa.SuspendLayout();
            this.tlpPesquisarMovCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovCaixa)).BeginInit();
            this.tabNotas.SuspendLayout();
            this.tlpNotas.SuspendLayout();
            this.tlpPesquisarNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.mns1, 0, 0);
            this.tlp1.Controls.Add(this.tabHistoricos, 0, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Margin = new System.Windows.Forms.Padding(0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.Size = new System.Drawing.Size(586, 515);
            this.tlp1.TabIndex = 2;
            // 
            // mns1
            // 
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Size = new System.Drawing.Size(586, 24);
            this.mns1.TabIndex = 8;
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
            this.tsmiMenu.Size = new System.Drawing.Size(170, 22);
            this.tsmiMenu.Text = "Menu";
            this.tsmiMenu.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiNota
            // 
            this.tsmiNota.Name = "tsmiNota";
            this.tsmiNota.Size = new System.Drawing.Size(170, 22);
            this.tsmiNota.Text = "Nota";
            this.tsmiNota.Click += new System.EventHandler(this.tsmiNota_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiCadastrar
            // 
            this.tsmiCadastrar.Name = "tsmiCadastrar";
            this.tsmiCadastrar.Size = new System.Drawing.Size(170, 22);
            this.tsmiCadastrar.Text = "Cadastrar";
            this.tsmiCadastrar.Click += new System.EventHandler(this.tsmiCadastrar_Click);
            // 
            // tsmiAtualizarCadastro
            // 
            this.tsmiAtualizarCadastro.Name = "tsmiAtualizarCadastro";
            this.tsmiAtualizarCadastro.Size = new System.Drawing.Size(170, 22);
            this.tsmiAtualizarCadastro.Text = "Atualizar Cadastro";
            this.tsmiAtualizarCadastro.Click += new System.EventHandler(this.tsmiAtualizarCadastro_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiPesquisarID
            // 
            this.tsmiPesquisarID.Name = "tsmiPesquisarID";
            this.tsmiPesquisarID.Size = new System.Drawing.Size(170, 22);
            this.tsmiPesquisarID.Text = "Pesquisar ID";
            this.tsmiPesquisarID.Click += new System.EventHandler(this.tsmiPesquisarID_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiHistorico
            // 
            this.tsmiHistorico.Name = "tsmiHistorico";
            this.tsmiHistorico.Size = new System.Drawing.Size(170, 22);
            this.tsmiHistorico.Text = "Histórico";
            this.tsmiHistorico.Click += new System.EventHandler(this.tsmiHistorico_Click);
            // 
            // tabHistoricos
            // 
            this.tabHistoricos.Controls.Add(this.tabMovCaixa);
            this.tabHistoricos.Controls.Add(this.tabNotas);
            this.tabHistoricos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHistoricos.Location = new System.Drawing.Point(3, 27);
            this.tabHistoricos.Name = "tabHistoricos";
            this.tabHistoricos.SelectedIndex = 0;
            this.tabHistoricos.Size = new System.Drawing.Size(580, 485);
            this.tabHistoricos.TabIndex = 3;
            // 
            // tabMovCaixa
            // 
            this.tabMovCaixa.Controls.Add(this.tlpMovCaixa);
            this.tabMovCaixa.Location = new System.Drawing.Point(4, 40);
            this.tabMovCaixa.Name = "tabMovCaixa";
            this.tabMovCaixa.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovCaixa.Size = new System.Drawing.Size(572, 441);
            this.tabMovCaixa.TabIndex = 0;
            this.tabMovCaixa.Text = "Mov. Caixa:";
            this.tabMovCaixa.UseVisualStyleBackColor = true;
            // 
            // tlpMovCaixa
            // 
            this.tlpMovCaixa.ColumnCount = 1;
            this.tlpMovCaixa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMovCaixa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMovCaixa.Controls.Add(this.tlpPesquisarMovCaixa, 0, 0);
            this.tlpMovCaixa.Controls.Add(this.dgvMovCaixa, 0, 1);
            this.tlpMovCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMovCaixa.Location = new System.Drawing.Point(3, 3);
            this.tlpMovCaixa.Name = "tlpMovCaixa";
            this.tlpMovCaixa.RowCount = 2;
            this.tlpMovCaixa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMovCaixa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMovCaixa.Size = new System.Drawing.Size(566, 435);
            this.tlpMovCaixa.TabIndex = 0;
            // 
            // tlpPesquisarMovCaixa
            // 
            this.tlpPesquisarMovCaixa.ColumnCount = 2;
            this.tlpPesquisarMovCaixa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarMovCaixa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPesquisarMovCaixa.Controls.Add(this.txbPesquisarMovCaixa, 0, 0);
            this.tlpPesquisarMovCaixa.Controls.Add(this.btnPesquisarMovCaixa, 1, 0);
            this.tlpPesquisarMovCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPesquisarMovCaixa.Location = new System.Drawing.Point(0, 0);
            this.tlpPesquisarMovCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisarMovCaixa.Name = "tlpPesquisarMovCaixa";
            this.tlpPesquisarMovCaixa.RowCount = 1;
            this.tlpPesquisarMovCaixa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarMovCaixa.Size = new System.Drawing.Size(566, 40);
            this.tlpPesquisarMovCaixa.TabIndex = 0;
            // 
            // txbPesquisarMovCaixa
            // 
            this.txbPesquisarMovCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarMovCaixa.Location = new System.Drawing.Point(1, 1);
            this.txbPesquisarMovCaixa.Margin = new System.Windows.Forms.Padding(1);
            this.txbPesquisarMovCaixa.Name = "txbPesquisarMovCaixa";
            this.txbPesquisarMovCaixa.Size = new System.Drawing.Size(524, 38);
            this.txbPesquisarMovCaixa.TabIndex = 0;
            this.txbPesquisarMovCaixa.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbPesquisarMovCaixa_PreviewKeyDown);
            // 
            // btnPesquisarMovCaixa
            // 
            this.btnPesquisarMovCaixa.BackgroundImage = global::PIT_SENAI_V2.Properties.Resources.Search;
            this.btnPesquisarMovCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarMovCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarMovCaixa.Location = new System.Drawing.Point(526, 0);
            this.btnPesquisarMovCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarMovCaixa.Name = "btnPesquisarMovCaixa";
            this.btnPesquisarMovCaixa.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisarMovCaixa.TabIndex = 1;
            this.btnPesquisarMovCaixa.UseVisualStyleBackColor = true;
            this.btnPesquisarMovCaixa.Click += new System.EventHandler(this.btnPesquisarMovCaixa_Click);
            // 
            // dgvMovCaixa
            // 
            this.dgvMovCaixa.AllowUserToAddRows = false;
            this.dgvMovCaixa.AllowUserToDeleteRows = false;
            this.dgvMovCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovCaixa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovCaixa.Location = new System.Drawing.Point(0, 40);
            this.dgvMovCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMovCaixa.Name = "dgvMovCaixa";
            this.dgvMovCaixa.ReadOnly = true;
            this.dgvMovCaixa.Size = new System.Drawing.Size(566, 395);
            this.dgvMovCaixa.TabIndex = 1;
            // 
            // tabNotas
            // 
            this.tabNotas.Controls.Add(this.tlpNotas);
            this.tabNotas.Location = new System.Drawing.Point(4, 40);
            this.tabNotas.Name = "tabNotas";
            this.tabNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotas.Size = new System.Drawing.Size(572, 441);
            this.tabNotas.TabIndex = 1;
            this.tabNotas.Text = "Notas:";
            this.tabNotas.UseVisualStyleBackColor = true;
            // 
            // tlpNotas
            // 
            this.tlpNotas.ColumnCount = 1;
            this.tlpNotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNotas.Controls.Add(this.tlpPesquisarNotas, 0, 0);
            this.tlpNotas.Controls.Add(this.dgvNotas, 0, 1);
            this.tlpNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNotas.Location = new System.Drawing.Point(3, 3);
            this.tlpNotas.Name = "tlpNotas";
            this.tlpNotas.RowCount = 2;
            this.tlpNotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpNotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNotas.Size = new System.Drawing.Size(566, 435);
            this.tlpNotas.TabIndex = 0;
            // 
            // tlpPesquisarNotas
            // 
            this.tlpPesquisarNotas.ColumnCount = 2;
            this.tlpPesquisarNotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarNotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPesquisarNotas.Controls.Add(this.txbPesquisarNotas, 0, 0);
            this.tlpPesquisarNotas.Controls.Add(this.btnPesquisarNotas, 1, 0);
            this.tlpPesquisarNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPesquisarNotas.Location = new System.Drawing.Point(0, 0);
            this.tlpPesquisarNotas.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisarNotas.Name = "tlpPesquisarNotas";
            this.tlpPesquisarNotas.RowCount = 1;
            this.tlpPesquisarNotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarNotas.Size = new System.Drawing.Size(566, 40);
            this.tlpPesquisarNotas.TabIndex = 1;
            // 
            // txbPesquisarNotas
            // 
            this.txbPesquisarNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisarNotas.Location = new System.Drawing.Point(1, 1);
            this.txbPesquisarNotas.Margin = new System.Windows.Forms.Padding(1);
            this.txbPesquisarNotas.Name = "txbPesquisarNotas";
            this.txbPesquisarNotas.Size = new System.Drawing.Size(524, 38);
            this.txbPesquisarNotas.TabIndex = 0;
            this.txbPesquisarNotas.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbPesquisarNotas_PreviewKeyDown);
            // 
            // btnPesquisarNotas
            // 
            this.btnPesquisarNotas.BackgroundImage = global::PIT_SENAI_V2.Properties.Resources.Search;
            this.btnPesquisarNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarNotas.Location = new System.Drawing.Point(526, 0);
            this.btnPesquisarNotas.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarNotas.Name = "btnPesquisarNotas";
            this.btnPesquisarNotas.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisarNotas.TabIndex = 1;
            this.btnPesquisarNotas.UseVisualStyleBackColor = true;
            this.btnPesquisarNotas.Click += new System.EventHandler(this.btnPesquisarNotas_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotas.Location = new System.Drawing.Point(3, 43);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(560, 389);
            this.dgvNotas.TabIndex = 2;
            // 
            // frm4_5Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 515);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm4_5Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Históricos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.mns1.ResumeLayout(false);
            this.mns1.PerformLayout();
            this.tabHistoricos.ResumeLayout(false);
            this.tabMovCaixa.ResumeLayout(false);
            this.tlpMovCaixa.ResumeLayout(false);
            this.tlpPesquisarMovCaixa.ResumeLayout(false);
            this.tlpPesquisarMovCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovCaixa)).EndInit();
            this.tabNotas.ResumeLayout(false);
            this.tlpNotas.ResumeLayout(false);
            this.tlpPesquisarNotas.ResumeLayout(false);
            this.tlpPesquisarNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TabControl tabHistoricos;
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
        private System.Windows.Forms.TabPage tabMovCaixa;
        private System.Windows.Forms.TableLayoutPanel tlpMovCaixa;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarMovCaixa;
        private System.Windows.Forms.TextBox txbPesquisarMovCaixa;
        private System.Windows.Forms.Button btnPesquisarMovCaixa;
        private System.Windows.Forms.DataGridView dgvMovCaixa;
        private System.Windows.Forms.TabPage tabNotas;
        private System.Windows.Forms.TableLayoutPanel tlpNotas;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarNotas;
        private System.Windows.Forms.TextBox txbPesquisarNotas;
        private System.Windows.Forms.Button btnPesquisarNotas;
        private System.Windows.Forms.DataGridView dgvNotas;
    }
}