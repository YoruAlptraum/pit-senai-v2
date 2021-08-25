
namespace PIT_SENAI_V2.Dados
{
    partial class frm4_6AbrirCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4_6AbrirCaixa));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpSaldoInicial = new System.Windows.Forms.GroupBox();
            this.txbSaldoInicial = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRS = new System.Windows.Forms.Label();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.tlp1.SuspendLayout();
            this.grpSaldoInicial.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.grpSaldoInicial, 0, 0);
            this.tlp1.Controls.Add(this.btnAbrirCaixa, 0, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Margin = new System.Windows.Forms.Padding(0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.Size = new System.Drawing.Size(439, 127);
            this.tlp1.TabIndex = 0;
            // 
            // grpSaldoInicial
            // 
            this.grpSaldoInicial.Controls.Add(this.tableLayoutPanel1);
            this.grpSaldoInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSaldoInicial.Location = new System.Drawing.Point(3, 3);
            this.grpSaldoInicial.Name = "grpSaldoInicial";
            this.grpSaldoInicial.Size = new System.Drawing.Size(433, 77);
            this.grpSaldoInicial.TabIndex = 0;
            this.grpSaldoInicial.TabStop = false;
            this.grpSaldoInicial.Text = "Informe o saldo inicial para o dia:";
            // 
            // txbSaldoInicial
            // 
            this.txbSaldoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSaldoInicial.Location = new System.Drawing.Point(51, 1);
            this.txbSaldoInicial.Margin = new System.Windows.Forms.Padding(1);
            this.txbSaldoInicial.Name = "txbSaldoInicial";
            this.txbSaldoInicial.Size = new System.Drawing.Size(375, 38);
            this.txbSaldoInicial.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txbSaldoInicial, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRS, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Location = new System.Drawing.Point(3, 5);
            this.lblRS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(44, 30);
            this.lblRS.TabIndex = 1;
            this.lblRS.Text = "R$";
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(0, 83);
            this.btnAbrirCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(439, 44);
            this.btnAbrirCaixa.TabIndex = 2;
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // frm4_6AbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 127);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "frm4_6AbrirCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Caixa";
            this.tlp1.ResumeLayout(false);
            this.grpSaldoInicial.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.GroupBox grpSaldoInicial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txbSaldoInicial;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Button btnAbrirCaixa;
    }
}