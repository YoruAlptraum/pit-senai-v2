
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
            this.tabHistoricos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabHistoricos.SuspendLayout();
            this.mns1.SuspendLayout();
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
            this.tlp1.Size = new System.Drawing.Size(484, 461);
            this.tlp1.TabIndex = 2;
            // 
            // tabHistoricos
            // 
            this.tabHistoricos.Controls.Add(this.tabPage1);
            this.tabHistoricos.Controls.Add(this.tabPage2);
            this.tabHistoricos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHistoricos.Location = new System.Drawing.Point(3, 27);
            this.tabHistoricos.Name = "tabHistoricos";
            this.tabHistoricos.SelectedIndex = 0;
            this.tabHistoricos.Size = new System.Drawing.Size(478, 431);
            this.tabHistoricos.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mns1
            // 
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Size = new System.Drawing.Size(484, 24);
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
            // frm4_5Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
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
            this.tabHistoricos.ResumeLayout(false);
            this.mns1.ResumeLayout(false);
            this.mns1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TabControl tabHistoricos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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