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
    public partial class Form1 : Form
    {

        //BANCO DE DADOS
        static string Server = "localhost";
        static string User = "root";
        static string Senha = "";
        private MySqlConnection bdConn = new MySqlConnection(" Persist Security Info=False;server=" + Server + ";database=acheipuc;uid=" + User + ";server = " + Server + "; database = acheipuc; uid = " + User + "; pwd = '" + Senha + "'");
        DataSet bdDataSet = new DataSet();
        MySqlDataAdapter bdAdapter = new MySqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCadatroObjeto fCadastro = new formCadatroObjeto("",bdConn);
            fCadastro.ShowDialog();
            this.Show();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fechar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void bt_Listar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formListarObjetos fListar = new formListarObjetos(bdConn);
            fListar.ShowDialog();
            this.Show();
        }

        private void tb_OP_SelectPRJ_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (tb_OP_SelectPRJ.Text != "")
                {
                    //ABRE CONEXÃO
                    bdConn.Open();
                    bdDataSet.Clear();
                    bdAdapter = new MySqlDataAdapter("SELECT idObjeto, nomeObjeto FROM ObjetoItem WHERE nomeObjeto like '%" + tb_OP_SelectPRJ.Text + "%';", bdConn);
                    bdAdapter.Fill(bdDataSet, "nomeObjeto");                    
                    dataGrid_OP_SelectPRJ.DataSource = bdDataSet;

                    if (bdDataSet.Tables["nomeObjeto"].Rows.Count == 0)
                        lb_OP_NotFound.Visible = true;
                    else
                        lb_OP_NotFound.Visible = false;

                    dataGrid_OP_SelectPRJ.DataMember = "nomeObjeto";

                    //FECHA CONEXÃO
                    bdConn.Close();
                }
                else
                {
                    lb_OP_NotFound.Visible = false;
                    if (this.dataGrid_OP_SelectPRJ.DataSource != null)
                        this.dataGrid_OP_SelectPRJ.DataSource = null;
                    else
                    {
                        this.dataGrid_OP_SelectPRJ.Rows.Clear();
                        this.dataGrid_OP_SelectPRJ.Columns.Clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bdConn.Close();
            }
        }

        private void bt_OP_OK_Click(object sender, EventArgs e)
        {
            if (dataGrid_OP_SelectPRJ.CurrentRow != null)
                if (bdDataSet.Tables["nomeObjeto"].Rows.Count > 0)
                {
                    try
                    {
                        this.Hide();
                        formCadatroObjeto fCadastro = new formCadatroObjeto(dataGrid_OP_SelectPRJ.CurrentRow.Cells[0].Value.ToString(), bdConn);
                        fCadastro.ShowDialog();
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bdConn.Close();
                    }
                }
                else
                    MessageBox.Show("Nenhum projeto foi encontrado! Pesquise novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_Cadastrar.PerformClick();
        }

        private void listarObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_Listar.PerformClick();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_Sair.PerformClick();
        }

        private void dataGrid_OP_SelectPRJ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_OP_OK.PerformClick();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre fS = new FormSobre();
            fS.ShowDialog();
        }
    }
}
