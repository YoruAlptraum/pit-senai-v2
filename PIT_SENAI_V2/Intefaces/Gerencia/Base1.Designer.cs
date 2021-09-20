
namespace PIT_SENAI_V2.Dados
{
    partial class Base1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base1));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.tlpPesquisa = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tlp1.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            this.tlpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.tlpBotoes, 0, 2);
            this.tlp1.Controls.Add(this.tlpPesquisa, 0, 0);
            this.tlp1.Controls.Add(this.dgv, 0, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Margin = new System.Windows.Forms.Padding(0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 3;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.Size = new System.Drawing.Size(658, 413);
            this.tlp1.TabIndex = 0;
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.ColumnCount = 3;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.Controls.Add(this.btnAtualizar, 0, 0);
            this.tlpBotoes.Controls.Add(this.btnAdicionar, 0, 0);
            this.tlpBotoes.Controls.Add(this.btnRemover, 2, 0);
            this.tlpBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotoes.Location = new System.Drawing.Point(0, 373);
            this.tlpBotoes.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotoes.Size = new System.Drawing.Size(658, 40);
            this.tlpBotoes.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAtualizar.Location = new System.Drawing.Point(219, 0);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(219, 40);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 0);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(219, 40);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemover.Location = new System.Drawing.Point(438, 0);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(220, 40);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // tlpPesquisa
            // 
            this.tlpPesquisa.ColumnCount = 2;
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPesquisa.Controls.Add(this.btnPesquisar, 1, 0);
            this.tlpPesquisa.Controls.Add(this.txbPesquisa, 0, 0);
            this.tlpPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPesquisa.Location = new System.Drawing.Point(0, 0);
            this.tlpPesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisa.Name = "tlpPesquisa";
            this.tlpPesquisa.RowCount = 1;
            this.tlpPesquisa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisa.Size = new System.Drawing.Size(658, 40);
            this.tlpPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::PIT_SENAI_V2.Properties.Resources.Search;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisar.Location = new System.Drawing.Point(618, 0);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPesquisa.Location = new System.Drawing.Point(1, 1);
            this.txbPesquisa.Margin = new System.Windows.Forms.Padding(1);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(616, 38);
            this.txbPesquisa.TabIndex = 1;
            this.txbPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPesquisa_KeyDown);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 43);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(652, 327);
            this.dgv.TabIndex = 2;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // frm1_2Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm1_2Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm1_KeyDown);
            this.tlp1.ResumeLayout(false);
            this.tlpBotoes.ResumeLayout(false);
            this.tlpPesquisa.ResumeLayout(false);
            this.tlpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAdicionar;
    }
}