namespace sistema
{
    partial class frm_menu
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
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_produto = new System.Windows.Forms.Button();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.cadastrosToolStripMenuItem.Text = "cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.produtosToolStripMenuItem.Text = "produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.categoriasToolStripMenuItem.Text = "categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // btn_cad_produto
            // 
            this.btn_cad_produto.BackColor = System.Drawing.Color.White;
            this.btn_cad_produto.BackgroundImage = global::sistema.Properties.Resources._4033771702;
            this.btn_cad_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cad_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_produto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cad_produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cad_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_produto.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_produto.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cad_produto.Image = global::sistema.Properties.Resources.papel_de_parede_do_símbolo_infinito_da_trilha_luminosa_191817397;
            this.btn_cad_produto.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_cad_produto.Location = new System.Drawing.Point(86, 113);
            this.btn_cad_produto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cad_produto.Name = "btn_cad_produto";
            this.btn_cad_produto.Size = new System.Drawing.Size(118, 64);
            this.btn_cad_produto.TabIndex = 2;
            this.btn_cad_produto.Text = "cadastrar produtos";
            this.btn_cad_produto.UseVisualStyleBackColor = false;
            this.btn_cad_produto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cad_categorias
            // 
            this.btn_cad_categorias.BackColor = System.Drawing.Color.White;
            this.btn_cad_categorias.BackgroundImage = global::sistema.Properties.Resources._4033771702;
            this.btn_cad_categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cad_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_categorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cad_categorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cad_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_categorias.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_categorias.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.Image = global::sistema.Properties.Resources.papel_de_parede_do_símbolo_infinito_da_trilha_luminosa_191817397;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_cad_categorias.Location = new System.Drawing.Point(227, 113);
            this.btn_cad_categorias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(133, 64);
            this.btn_cad_categorias.TabIndex = 3;
            this.btn_cad_categorias.Text = "cadastrar categorias";
            this.btn_cad_categorias.UseVisualStyleBackColor = false;
            this.btn_cad_categorias.Click += new System.EventHandler(this.btn_cad_categorias_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::sistema.Properties.Resources._1000_F_376018649_bNk7V1AOOz1R1blKbcTH6Mh16ix9c3w41;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btn_cad_produto);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_produto;
        private System.Windows.Forms.Button btn_cad_categorias;
    }
}

