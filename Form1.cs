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
            dgv_venda.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_venda.Columns[3].DefaultCellStyle.Format = "###.###.###0,00";
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            ofd_arquivo.FileName = "";
            ofd_arquivo.ShowDialog();
        }
    }
}