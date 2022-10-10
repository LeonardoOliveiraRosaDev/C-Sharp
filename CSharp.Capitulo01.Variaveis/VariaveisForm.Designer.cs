
namespace CSharp.Capitulo01.Variaveis
{
    partial class VariaveisForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritmeticasToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // aritmeticasToolStripMenuItem
            // 
            this.aritmeticasToolStripMenuItem.Name = "aritmeticasToolStripMenuItem";
            this.aritmeticasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aritmeticasToolStripMenuItem.Text = "Aritmeticas";
            this.aritmeticasToolStripMenuItem.Click += new System.EventHandler(this.aritméticasToolStripMenuItem_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.ItemHeight = 16;
            this.resultadoListBox.Location = new System.Drawing.Point(12, 31);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(1024, 644);
            this.resultadoListBox.TabIndex = 1;
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 686);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VariaveisForm";
            this.Text = "Variáveis e Operações";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticasToolStripMenuItem;
        private System.Windows.Forms.ListBox resultadoListBox;
    }
}

