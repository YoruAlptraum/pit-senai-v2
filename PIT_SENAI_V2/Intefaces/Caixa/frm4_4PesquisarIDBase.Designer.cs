
namespace PIT_SENAI_V2.Dados
{
    partial class frm4_4PesquisarID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4_4PesquisarID));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.tlpPesquisarID = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisarID = new System.Windows.Forms.Button();
            this.lblDoc = new System.Windows.Forms.Label();
            this.txbSelecionarID = new System.Windows.Forms.TextBox();
            this.tlp1.SuspendLayout();
            this.tlpPesquisarID.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.lblMensagem, 0, 1);
            this.tlp1.Controls.Add(this.tlpPesquisarID, 0, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Margin = new System.Windows.Forms.Padding(0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 3;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.Size = new System.Drawing.Size(484, 120);
            this.tlp1.TabIndex = 2;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(3, 48);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(195, 32);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Pesquisar ID";
            // 
            // tlpPesquisarID
            // 
            this.tlpPesquisarID.ColumnCount = 3;
            this.tlpPesquisarID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpPesquisarID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPesquisarID.Controls.Add(this.btnPesquisarID, 2, 0);
            this.tlpPesquisarID.Controls.Add(this.lblDoc, 0, 0);
            this.tlpPesquisarID.Controls.Add(this.txbSelecionarID, 1, 0);
            this.tlpPesquisarID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPesquisarID.Location = new System.Drawing.Point(0, 0);
            this.tlpPesquisarID.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPesquisarID.Name = "tlpPesquisarID";
            this.tlpPesquisarID.RowCount = 1;
            this.tlpPesquisarID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPesquisarID.Size = new System.Drawing.Size(484, 40);
            this.tlpPesquisarID.TabIndex = 1;
            // 
            // btnPesquisarID
            // 
            this.btnPesquisarID.BackgroundImage = global::PIT_SENAI_V2.Properties.Resources.Search;
            this.btnPesquisarID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarID.Location = new System.Drawing.Point(444, 0);
            this.btnPesquisarID.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarID.Name = "btnPesquisarID";
            this.btnPesquisarID.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisarID.TabIndex = 1;
            this.btnPesquisarID.UseVisualStyleBackColor = true;
            this.btnPesquisarID.Click += new System.EventHandler(this.btnPesquisarID_Click);
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.Location = new System.Drawing.Point(3, 3);
            this.lblDoc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(79, 34);
            this.lblDoc.TabIndex = 1;
            this.lblDoc.Text = "Doc:";
            // 
            // txbSelecionarID
            // 
            this.txbSelecionarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSelecionarID.Location = new System.Drawing.Point(86, 1);
            this.txbSelecionarID.Margin = new System.Windows.Forms.Padding(1);
            this.txbSelecionarID.Name = "txbSelecionarID";
            this.txbSelecionarID.Size = new System.Drawing.Size(357, 38);
            this.txbSelecionarID.TabIndex = 0;
            this.txbSelecionarID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSelecionarID_KeyDown);
            // 
            // frm4_4PesquisarID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 120);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 159);
            this.MinimumSize = new System.Drawing.Size(500, 159);
            this.Name = "frm4_4PesquisarID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar ID";
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.tlpPesquisarID.ResumeLayout(false);
            this.tlpPesquisarID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisarID;
        private System.Windows.Forms.Button btnPesquisarID;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txbSelecionarID;
    }
}