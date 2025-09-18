using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

//Importa a biblioteca do MySQL
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class Form1 : Form
    {
        //Vari�vel que ir� armazenar a conex�o com o banco de dados
        MySqlConnection Conexao;
        string connString = "datasource=localhost;username=root;password=;database=agenda";

        public Form1()
        {
            InitializeComponent();
            lstContatos.View = View.Details;
            lstContatos.Columns.Add("10", 50);
            lstContatos.Columns.Add("Nome", 150);
            lstContatos.Columns.Add("Email", 150);
            lstContatos.Columns.Add("Telefone", 100);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //String de conex�o com o banco de dados

                Conexao = new MySqlConnection(connString);
                //Cria a conex�o para inserir os dados
                string sql = "INSERT INTO contatos (nome,email,telefone)" +
                    "VALUES ('" + txtNome.Text + "','" + txtTelefone.Text + "','" + txtEmail.Text + "')";
                //Cria o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                //Abre a conex�o
                Conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato salvo com sucesso!!!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o contato!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fechando a conex�o
                Conexao?.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria a string SQL para consultar os dados
                string query = "'" + txtLocalizar.Text + "'";

                //Cria uma conex�o com o Mtsql
                Conexao = new MySqlConnection(connString);

                //Cria a string SQL para inserir os dados
                string sql = "SELECT * " +
                    "FROM contatos " +
                    "WHERE nome LIKE" + query + "OR email like" + query;

                //Cria o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                //Abre a conex�o
                Conexao.Open();

                //Executa o comando
                MySqlDataReader reader = comando.ExecuteReader();

                //Limpa a lista
                lstContatos.Items.Clear();

                //L� os dados relacionados
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader[0].ToString(),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString()
                    };

                    //Cria um novo ListViewItem com os dados lidos
                    var linha_listview = new ListViewItem(row);

                    //Adiciona o ListViewItem � lista
                    lstContatos.Items.Add(linha_listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro consultar registro no banco: " + ex.Message);
            }
            finally
            {
                //Fecha a conex�o
                if (Conexao != null)
                {
                    Conexao.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria a conex�o com o MySQL
                Conexao = new MySqlConnection(connString);

                //Cria a consulta SQL para atualizar o contato
                string sql = "UPDATE contatos SET nome = @nome, email = @email, telefone = @telefone WHERE id = @id";

                //Cria o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                //Adiciona os par�metros com os valores do campo de texto
                comando.Parameters.AddWithValue("@nome", txtNome.Text); //nome do campo
                comando.Parameters.AddWithValue("@email", txtEmail.Text); //email do campo
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text); //telefone do campo
                comando.Parameters.AddWithValue("@id", txtID.Text); //id do campo (ou o valor que identifica o contato)

                //Abre a conex�o
                Conexao.Open();

                //Executa o comando
                comando.ExecuteNonQuery();

                //Exibe uma mensagem de sucesso
                MessageBox.Show("Contato atualizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //Exibe uma mensagem de erro
                MessageBox.Show("Erro ao atualizar o contato! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Fecha a conex�o
                Conexao?.Close();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Pega o ID da caixa de texto
            string id = txtID.Text;

            // Valida se o campo ID est� preenchido
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Por favor, digite o ID do registro que deseja deletar.");
                return;
            }

            // Confirma a exclus�o
            DialogResult resultado = MessageBox.Show($"Tem certeza que deseja deletar o registro com ID {id}?", "Confirma��o de Exclus�o", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Usa a vari�vel de conex�o de classe
                    Conexao = new MySqlConnection(connString);

                    // Comando SQL para deletar
                    string sql = "DELETE FROM contatos WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                    cmd.Parameters.AddWithValue("@id", id);

                    Conexao.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro deletado com sucesso!");

                        // ----- C�DIGO PARA LIMPAR OS CAMPOS (DIRETO NO BOT�O) -----
                        txtID.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtTelefone.Clear();

                        // ----- C�DIGO PARA ATUALIZAR A LISTVIEW (DIRETO NO BOT�O) -----
                        try
                        {
                            // Usa a vari�vel de conex�o de classe (ou cria uma nova se necess�rio)
                            Conexao = new MySqlConnection(connString);

                            // A string SQL para buscar todos os dados
                            string sqlConsulta = "SELECT * FROM contatos WHERE nome LIKE @query OR email LIKE @query";
                            MySqlCommand cmdConsulta = new MySqlCommand(sqlConsulta, Conexao);
                            // Use a sua caixa de texto para buscar os dados.
                            cmdConsulta.Parameters.AddWithValue("@query", "%" + txtLocalizar.Text + "%");

                            Conexao.Open();
                            MySqlDataReader reader = cmdConsulta.ExecuteReader();

                            lstContatos.Items.Clear();

                            while (reader.Read())
                            {
                                string[] row =
                                {
                                    reader[0].ToString(),
                                    reader[1].ToString(),
                                    reader[2].ToString(),
                                    reader[3].ToString()
                                };
                                var linha_listview = new ListViewItem(row);
                                lstContatos.Items.Add(linha_listview);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao atualizar a lista de contatos: " + ex.Message);
                        }
                        finally
                        {
                            Conexao?.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro foi deletado. O ID pode n�o existir.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao tentar deletar o registro: " + ex.Message);
                }
                finally
                {
                    Conexao?.Close();
                }
            }
        }
    }
}
    



