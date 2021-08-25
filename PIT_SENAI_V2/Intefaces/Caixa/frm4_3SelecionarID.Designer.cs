
namespace PIT_SENAI_V2.Dados
{
    partial class frm4_3SelecionarID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4_3SelecionarID));
            this.grpSelecionarID = new System.Windows.Forms.GroupBox();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbIDCliente = new System.Windows.Forms.TextBox();
            this.grpSelecionarID.SuspendLayout();
            this.tlp1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelecionarID
            // 
            this.grpSelecionarID.Controls.Add(this.tlp1);
            this.grpSelecionarID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSelecionarID.Location = new System.Drawing.Point(0, 0);
            this.grpSelecionarID.Name = "grpSelecionarID";
            this.grpSelecionarID.Size = new System.Drawing.Size(569, 157);
            this.grpSelecionarID.TabIndex = 0;
            this.grpSelecionarID.TabStop = false;
            this.grpSelecionarID.Text = "Selecionar ID:";
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.btnSelecionar, 0, 2);
            this.tlp1.Controls.Add(this.lblCliente, 0, 1);
            this.tlp1.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(3, 34);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 3;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.Size = new System.Drawing.Size(563, 120);
            this.tlp1.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelecionar.Location = new System.Drawing.Point(0, 80);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(563, 40);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 40);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(100, 31);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnPesquisar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbIDCliente, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 40);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisar.Location = new System.Drawing.Point(523, 0);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txbIDCliente
            // 
            this.txbIDCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbIDCliente.Location = new System.Drawing.Point(1, 1);
            this.txbIDCliente.Margin = new System.Windows.Forms.Padding(1);
            this.txbIDCliente.Name = "txbIDCliente";
            this.txbIDCliente.Size = new System.Drawing.Size(521, 38);
            this.txbIDCliente.TabIndex = 0;
            // 
            // frm4_3SelecionarID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 157);
            this.Controls.Add(this.grpSelecionarID);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(585, 196);
            this.MinimumSize = new System.Drawing.Size(585, 196);
            this.Name = "frm4_3SelecionarID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar ID";
            this.grpSelecionarID.ResumeLayout(false);
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelecionarID;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbIDCliente;
    }
}