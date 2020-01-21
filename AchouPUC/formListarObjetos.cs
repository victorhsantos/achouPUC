using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AchouPUC
{
    public partial class formListarObjetos : Form
    {

        //BANCO DE DADOS
        private MySqlConnection bdConn;

        public formListarObjetos(MySqlConnection bdconn)
        {
            InitializeComponent();
            this.bdConn = bdconn;
        }

        private void formListarObjetos_Load(object sender, EventArgs e)
        {
            try
            {
                //LIMPA GRIDVIEW
                if (this.dataGridView1.DataSource != null)
                    this.dataGridView1.DataSource = null;
                else
                {
                    this.dataGridView1.Rows.Clear();
                    this.dataGridView1.Columns.Clear();
                }

                //HEADER DATAGRIDVIEW
                dataGridView1.Columns.Add("idObjeto", "Cód. Obejto");
                dataGridView1.Columns.Add("nomeObjeto", "Nome");
                dataGridView1.Columns.Add("corObjeto", "Cor Objeto");
                dataGridView1.Columns.Add("tipo_registro", "Registro");
                dataGridView1.Columns.Add("objetoRetirado", "Retirado");

                //ABRE CONEXÃO
                bdConn.Open();
                MySqlCommand comand;

                comand = new MySqlCommand("SELECT idObjeto, nomeObjeto, corObjeto, tipo_registro, objetoRetirado FROM ObjetoItem ORDER BY idObjeto DESC LIMIT 10;", bdConn);
                MySqlDataReader dr = comand.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                        dr["idObjeto"].ToString(),
                        dr["nomeObjeto"].ToString(),
                        dr["corObjeto"].ToString(),
                        dr["tipo_registro"].ToString(),
                        ((dr["objetoRetirado"].ToString() == "N") ? "Não" : "Sim"));
                }

                //BOTÃO ABRIR
                DataGridViewButtonColumn btnOP = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btnOP);
                btnOP.HeaderText = "Alteração";
                btnOP.Text = "Abrir";
                btnOP.Name = "bt_AbrirRegistro";
                btnOP.UseColumnTextForButtonValue = true;

                dataGridView1.ClearSelection();

                //FECHA CONEXÃO
                bdConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bdConn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                this.Hide();
                formCadatroObjeto fCadastro = new formCadatroObjeto(dataGridView1.CurrentRow.Cells[0].Value.ToString(), bdConn);
                fCadastro.ShowDialog();
                this.Show();
            }
        }
    }
}
