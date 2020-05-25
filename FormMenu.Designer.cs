namespace Sistema
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.BtnFormProdutos = new System.Windows.Forms.Button();
            this.BtnFormUsuarios = new System.Windows.Forms.Button();
            this.btnFormCategorias = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFormProdutos
            // 
            this.BtnFormProdutos.BackColor = System.Drawing.Color.Transparent;
            this.BtnFormProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFormProdutos.BackgroundImage")));
            this.BtnFormProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFormProdutos.Location = new System.Drawing.Point(203, 69);
            this.BtnFormProdutos.Name = "BtnFormProdutos";
            this.BtnFormProdutos.Size = new System.Drawing.Size(75, 82);
            this.BtnFormProdutos.TabIndex = 0;
            this.BtnFormProdutos.Text = "Produtos";
            this.BtnFormProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFormProdutos.UseVisualStyleBackColor = false;
            this.BtnFormProdutos.Click += new System.EventHandler(this.BtnFormProdutos_Click);
            // 
            // BtnFormUsuarios
            // 
            this.BtnFormUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BtnFormUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFormUsuarios.BackgroundImage")));
            this.BtnFormUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFormUsuarios.Location = new System.Drawing.Point(362, 69);
            this.BtnFormUsuarios.Name = "BtnFormUsuarios";
            this.BtnFormUsuarios.Size = new System.Drawing.Size(75, 82);
            this.BtnFormUsuarios.TabIndex = 1;
            this.BtnFormUsuarios.Text = "Usuarios";
            this.BtnFormUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFormUsuarios.UseVisualStyleBackColor = false;
            this.BtnFormUsuarios.Click += new System.EventHandler(this.BtnFormUsuarios_Click);
            // 
            // btnFormCategorias
            // 
            this.btnFormCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnFormCategorias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormCategorias.BackgroundImage")));
            this.btnFormCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormCategorias.Location = new System.Drawing.Point(48, 69);
            this.btnFormCategorias.Name = "btnFormCategorias";
            this.btnFormCategorias.Size = new System.Drawing.Size(75, 82);
            this.btnFormCategorias.TabIndex = 2;
            this.btnFormCategorias.Text = "Categorias";
            this.btnFormCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFormCategorias.UseVisualStyleBackColor = false;
            this.btnFormCategorias.Click += new System.EventHandler(this.btnFormCategorias_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnFormCategorias);
            this.Controls.Add(this.BtnFormUsuarios);
            this.Controls.Add(this.BtnFormProdutos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFormProdutos;
        private System.Windows.Forms.Button BtnFormUsuarios;
        private System.Windows.Forms.Button btnFormCategorias;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}

