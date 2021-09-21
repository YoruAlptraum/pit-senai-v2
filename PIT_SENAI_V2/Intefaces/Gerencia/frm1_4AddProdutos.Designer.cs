
namespace PIT_SENAI_V2.Dados
{
    partial class frm1_4AddProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1_4AddProdutos));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudEstoqueMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAtivo = new System.Windows.Forms.ComboBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.tlp1.SuspendLayout();
            this.tlp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.Controls.Add(this.btnConfirmar, 0, 1);
            this.tlp1.Controls.Add(this.tlp2, 0, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.Size = new System.Drawing.Size(574, 280);
            this.tlp1.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmar.Location = new System.Drawing.Point(0, 240);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(574, 40);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.13937F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.86063F));
            this.tlp2.Controls.Add(this.nudEstoqueMin, 1, 2);
            this.tlp2.Controls.Add(this.label1, 0, 0);
            this.tlp2.Controls.Add(this.cmbAtivo, 1, 5);
            this.tlp2.Controls.Add(this.lblAtivo, 0, 5);
            this.tlp2.Controls.Add(this.label2, 0, 1);
            this.tlp2.Controls.Add(this.label3, 0, 2);
            this.tlp2.Controls.Add(this.label4, 0, 3);
            this.tlp2.Controls.Add(this.label5, 0, 4);
            this.tlp2.Controls.Add(this.cmbFornecedor, 1, 4);
            this.tlp2.Controls.Add(this.cmbCategoria, 1, 3);
            this.tlp2.Controls.Add(this.txbProduto, 1, 0);
            this.tlp2.Controls.Add(this.nudPreco, 1, 1);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(0, 0);
            this.tlp2.Margin = new System.Windows.Forms.Padding(0);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 6;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp2.Size = new System.Drawing.Size(574, 240);
            this.tlp2.TabIndex = 1;
            // 
            // nudEstoqueMin
            // 
            this.nudEstoqueMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudEstoqueMin.Location = new System.Drawing.Point(173, 81);
            this.nudEstoqueMin.Margin = new System.Windows.Forms.Padding(1);
            this.nudEstoqueMin.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudEstoqueMin.Name = "nudEstoqueMin";
            this.nudEstoqueMin.Size = new System.Drawing.Size(400, 38);
            this.nudEstoqueMin.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Produto:";
            // 
            // cmbAtivo
            // 
            this.cmbAtivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtivo.FormattingEnabled = true;
            this.cmbAtivo.Location = new System.Drawing.Point(173, 201);
            this.cmbAtivo.Margin = new System.Windows.Forms.Padding(1);
            this.cmbAtivo.Name = "cmbAtivo";
            this.cmbAtivo.Size = new System.Drawing.Size(400, 39);
            this.cmbAtivo.TabIndex = 6;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(3, 205);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(91, 30);
            this.lblAtivo.TabIndex = 20;
            this.lblAtivo.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Estoque Min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fornecedor:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(173, 161);
            this.cmbFornecedor.Margin = new System.Windows.Forms.Padding(1);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(400, 39);
            this.cmbFornecedor.TabIndex = 5;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(173, 121);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(1);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(400, 39);
            this.cmbCategoria.TabIndex = 4;
            // 
            // txbProduto
            // 
            this.txbProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProduto.Location = new System.Drawing.Point(173, 1);
            this.txbProduto.Margin = new System.Windows.Forms.Padding(1);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(400, 38);
            this.txbProduto.TabIndex = 1;
            // 
            // nudPreco
            // 
            this.nudPreco.DecimalPlaces = 2;
            this.nudPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPreco.Location = new System.Drawing.Point(173, 41);
            this.nudPreco.Margin = new System.Windows.Forms.Padding(1);
            this.nudPreco.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(400, 38);
            this.nudPreco.TabIndex = 26;
            // 
            // frm1_4AddProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 280);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm1_4AddProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.tlp1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.tlp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.ComboBox cmbAtivo;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.NumericUpDown nudEstoqueMin;
    }
}