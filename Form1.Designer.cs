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
            this.btn_marcar = new System.Windows.Forms.Button();
            this.btn_desmarcar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_aumento_porcentagem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_porcentagem = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_porcentagem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_venda
            // 
            this.dgv_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venda.Location = new System.Drawing.Point(22, 215);
            this.dgv_venda.Name = "dgv_venda";
            this.dgv_venda.Size = new System.Drawing.Size(982, 394);
            this.dgv_venda.TabIndex = 0;
            this.dgv_venda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_venda_CellClick);
            // 
            // btn_importar
            // 
            this.btn_importar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_importar.BackColor = System.Drawing.Color.Silver;
            this.btn_importar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importar.ForeColor = System.Drawing.Color.White;
            this.btn_importar.Location = new System.Drawing.Point(413, 96);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(126, 44);
            this.btn_importar.TabIndex = 1;
            this.btn_importar.Text = "importar";
            this.btn_importar.UseVisualStyleBackColor = false;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // ofd_arquivo
            // 
            this.ofd_arquivo.FileName = "openFileDialog1";
            // 
            // btn_marcar
            // 
            this.btn_marcar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_marcar.BackColor = System.Drawing.Color.Silver;
            this.btn_marcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcar.ForeColor = System.Drawing.Color.White;
            this.btn_marcar.Location = new System.Drawing.Point(276, 96);
            this.btn_marcar.Name = "btn_marcar";
            this.btn_marcar.Size = new System.Drawing.Size(131, 44);
            this.btn_marcar.TabIndex = 2;
            this.btn_marcar.Text = "marcar tudo";
            this.btn_marcar.UseVisualStyleBackColor = false;
            this.btn_marcar.Click += new System.EventHandler(this.btn_marcar_Click);
            // 
            // btn_desmarcar
            // 
            this.btn_desmarcar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_desmarcar.BackColor = System.Drawing.Color.Silver;
            this.btn_desmarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desmarcar.ForeColor = System.Drawing.Color.White;
            this.btn_desmarcar.Location = new System.Drawing.Point(111, 96);
            this.btn_desmarcar.Name = "btn_desmarcar";
            this.btn_desmarcar.Size = new System.Drawing.Size(159, 44);
            this.btn_desmarcar.TabIndex = 3;
            this.btn_desmarcar.Text = "desmarcar tudo";
            this.btn_desmarcar.UseVisualStyleBackColor = false;
            this.btn_desmarcar.Click += new System.EventHandler(this.btn_desmarcar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_excluir.BackColor = System.Drawing.Color.Silver;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(545, 97);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(126, 44);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_aumento_porcentagem
            // 
            this.btn_aumento_porcentagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aumento_porcentagem.BackColor = System.Drawing.Color.Silver;
            this.btn_aumento_porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aumento_porcentagem.ForeColor = System.Drawing.Color.White;
            this.btn_aumento_porcentagem.Location = new System.Drawing.Point(906, 105);
            this.btn_aumento_porcentagem.Name = "btn_aumento_porcentagem";
            this.btn_aumento_porcentagem.Size = new System.Drawing.Size(98, 36);
            this.btn_aumento_porcentagem.TabIndex = 5;
            this.btn_aumento_porcentagem.Text = "Aumentar";
            this.btn_aumento_porcentagem.UseVisualStyleBackColor = false;
            this.btn_aumento_porcentagem.Click += new System.EventHandler(this.btn_aumento_porcentagem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(768, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite a Porcentagem de aumento:";
            // 
            // nud_porcentagem
            // 
            this.nud_porcentagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_porcentagem.Location = new System.Drawing.Point(805, 121);
            this.nud_porcentagem.Name = "nud_porcentagem";
            this.nud_porcentagem.Size = new System.Drawing.Size(95, 20);
            this.nud_porcentagem.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(863, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1016, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_porcentagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aumento_porcentagem);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_desmarcar);
            this.Controls.Add(this.btn_marcar);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.dgv_venda);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vendas";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_porcentagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_venda;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.OpenFileDialog ofd_arquivo;
        private System.Windows.Forms.Button btn_marcar;
        private System.Windows.Forms.Button btn_desmarcar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_aumento_porcentagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_porcentagem;
        private System.Windows.Forms.Label label2;
    }
}

