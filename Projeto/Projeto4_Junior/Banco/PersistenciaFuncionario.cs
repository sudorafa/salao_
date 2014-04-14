using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Negocios;
using System.Data.SqlClient;
using Projeto4_Junior.Factory;
using System.Collections;
using System.Windows.Forms;

namespace Projeto4_Junior.Banco
{
    class PersistenciaFuncionario : IBancoDadosFuncionario
    {
        
        FactoryConnection fc = new FactoryConnection();

        public void CadastrarFuncionario(Funcionario funionario)
        {
            fc.FecharConnecxao();
            
            SqlCommand comm = new SqlCommand();
            try
            {
                comm.CommandText = "INSERT INTO FUNCIONARIO(NOME, ENDERECO, DATNASCIMENTO, TELEFONE,  CPF, porcentagem)" +
                    " VALUES(@nome, @endereco, @datNascimento, @telefone, @cpf, @porcentagem)";
                comm.Parameters.AddWithValue("@nome", funionario.Nome);
                comm.Parameters.AddWithValue("@endereco", funionario.Endereco);
                comm.Parameters.AddWithValue("@datNascimento", funionario.Data_Nascimento);
                comm.Parameters.AddWithValue("@telefone", funionario.Telefone);
                comm.Parameters.AddWithValue("@cpf", funionario.Cpf);
                comm.Parameters.AddWithValue("@porcentagem", funionario.Porcentagem);

                comm.Connection=fc.AbrirConnexao();
                comm.ExecuteNonQuery();
                fc.FecharConnecxao();
            }catch(SqlException e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
                e.Message.GetType();
                
            }



        }
        public Funcionario BuscarFuncionario(String cpf)
        {
            FactoryConnection conn = new FactoryConnection();
            Funcionario func = new Funcionario();
            try
            {
                String query = "SELECT * FROM Funcionario WHERE cpf = '" + cpf + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    func.Nome = (String)reader["nome"];
                    func.Cpf = (String)reader["cpf"];
                    func.Data_Nascimento = (String)reader["datNascimento"];
                    func.Porcentagem = (int)reader["porcentagem"];
                    func.Endereco = (String)reader["endereco"];
                    func.Telefone = (String)reader["telefone"];

                }
                reader.Close();
                conn.FecharConnecxao();

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

            return func;
        }
        public void RemoverFuncionario(String cpf)
        {

            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "DELETE FROM Funcionario where CPF ='" + cpf + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
                MessageBox.Show("Funcionário removido com sucesso!");
                conn.FecharConnecxao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }


            /*
            try
            {
                comm.CommandText = "DELETE FROM FUNCIONARIO WHERE CPF=@CPF";
                comm.Parameters.AddWithValue("@cpf", cpf);
                fc.AbrirConnexao();
                comm.ExecuteNonQuery();
                fc.FecharConnecxao();
            }
            catch (SqlException e)
            {
                e.Message.GetType();
            }

        */
        }
        public void AlterarFuncionario(Funcionario func)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "UPDATE Funcionario SET nome = '" + func.Nome + "', telefone = '" + func.Telefone + "', endereco = '"+ func.Endereco + "', porcentagem = '"+func.Porcentagem+"', datNascimento = '" + func.Data_Nascimento + "' WHERE cpf = '"+func.Cpf+"'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();
                MessageBox.Show("Alterado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            } 
            /*
            try
            {
                comm.CommandText = "UPDATE FUNCIONARIOS set NOME=@nome, endereco=@endereco, datnascimento=@datNascimento," +
                                   "telefone=@telefone";
                comm.Parameters.AddWithValue("@nome", funionario.Nome);
                comm.Parameters.AddWithValue("@endereco", funionario.Endereco);
                comm.Parameters.AddWithValue("@datNascimento", funionario.Data_Nascimento);
                comm.Parameters.AddWithValue("@telefone", funionario.Telefone);
                comm.Parameters.AddWithValue("@cpf", funionario.Cpf);

                fc.AbrirConnexao();
                comm.ExecuteNonQuery();
                fc.FecharConnecxao();
            }
            catch (SqlException e)
            {
                e.Message.GetType();
            }
           */
        }

        public SqlDataReader VerificaFunc(Funcionario func)
        {
            SqlCommand comm = new SqlCommand();
            SqlDataReader read = null;
            try
            {
                
                comm.CommandText = "select * from funcionario where cpf=@cpf";
                comm.Parameters.AddWithValue("@cpf", func.Cpf);
                comm.Connection = fc.AbrirConnexao();
                read = comm.ExecuteReader();
                
            }catch(SqlException e)
            {
                e.Message.GetType();
            }
            return read;
        }
        public ArrayList ListarFuncionario(String buscar)
        {
            FactoryConnection conn = new FactoryConnection();
            ArrayList lista = new ArrayList();

            try
            {
                String query = "SELECT * FROM Funcionario WHERE nome LIKE '%" + buscar + "%'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Funcionario func = new Funcionario();

                    func.Nome = (String)reader["nome"];
                    func.Cpf = (String)reader["cpf"];
                    func.Data_Nascimento = (String)reader["datNascimento"];
                    func.Porcentagem = (int)reader["porcentagem"];
                    func.Endereco = (String)reader["endereco"];
                    func.Telefone = (String)reader["telefone"];

                    lista.Add(func);
                }
                reader.Close();
                conn.FecharConnecxao();

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

            return lista;
        }

    }
}
