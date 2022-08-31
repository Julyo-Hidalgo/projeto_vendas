namespace projeto_dgv
{
    partial class main_form
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
            this.dgv_venda = new System.Windows.Forms.DataGridView();
            this.btn_importar = new System.Windows.Forms.Button();
            this.ofd_arquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_venda
            // 
            this.dgv_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venda.Location = new System.Drawing.Point(237, 182);
            this.dgv_venda.Name = "dgv_venda";
            this.dgv_venda.Size = new System.Drawing.Size(743, 345);
            this.dgv_venda.TabIndex = 0;
            // 
            // btn_importar
            // 
            this.btn_importar.Location = new System.Drawing.Point(905, 56);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(75, 23);
            this.btn_importar.TabIndex = 1;
            this.btn_importar.Text = "button1";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // ofd_arquivo
            // 
            this.ofd_arquivo.FileName = "openFileDialog1";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 674);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.dgv_venda);
            this.Name = "main_form";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_venda;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.OpenFileDialog ofd_arquivo;
    }
}

