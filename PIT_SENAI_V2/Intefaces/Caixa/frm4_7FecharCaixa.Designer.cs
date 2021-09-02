
namespace PIT_SENAI_V2.Dados
{
    partial class frm4_7FecharCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4_7FecharCaixa));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSaldos = new System.Windows.Forms.DataGridView();
            this.tlpTotalContado = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalContado = new System.Windows.Forms.Label();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.tlpObs = new System.Windows.Forms.TableLayoutPanel();
            this.lblObs = new System.Windows.Forms.Label();
            this.txbObs = new System.Windows.Forms.TextBox();
            this.nudTotalContado = new System.Windows.Forms.NumericUpDown();
            this.tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldos)).BeginInit();
            this.tlpTotalContado.SuspendLayout();
            this.tlpObs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalContado)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.dgvSaldos, 0, 0);
            this.tlp1.Controls.Add(this.tlpTotalContado, 0, 1);
            this.tlp1.Controls.Add(this.btnFecharCaixa, 0, 3);
            this.tlp1.Controls.Add(this.tlpObs, 0, 2);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Margin = new System.Windows.Forms.Padding(0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 4;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.Size = new System.Drawing.Size(465, 458);
            this.tlp1.TabIndex = 0;
            // 
            // dgvSaldos
            // 
            this.dgvSaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaldos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaldos.Location = new System.Drawing.Point(0, 0);
            this.dgvSaldos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSaldos.Name = "dgvSaldos";
            this.dgvSaldos.Size = new System.Drawing.Size(465, 338);
            this.dgvSaldos.TabIndex = 0;
            // 
            // tlpTotalContado
            // 
            this.tlpTotalContado.ColumnCount = 2;
            this.tlpTotalContado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tlpTotalContado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalContado.Controls.Add(this.lblTotalContado, 0, 0);
            this.tlpTotalContado.Controls.Add(this.nudTotalContado, 1, 0);
            this.tlpTotalContado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTotalContado.Location = new System.Drawing.Point(0, 338);
            this.tlpTotalContado.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTotalContado.Name = "tlpTotalContado";
            this.tlpTotalContado.RowCount = 1;
            this.tlpTotalContado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTotalContado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTotalContado.Size = new System.Drawing.Size(465, 40);
            this.tlpTotalContado.TabIndex = 1;
            // 
            // lblTotalContado
            // 
            this.lblTotalContado.AutoSize = true;
            this.lblTotalContado.Location = new System.Drawing.Point(3, 5);
            this.lblTotalContado.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblTotalContado.Name = "lblTotalContado";
            this.lblTotalContado.Size = new System.Drawing.Size(219, 30);
            this.lblTotalContado.TabIndex = 0;
            this.lblTotalContado.Text = "Total Contado: R$";
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFecharCaixa.Location = new System.Drawing.Point(0, 418);
            this.btnFecharCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(465, 40);
            this.btnFecharCaixa.TabIndex = 2;
            this.btnFecharCaixa.Text = "Fechar Caixa";
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // tlpObs
            // 
            this.tlpObs.ColumnCount = 2;
            this.tlpObs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tlpObs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObs.Controls.Add(this.lblObs, 0, 0);
            this.tlpObs.Controls.Add(this.txbObs, 1, 0);
            this.tlpObs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpObs.Location = new System.Drawing.Point(0, 378);
            this.tlpObs.Margin = new System.Windows.Forms.Padding(0);
            this.tlpObs.Name = "tlpObs";
            this.tlpObs.RowCount = 1;
            this.tlpObs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObs.Size = new System.Drawing.Size(465, 40);
            this.tlpObs.TabIndex = 3;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(3, 5);
            this.lblObs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(155, 30);
            this.lblObs.TabIndex = 0;
            this.lblObs.Text = "Observação:";
            // 
            // txbObs
            // 
            this.txbObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbObs.Location = new System.Drawing.Point(163, 1);
            this.txbObs.Margin = new System.Windows.Forms.Padding(1);
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(301, 38);
            this.txbObs.TabIndex = 1;
            // 
            // nudTotalContado
            // 
            this.nudTotalContado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTotalContado.Location = new System.Drawing.Point(226, 1);
            this.nudTotalContado.Margin = new System.Windows.Forms.Padding(1);
            this.nudTotalContado.Name = "nudTotalContado";
            this.nudTotalContado.Size = new System.Drawing.Size(238, 38);
            this.nudTotalContado.TabIndex = 1;
            // 
            // frm4_7FecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 458);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm4_7FecharCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar Caixa";
            this.tlp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldos)).EndInit();
            this.tlpTotalContado.ResumeLayout(false);
            this.tlpTotalContado.PerformLayout();
            this.tlpObs.ResumeLayout(false);
            this.tlpObs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalContado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.DataGridView dgvSaldos;
        private System.Windows.Forms.TableLayoutPanel tlpTotalContado;
        private System.Windows.Forms.Label lblTotalContado;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.TableLayoutPanel tlpObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txbObs;
        private System.Windows.Forms.NumericUpDown nudTotalContado;
    }
}