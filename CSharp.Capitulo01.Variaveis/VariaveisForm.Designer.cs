
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariaveisForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementaisDecrementaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booleanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.ternariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(815, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritmeticasToolStripMenuItem,
            this.reduzidasToolStripMenuItem,
            this.incrementaisDecrementaisToolStripMenuItem,
            this.booleanasToolStripMenuItem,
            this.logicaToolStripMenuItem,
            this.ternariasToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("operaçõesToolStripMenuItem.Image")));
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // aritmeticasToolStripMenuItem
            // 
            this.aritmeticasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aritmeticasToolStripMenuItem.Image")));
            this.aritmeticasToolStripMenuItem.Name = "aritmeticasToolStripMenuItem";
            this.aritmeticasToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.aritmeticasToolStripMenuItem.Text = "Aritmeticas";
            this.aritmeticasToolStripMenuItem.Click += new System.EventHandler(this.aritméticasToolStripMenuItem_Click);
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reduzidasToolStripMenuItem.Image")));
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.reduzidasToolStripMenuItem.Text = "Reduzidas";
            this.reduzidasToolStripMenuItem.Click += new System.EventHandler(this.reduzidasToolStripMenuItem_Click);
            // 
            // incrementaisDecrementaisToolStripMenuItem
            // 
            this.incrementaisDecrementaisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incrementaisDecrementaisToolStripMenuItem.Image")));
            this.incrementaisDecrementaisToolStripMenuItem.Name = "incrementaisDecrementaisToolStripMenuItem";
            this.incrementaisDecrementaisToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.incrementaisDecrementaisToolStripMenuItem.Text = "Incrementais/Decrementais";
            this.incrementaisDecrementaisToolStripMenuItem.Click += new System.EventHandler(this.incrementaisDecrementaisToolStripMenuItem_Click);
            // 
            // booleanasToolStripMenuItem
            // 
            this.booleanasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booleanasToolStripMenuItem.Image")));
            this.booleanasToolStripMenuItem.Name = "booleanasToolStripMenuItem";
            this.booleanasToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.booleanasToolStripMenuItem.Text = "Booleanas";
            this.booleanasToolStripMenuItem.Click += new System.EventHandler(this.booleanasToolStripMenuItem_Click);
            // 
            // logicaToolStripMenuItem
            // 
            this.logicaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logicaToolStripMenuItem.Image")));
            this.logicaToolStripMenuItem.Name = "logicaToolStripMenuItem";
            this.logicaToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.logicaToolStripMenuItem.Text = "Lógica";
            this.logicaToolStripMenuItem.Click += new System.EventHandler(this.logicaToolStripMenuItem_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(9, 25);
            this.resultadoListBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(769, 524);
            this.resultadoListBox.TabIndex = 1;
            // 
            // ternariasToolStripMenuItem
            // 
            this.ternariasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ternariasToolStripMenuItem.Image")));
            this.ternariasToolStripMenuItem.Name = "ternariasToolStripMenuItem";
            this.ternariasToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.ternariasToolStripMenuItem.Text = "Ternárias";
            this.ternariasToolStripMenuItem.Click += new System.EventHandler(this.ternariasToolStripMenuItem_Click);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 557);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementaisDecrementaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booleanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternariasToolStripMenuItem;
    }
}

