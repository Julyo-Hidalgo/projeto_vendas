using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projeto_dgv
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            //definindo as colunas
            dgv_venda.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgv_venda.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgv_venda.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgv_venda.Columns.Insert(3, new DataGridViewTextBoxColumn());
            dgv_venda.Columns.Insert(4, new DataGridViewTextBoxColumn());
            dgv_venda.Columns.Insert(5, new DataGridViewTextBoxColumn());
            dgv_venda.Columns.Insert(6, new DataGridViewTextBoxColumn());

            //renomeando
            dgv_venda.Columns[0].Name = "OK";
            dgv_venda.Columns[1].Name = "id";
            dgv_venda.Columns[2].Name = "ean";
            dgv_venda.Columns[3].Name = "Produto";
            dgv_venda.Columns[4].Name = "Valor Compra";
            dgv_venda.Columns[5].Name = "Valor Venda";
            dgv_venda.Columns[6].Name = "Estoque";

            //configurando
            dgv_venda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_venda.ReadOnly = true;
            dgv_venda.AllowUserToAddRows = false;
            dgv_venda.AllowUserToDeleteRows = false;
            dgv_venda.AllowUserToOrderColumns = true;

            //configurando a coluna do valor
            dgv_venda.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_venda.Columns[4].DefaultCellStyle.Format = "###.###.###0,00";

            dgv_venda.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_venda.Columns[5].DefaultCellStyle.Format = "###.###.###0,00";
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            dgv_venda.RowCount = 0;

            ofd_arquivo.FileName = "";
            ofd_arquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofd_arquivo.FileName);

            string linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                string id = dados[0];
                string ean = dados[1];
                string produto = dados[2];
                string valor_compra = dados[3];
                string valor_venda = dados[4];
                string estoque = dados[5];

                dgv_venda.Rows.Add(false, id, ean, produto, valor_compra, valor_venda, estoque);
            }

        }

        private void btn_marcar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in dgv_venda.Rows)
                linha.Cells[0].Value = true;
        }

        private void btn_desmarcar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in dgv_venda.Rows)
                linha.Cells[0].Value = false;
        }

        bool condicao = false;/*Na primeira vez o valor da celula é falso, então atribui um valor falso para esta variavel de condição*/
        private void dgv_venda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_venda.Rows.Count > 0 && e.ColumnIndex == 0)
            {
                if (condicao == false)
                {
                    dgv_venda.CurrentCell.Value = true;
                    condicao = true;
                }
                else
                {
                    dgv_venda.CurrentCell.Value = false;
                    condicao = false;
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if ((dgv_venda.Rows.Count > 0) && Convert.ToBoolean(dgv_venda.CurrentRow.Cells[0].Value) == true)
            {
                for (int i = dgv_venda.RowCount - 1; i >= 0; i--)
                {
                    if (Convert.ToBoolean(dgv_venda.Rows[i].Cells[0].Value) == true)
                    {
                        dgv_venda.Rows.RemoveAt(dgv_venda.Rows[i].Index);
                    }
                }
            }
            else if (dgv_venda.Rows.Count == 0)
            {
                MessageBox.Show("Não existem Vendas cadastradas!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Nenhuma venda foi selecionada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_aumento_porcentagem_Click(object sender, EventArgs e)
        {
            if (dgv_venda.CurrentRow.Cells.Count > 0 && dgv_venda.CurrentCell.ColumnIndex == 5)
            {
                double porcentagem = Convert.ToDouble(nud_porcentagem.Value);
                double valor_atual = Convert.ToDouble(dgv_venda.CurrentCell.Value);
                dgv_venda.CurrentCell.Value = Math.Round(valor_atual + ((porcentagem/100) * valor_atual), 2).ToString("F2");
            }
        }
    }
}