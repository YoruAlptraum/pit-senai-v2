
namespace PIT_SENAI_V2.Dados
{
    partial class frm1Gerencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1Gerencia));
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.mns1 = new System.Windows.Forms.MenuStrip();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp1.SuspendLayout();
            this.mns1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.mns1, 0, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Size = new System.Drawing.Size(871, 517);
            this.tlp1.TabIndex = 3;
            // 
            // mns1
            // 
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Size = new System.Drawing.Size(871, 24);
            this.mns1.TabIndex = 3;
            this.mns1.Text = "Menu";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.logOffToolStripMenuItem.Text = "Sair";
            // 
            // frm1Gerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 517);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm1Gerencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerência:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.mns1.ResumeLayout(false);
            this.mns1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.MenuStrip mns1;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
    }
}