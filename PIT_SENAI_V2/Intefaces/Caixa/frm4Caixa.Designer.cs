
namespace PIT_SENAI_V2.Dados
{
    partial class frm4Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4Caixa));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisarID = new System.Windows.Forms.Button();
            this.btnNota = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizarCadastro = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.dgvMovimentoDeCaixa = new System.Windows.Forms.DataGridView();
            this.mns1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiNota = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAtualizarCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPesquisarID = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbrirCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFecharCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp1.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentoDeCaixa)).BeginInit();
            this.mns1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.Controls.Add(this.tlp2, 0, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Size = new System.Drawing.Size(816, 664);
            this.tlp1.TabIndex = 0;
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp2.Controls.Add(this.panel1, 0, 0);
            this.tlp2.Controls.Add(this.dgvMovimentoDeCaixa, 1, 0);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(3, 27);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Size = new System.Drawing.Size(810, 634);
            this.tlp2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpBotoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 634);
            this.panel1.TabIndex = 0;
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotoes.ColumnCount = 1;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotoes.Controls.Add(this.btnPesquisarID, 0, 3);
            this.tlpBotoes.Controls.Add(this.btnNota, 0, 0);
            this.tlpBotoes.Controls.Add(this.btnCadastrar, 0, 1);
            this.tlpBotoes.Controls.Add(this.btnAtualizarCadastro, 0, 2);
            this.tlpBotoes.Controls.Add(this.btnHistorico, 0, 4);
            this.tlpBotoes.Controls.Add(this.btnFecharCaixa, 0, 6);
            this.tlpBotoes.Controls.Add(this.btnAbrirCaixa, 0, 5);
            this.tlpBotoes.Location = new System.Drawing.Point(19, 7);
            this.tlpBotoes.Margin = new System.Windows.Forms.Padding(10);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 7;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBotoes.Size = new System.Drawing.Size(457, 611);
            this.tlpBotoes.TabIndex = 0;
            // 
            // btnPesquisarID
            // 
            this.btnPesquisarID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarID.Location = new System.Drawing.Point(25, 286);
            this.btnPesquisarID.Margin = new System.Windows.Forms.Padding(25);
            this.btnPesquisarID.Name = "btnPesquisarID";
            this.btnPesquisarID.Size = new System.Drawing.Size(407, 37);
            this.btnPesquisarID.TabIndex = 3;
            this.btnPesquisarID.Text = "Pesquisar ID";
            this.btnPesquisarID.UseVisualStyleBackColor = true;
            this.btnPesquisarID.Click += new System.EventHandler(this.btnPesquisarID_Click);
            // 
            // btnNota
            // 
            this.btnNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNota.Location = new System.Drawing.Point(25, 25);
            this.btnNota.Margin = new System.Windows.Forms.Padding(25);
            this.btnNota.Name = "btnNota";
            this.btnNota.Size = new System.Drawing.Size(407, 37);
            this.btnNota.TabIndex = 0;
            this.btnNota.Text = "Nota";
            this.btnNota.UseVisualStyleBackColor = true;
            this.btnNota.Click += new System.EventHandler(this.btnNota_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(25, 112);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(25);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(407, 37);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAtualizarCadastro
            // 
            this.btnAtualizarCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAtualizarCadastro.Location = new System.Drawing.Point(25, 199);
            this.btnAtualizarCadastro.Margin = new System.Windows.Forms.Padding(25);
            this.btnAtualizarCadastro.Name = "btnAtualizarCadastro";
            this.btnAtualizarCadastro.Size = new System.Drawing.Size(407, 37);
            this.btnAtualizarCadastro.TabIndex = 2;
            this.btnAtualizarCadastro.Text = "Atualizar Cadastro";
            this.btnAtualizarCadastro.UseVisualStyleBackColor = true;
            this.btnAtualizarCadastro.Click += new System.EventHandler(this.btnAtualizarCadastro_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistorico.Location = new System.Drawing.Point(25, 373);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(25);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(407, 37);
            this.btnHistorico.TabIndex = 4;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFecharCaixa.Location = new System.Drawing.Point(25, 547);
            this.btnFecharCaixa.Margin = new System.Windows.Forms.Padding(25);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(407, 39);
            this.btnFecharCaixa.TabIndex = 6;
            this.btnFecharCaixa.Text = "Fechar Caixa";
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(25, 460);
            this.btnAbrirCaixa.Margin = new System.Windows.Forms.Padding(25);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(407, 37);
            this.btnAbrirCaixa.TabIndex = 5;
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // dgvMovimentoDeCaixa
            // 
            this.dgvMovimentoDeCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimentoDeCaixa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovimentoDeCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimentoDeCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimentoDeCaixa.Location = new System.Drawing.Point(486, 0);
            this.dgvMovimentoDeCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMovimentoDeCaixa.MultiSelect = false;
            this.dgvMovimentoDeCaixa.Name = "dgvMovimentoDeCaixa";
            this.dgvMovimentoDeCaixa.ReadOnly = true;
            this.dgvMovimentoDeCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimentoDeCaixa.Size = new System.Drawing.Size(324, 634);
            this.dgvMovimentoDeCaixa.TabIndex = 1;
            // 
            // mns1
            // 
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSair,
            this.tsmiCaixa});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Size = new System.Drawing.Size(816, 24);
            this.mns1.TabIndex = 4;
            this.mns1.Text = "Menu";
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "Sair";
            this.tsmiSair.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // tsmiCaixa
            // 
            this.tsmiCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem5,
            this.tsmiNota,
            this.toolStripMenuItem1,
            this.tsmiCadastrar,
            this.tsmiAtualizarCadastro,
            this.toolStripMenuItem4,
            this.tsmiPesquisarID,
            this.toolStripMenuItem3,
            this.tsmiHistorico,
            this.toolStripMenuItem2,
            this.tsmiAbrirCaixa,
            this.tsmiFecharCaixa});
            this.tsmiCaixa.Name = "tsmiCaixa";
            this.tsmiCaixa.Size = new System.Drawing.Size(48, 20);
            this.tsmiCaixa.Text = "Caixa";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiNota
            // 
            this.tsmiNota.Name = "tsmiNota";
            this.tsmiNota.Size = new System.Drawing.Size(170, 22);
            this.tsmiNota.Text = "Nota";
            this.tsmiNota.Click += new System.EventHandler(this.tsmiNota_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
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
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiPesquisarID
            // 
            this.tsmiPesquisarID.Name = "tsmiPesquisarID";
            this.tsmiPesquisarID.Size = new System.Drawing.Size(170, 22);
            this.tsmiPesquisarID.Text = "Pesquisar ID";
            this.tsmiPesquisarID.Click += new System.EventHandler(this.tsmiPesquisarID_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiHistorico
            // 
            this.tsmiHistorico.Name = "tsmiHistorico";
            this.tsmiHistorico.Size = new System.Drawing.Size(170, 22);
            this.tsmiHistorico.Text = "Histórico";
            this.tsmiHistorico.Click += new System.EventHandler(this.tsmiHistorico_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiAbrirCaixa
            // 
            this.tsmiAbrirCaixa.Name = "tsmiAbrirCaixa";
            this.tsmiAbrirCaixa.Size = new System.Drawing.Size(170, 22);
            this.tsmiAbrirCaixa.Text = "Abrir Caixa";
            this.tsmiAbrirCaixa.Click += new System.EventHandler(this.tsmiAbrirCaixa_Click);
            // 
            // tsmiFecharCaixa
            // 
            this.tsmiFecharCaixa.Name = "tsmiFecharCaixa";
            this.tsmiFecharCaixa.Size = new System.Drawing.Size(170, 22);
            this.tsmiFecharCaixa.Text = "Fechar Caixa";
            this.tsmiFecharCaixa.Click += new System.EventHandler(this.tsmiFecharCaixa_Click);
            // 
            // frm4Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 664);
            this.Controls.Add(this.mns1);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm4Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlpBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentoDeCaixa)).EndInit();
            this.mns1.ResumeLayout(false);
            this.mns1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private System.Windows.Forms.Button btnPesquisarID;
        private System.Windows.Forms.Button btnNota;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizarCadastro;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.DataGridView dgvMovimentoDeCaixa;
        private System.Windows.Forms.MenuStrip mns1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripMenuItem tsmiCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmiNota;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiAtualizarCadastro;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiPesquisarID;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistorico;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbrirCaixa;
        private System.Windows.Forms.ToolStripMenuItem tsmiFecharCaixa;
    }
}