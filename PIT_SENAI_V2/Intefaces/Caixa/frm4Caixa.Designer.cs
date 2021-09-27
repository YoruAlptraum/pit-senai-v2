
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
            this.mns1 = new System.Windows.Forms.MenuStrip();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.tlpSessao = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnPesquisarID = new System.Windows.Forms.Button();
            this.btnAtualizarCadastro = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNota = new System.Windows.Forms.Button();
            this.btnMenus = new System.Windows.Forms.Button();
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
            this.tlp1.Size = new System.Drawing.Size(1000, 580);
            this.tlp1.TabIndex = 4;
            // 
            // mns1
            // 
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Size = new System.Drawing.Size(1000, 24);
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
            this.tlp2.Size = new System.Drawing.Size(1000, 556);
            this.tlp2.TabIndex = 4;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.AutoScroll = true;
            this.pnlBotoes.Controls.Add(this.btnFecharCaixa);
            this.pnlBotoes.Controls.Add(this.btnAbrirCaixa);
            this.pnlBotoes.Controls.Add(this.btnHistorico);
            this.pnlBotoes.Controls.Add(this.btnPesquisarID);
            this.pnlBotoes.Controls.Add(this.btnAtualizarCadastro);
            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Controls.Add(this.btnNota);
            this.pnlBotoes.Controls.Add(this.btnMenus);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(337, 556);
            this.pnlBotoes.TabIndex = 0;
            // 
            // tlpSessao
            // 
            this.tlpSessao.ColumnCount = 1;
            this.tlpSessao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSessao.Controls.Add(this.pnlTitulo, 0, 0);
            this.tlpSessao.Controls.Add(this.pnlConteudo, 0, 1);
            this.tlpSessao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSessao.Location = new System.Drawing.Point(337, 0);
            this.tlpSessao.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSessao.Name = "tlpSessao";
            this.tlpSessao.RowCount = 2;
            this.tlpSessao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpSessao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSessao.Size = new System.Drawing.Size(663, 556);
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
            this.pnlTitulo.Size = new System.Drawing.Size(663, 50);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(287, 10);
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
            this.pnlConteudo.Size = new System.Drawing.Size(663, 506);
            this.pnlConteudo.TabIndex = 1;
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFecharCaixa.Image = global::PIT_SENAI_V2.Properties.Resources.Fechar_Caixa;
            this.btnFecharCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharCaixa.Location = new System.Drawing.Point(0, 350);
            this.btnFecharCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(337, 70);
            this.btnFecharCaixa.TabIndex = 7;
            this.btnFecharCaixa.Text = "Fechar Caixa";
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirCaixa.Image = global::PIT_SENAI_V2.Properties.Resources.Abrir_Caixa;
            this.btnAbrirCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(0, 300);
            this.btnAbrirCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(337, 50);
            this.btnAbrirCaixa.TabIndex = 6;
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorico.Image = global::PIT_SENAI_V2.Properties.Resources.Historico;
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(0, 250);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(337, 50);
            this.btnHistorico.TabIndex = 5;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnPesquisarID
            // 
            this.btnPesquisarID.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisarID.Image = global::PIT_SENAI_V2.Properties.Resources.Pesquisar_ID;
            this.btnPesquisarID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarID.Location = new System.Drawing.Point(0, 200);
            this.btnPesquisarID.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarID.Name = "btnPesquisarID";
            this.btnPesquisarID.Size = new System.Drawing.Size(337, 50);
            this.btnPesquisarID.TabIndex = 4;
            this.btnPesquisarID.Text = "Pesquisar ID";
            this.btnPesquisarID.UseVisualStyleBackColor = true;
            this.btnPesquisarID.Click += new System.EventHandler(this.btnPesquisarID_Click);
            // 
            // btnAtualizarCadastro
            // 
            this.btnAtualizarCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizarCadastro.Image = global::PIT_SENAI_V2.Properties.Resources.Atualizar_Cadastro;
            this.btnAtualizarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarCadastro.Location = new System.Drawing.Point(0, 150);
            this.btnAtualizarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtualizarCadastro.Name = "btnAtualizarCadastro";
            this.btnAtualizarCadastro.Size = new System.Drawing.Size(337, 50);
            this.btnAtualizarCadastro.TabIndex = 3;
            this.btnAtualizarCadastro.Text = "Atualizar Cadastro";
            this.btnAtualizarCadastro.UseVisualStyleBackColor = true;
            this.btnAtualizarCadastro.Click += new System.EventHandler(this.btnAtualizarCadastro_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrar.Image = global::PIT_SENAI_V2.Properties.Resources.Cadastrar;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 100);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(337, 50);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNota
            // 
            this.btnNota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNota.Image = global::PIT_SENAI_V2.Properties.Resources.notas;
            this.btnNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNota.Location = new System.Drawing.Point(0, 50);
            this.btnNota.Margin = new System.Windows.Forms.Padding(0);
            this.btnNota.Name = "btnNota";
            this.btnNota.Size = new System.Drawing.Size(337, 50);
            this.btnNota.TabIndex = 1;
            this.btnNota.Text = "Nota";
            this.btnNota.UseVisualStyleBackColor = true;
            this.btnNota.Click += new System.EventHandler(this.btnNota_Click);
            // 
            // btnMenus
            // 
            this.btnMenus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenus.Image = global::PIT_SENAI_V2.Properties.Resources.Menus;
            this.btnMenus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenus.Location = new System.Drawing.Point(0, 0);
            this.btnMenus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(337, 50);
            this.btnMenus.TabIndex = 0;
            this.btnMenus.Text = "Menus";
            this.btnMenus.UseVisualStyleBackColor = true;
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            // 
            // frm4Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm4Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
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
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnPesquisarID;
        private System.Windows.Forms.Button btnAtualizarCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNota;
        private System.Windows.Forms.Button btnMenus;
        private System.Windows.Forms.TableLayoutPanel tlpSessao;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlConteudo;
    }
}