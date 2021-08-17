
namespace Program.Views
{
    partial class Index
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(825, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.controleDeEstoqueToolStripMenuItem,
            this.gestãoDeProdutosToolStripMenuItem,
            this.gestãoDeEstoqueToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.novoToolStripMenuItem.Text = "Cadastro de Produto";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.controleDeEstoqueToolStripMenuItem.Text = "Cadastro de Estoque";
            this.controleDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.controleDeEstoqueToolStripMenuItem_Click);
            // 
            // gestãoDeProdutosToolStripMenuItem
            // 
            this.gestãoDeProdutosToolStripMenuItem.Name = "gestãoDeProdutosToolStripMenuItem";
            this.gestãoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestãoDeProdutosToolStripMenuItem.Text = "Gestão de Produtos";
            this.gestãoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProdutosToolStripMenuItem_Click);
            // 
            // gestãoDeEstoqueToolStripMenuItem
            // 
            this.gestãoDeEstoqueToolStripMenuItem.Name = "gestãoDeEstoqueToolStripMenuItem";
            this.gestãoDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestãoDeEstoqueToolStripMenuItem.Text = "Gestão de Estoque";
            this.gestãoDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeEstoqueToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 555);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(825, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(825, 577);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outlet Imports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeEstoqueToolStripMenuItem;
    }
}



