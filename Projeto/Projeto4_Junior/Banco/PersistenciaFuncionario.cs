﻿using Projeto4_Junior.Modelo;
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
<<<<<<< HEAD
            fc.FecharConnecxao();
            
            SqlCommand comm = new SqlCommand();
            try
            {
                comm.CommandText = "INSERT INTO FUNCIONARIO(NOME, ENDERECO, DATNASCIMENTO, TELEFONE,  CPF, porcentagem)" +
                    " VALUES(@nome, @endereco, @datNascimento, @telefone, @cpf, @porcentagem)";
                comm.Parameters.AddWithValue("@nome", funionario.Nome);
                comm.Parameters.AddWithValue("@endereco", funionario.Endereco);
                comm.Parameters.AddWithValue("@datNascimento", funionario.DataNascimento);
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
=======
            if (this.VerificaFunc(funionario.Cpf))
            {
                MessageBox.Show("Já existe Funcionário cadastrado com este CPF!");
            }
            else
            {
                FactoryConnection conn = new FactoryConnection();
                try
                {
                    String query = "insert into Funcionario (Nome, cpf, telefone, endereco, porcentagem, datanascimento, ativo) values" +
                    "('" + funionario.Nome + "', '" + funionario.Cpf + "', '" + funionario.Telefone +
                    "', '" + funionario.Endereco + "', '" + funionario.Porcentagem + "', '" + funionario.DataNascimento + "', '" + funionario.Ativo + "')";

                    SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                    SqlDataReader reader = comand.ExecuteReader();
                    MessageBox.Show("Cadastro Efetuado com sucesso !!"); 
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
                }
                finally
                {
                    conn.FecharConnecxao();
                }          
            }


        }
        public Funcionario BuscarFuncionario(String cpf)
>>>>>>> 66f00740a17d1a8df448f010c5eeb1f9f829d430
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
                    func.DataNascimento = (String)reader["dataNascimento"];
                    func.Porcentagem = (double)reader["porcentagem"];
                    func.Endereco = (String)reader["endereco"];
                    func.Telefone = (String)reader["telefone"];
                    func.Ativo = (bool)reader["ativo"];
                }
                reader.Close();
               

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }
            finally
            {
                conn.FecharConnecxao();
            }

            return func;
        }
        public void RemoverFuncionario(String cpf)
        {

            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "UPDATE Funcionario SET ativo = 0 where CPF ='" + cpf + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
                MessageBox.Show("Funcionário removido com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }
<<<<<<< HEAD


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
=======
            finally
            {
                conn.FecharConnecxao();
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
>>>>>>> 66f00740a17d1a8df448f010c5eeb1f9f829d430
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "UPDATE Funcionario SET nome = '" + func.Nome + "', telefone = '" + func.Telefone + "', endereco = '"+ func.Endereco + "', porcentagem = '"+func.Porcentagem+"', datNascimento = '" + func.DataNascimento + "' WHERE cpf = '"+func.Cpf+"'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                SqlDataReader reader = comand.ExecuteReader();
                
                MessageBox.Show("Alterado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
<<<<<<< HEAD
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
=======
            }
            finally
            {
                conn.FecharConnecxao();
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

        public bool VerificaFunc(String cpf)
        {
            bool retorno = true;

            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "select cpf from Funcionario where cpf ='" + cpf + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }
            finally
            {
                conn.FecharConnecxao();
            }
            return retorno;
>>>>>>> 66f00740a17d1a8df448f010c5eeb1f9f829d430
        }

        public ArrayList ListarFuncionario(String buscar)
        {
            FactoryConnection conn = new FactoryConnection();
            ArrayList lista = new ArrayList();

            try
            {
                String query = "SELECT * FROM Funcionario WHERE nome LIKE '%" + buscar + "%' and ativo = 1" ;

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Funcionario func = new Funcionario();

                    func.Nome = (String)reader["nome"];
                    func.Cpf = (String)reader["cpf"];
                    func.DataNascimento = (String)reader["DataNascimento"];
                    func.Porcentagem = (double)reader["porcentagem"];
                    func.Endereco = (String)reader["endereco"];
                    func.Telefone = (String)reader["telefone"];
                    func.Ativo = (bool)reader["ativo"];
                    lista.Add(func);
                }
                reader.Close();
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }
            finally
            {
                conn.FecharConnecxao();
            }

            return lista;
        }

    }
}
