using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AchouPUC
{

    public partial class formCadatroObjeto : Form
    {

        //BANCO DE DADOS
        private MySqlConnection bdConn;
        private string NomeObjeto = "";
        ToolTip buttonToolTip = new ToolTip();

        public formCadatroObjeto(string nomeObjeto, MySqlConnection bdconn)
        {
            InitializeComponent();
            this.NomeObjeto = nomeObjeto;
            this.bdConn = bdconn;
        }

        private void formCadatroObjeto_Load(object sender, EventArgs e)
        {
            buttonToolTip.SetToolTip(pictureBox1, "Informar os detalhes da pessoa que identificou/retirou o objeto.");
            buttonToolTip.SetToolTip(pictureBox2, "Informar os detalhes do objeto encontrado.");
            buttonToolTip.SetToolTip(pictureBox3, "Informar os detalhes do local onde o objeto foi encontrado.");

            if (NomeObjeto != "")
                exibeOBJ(NomeObjeto);
            else
            {
                bt_Salvar.Visible = true;
                bt_Baixa.Visible = false;
            }
                
        }

        private void cb_TipoCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TipoCadastro.Text != "")
            {

                if (cb_TipoCadastro.Text == "Objeto Perdido")                
                    gb_Ident.Text = "Informações do Proprietário";                
                else
                    gb_Ident.Text = "Informações do Identificador";                            
            }                
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do Cadastro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string COD_OBJETO = "";
                bool userCadastrado = false;
                string vCampos = validaCampos();
                DialogResult result;

                if (vCampos == "")
                {
                    //ABRE CONEXÃO
                    bdConn.Open();
                    MySqlCommand command;
                    MySqlDataReader dr;

                    //CODIGO OCORRENCIA
                    #region CRIA CODIGO DO OBJETO

                    command = new MySqlCommand("SELECT count(idObjeto) FROM ObjetoItem WHERE tipo_registro = '" + ((cb_TipoCadastro.Text == "Objeto Perdido") ? "Perdido" : "Encontrado") + "';", bdConn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                        COD_OBJETO = "OBJ-" + ((cb_TipoCadastro.Text == "Objeto Perdido") ? "P" : "E") + "-" + (Int16.Parse(dr["count(idObjeto)"].ToString()) + 1).ToString();
                    dr.Close();

                    #endregion

                    if (cb_TipoCadastro.Text == "Objeto Perdido")
                    {
                        command = new MySqlCommand("SELECT idProprietario FROM ObjetoItem WHERE idProprietario = '" + tb_Identidade.Text + "';", bdConn);
                        dr = command.ExecuteReader();
                        if (dr.Read())
                            userCadastrado = true;
                        dr.Close();

                        if (userCadastrado == false)
                        {
                            command = new MySqlCommand("INSERT INTO proprietario (idProprietario, nomeProprietario, telefone) " +
                         "VALUES ('" + tb_Identidade.Text + "','" + tb_Nome.Text + "','" + tb_Telefone.Text + "');", bdConn);
                            command.ExecuteNonQuery();
                        }

                        command = new MySqlCommand("INSERT INTO ObjetoItem (idObjeto, nomeObjeto, corObjeto, descricaoObjeto, tipo_registro, unidadePUC, predioPUC, salaPUC, complementoLocal, idProprietario, objetoRetirado) " +
                         "VALUES " +
                         "('" + COD_OBJETO + "','"
                         + tb_NomeObj.Text + "','"
                         + tb_CorObj.Text + "','"
                         + tb_DescObj.Text + "','"
                         + ((cb_TipoCadastro.Text == "Objeto Perdido") ? "Perdido" : "Encontrado") + "','"
                         + cb_Unidade.Text + "','"
                         + tb_Predio.Text + "','"
                         + tb_Sala.Text + "','"
                         + tb_Complemento.Text + "','"
                         + tb_Identidade.Text + "','N');", bdConn);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command = new MySqlCommand("INSERT INTO ObjetoItem (idObjeto, nomeObjeto, corObjeto, descricaoObjeto, tipo_registro, unidadePUC, predioPUC, salaPUC, complementoLocal, idEncontrador, nomeEncontrador, telefoneEncontrador, objetoRetirado) " +
                         "VALUES " +
                         "('" + COD_OBJETO + "','"
                         + tb_NomeObj.Text + "','"
                         + tb_CorObj.Text + "','"
                         + tb_DescObj.Text + "','"
                         + ((cb_TipoCadastro.Text == "Objeto Perdido") ? "Perdido" : "Encontrado") + "','"
                         + cb_Unidade.Text + "','"
                         + tb_Predio.Text + "','"
                         + tb_Sala.Text + "','"
                         + tb_Complemento.Text + "','"
                         + tb_Identidade.Text + "','"
                         + tb_Nome.Text + "','"
                         + tb_Telefone.Text + "','N');", bdConn);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Status atualizado com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    result =  MessageBox.Show("Campo obrigatório não informado: " + vCampos + "\n\nO que deseja fazer?","Atenção!",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Question);

                    if (result == DialogResult.Ignore)
                        bt_Salvar.PerformClick();
                    else if (result == DialogResult.Abort)
                        this.Close();
                    
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //FECHA CONEXÃO
                bdConn.Close();
            }
        }

        string validaCampos()
        {
            string MSG = "";

            if (tb_Identidade.Text == "")
            {
                MSG = "Identidade";
                return MSG;
            }

            if (tb_Nome.Text == "")
            {
                MSG = "Nome";
                return MSG;
            }

            if (tb_Telefone.Text == "")
            {
                MSG = "Telefone";
                return MSG;
            }

            if (tb_NomeObj.Text == "")
            {
                MSG = "Nome Objeto";
                return MSG;
            }

            if (tb_CorObj.Text == "")
            {
                MSG = "Cor Objeto";
                return MSG;
            }

            if (cb_Unidade.Text == "")
            {
                MSG = "Unidade";
                return MSG;
            }

            if (tb_Predio.Text == "")
            {
                MSG = "Prédio";
                return MSG;
            }

            if (tb_Sala.Text == "")
            {
                MSG = "Sala";
                return MSG;
            }

            return MSG;
        }

        void exibeOBJ(string idObj)
        {
            bt_Baixa.Visible = true;
            bt_Salvar.Visible = false;
            

            //ABRE CONEXÃO
            bdConn.Open();
            MySqlCommand command;
            MySqlDataReader dr;
            bool tpreg = false;
            string propritetario = "";
            string retirado = "";

            command = new MySqlCommand("SELECT idObjeto, nomeObjeto, corObjeto, descricaoObjeto, tipo_registro, unidadePUC, predioPUC, salaPUC, complementoLocal, objetoRetirado, idEncontrador, idProprietario, nomeEncontrador, telefoneEncontrador, objetoRetirado FROM ObjetoItem WHERE idObjeto = '" + idObj + "';", bdConn);
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                if (dr["tipo_registro"].ToString() == "Encontrado")
                {
                    tb_Identidade.Text = dr["idEncontrador"].ToString();
                    tb_Nome.Text = dr["nomeEncontrador"].ToString();
                    tb_Telefone.Text = dr["telefoneEncontrador"].ToString();
                    tb_NomeObj.Text = dr["nomeObjeto"].ToString();
                    tb_CorObj.Text = dr["corObjeto"].ToString();
                    tb_DescObj.Text = dr["descricaoObjeto"].ToString();
                    cb_Unidade.Text = dr["unidadePUC"].ToString();
                    tb_Predio.Text = dr["predioPUC"].ToString();
                    tb_Sala.Text = dr["salaPUC"].ToString();
                    tb_Complemento.Text = dr["complementoLocal"].ToString();
                    retirado = dr["objetoRetirado"].ToString();
                    cb_TipoCadastro.Text = "Objeto Encontrado";
                    tpreg = true;
                }
                else
                {
                    tb_NomeObj.Text = dr["nomeObjeto"].ToString();
                    tb_CorObj.Text = dr["corObjeto"].ToString();
                    tb_DescObj.Text = dr["descricaoObjeto"].ToString();
                    cb_Unidade.Text = dr["unidadePUC"].ToString();
                    tb_Predio.Text = dr["predioPUC"].ToString();
                    tb_Sala.Text = dr["salaPUC"].ToString();
                    tb_Complemento.Text = dr["complementoLocal"].ToString();
                    propritetario = dr["idProprietario"].ToString();
                    retirado = dr["objetoRetirado"].ToString();
                    cb_TipoCadastro.Text = "Objeto Perdido";
                }
            }
            dr.Close();

            if (tpreg == false)
            {
                command = new MySqlCommand("SELECT idProprietario, nomeProprietario, telefone FROM proprietario WHERE idProprietario = '" + propritetario + "';", bdConn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    tb_Identidade.Text = dr["idProprietario"].ToString();
                    tb_Nome.Text = dr["nomeProprietario"].ToString();
                    tb_Telefone.Text = dr["telefone"].ToString();
                }
                dr.Close();
            }

            if (retirado == "S")
            {
                bt_Baixa.Visible = false;
                bt_Salvar.Visible = false;
                MessageBox.Show("Esse objeto já foi retirado pelo Proprietário!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //FECHA CONEXÃO
            bdConn.Close();

        }

        private void bt_Baixa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fazer a retirada do objeto para o Próprietario?", "Retirar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //ABRE CONEXÃO
                    bdConn.Open();
                    MySqlCommand command;
                    command = new MySqlCommand("UPDATE ObjetoItem SET objetoRetirado = 'S' WHERE idObjeto = '" + NomeObjeto + "'", bdConn);
                    command.ExecuteNonQuery();                    

                    //FECHA CONEXÃO
                    bdConn.Close();

                    MessageBox.Show("Objeto retirado com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
