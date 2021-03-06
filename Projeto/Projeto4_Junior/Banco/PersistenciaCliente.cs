﻿using Projeto4_Junior.Modelo;
using Projeto4_Junior.Factory;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Negocios;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;


namespace Projeto4_Junior.Banco
{
    class PersistenciaCliente : IBancoDadosCliente
    {
        public void CadastrarCliente(Cliente cliente)
        {            
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "insert into Cliente (Nome, CPF, Telefone, Endereco, DataNascimento, Email, Ativo) values" +
                "('" + cliente.Nome + "', '" + cliente.Cpf + "', '" + cliente.Telefone + "', '" + cliente.Endereco + "', '"
                + cliente.DataNascimento + "', '" + cliente.Email + "', '" + cliente.Ativo + "')";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());               
                SqlDataReader reader = comand.ExecuteReader();
                               
                MessageBox.Show("Cadastrado com sucesso!");
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
        public Cliente BuscarCliente(String cpf)
        {
            FactoryConnection conn = new FactoryConnection();
            Cliente cli = new Cliente();
            try
            {
                String query = "SELECT * FROM Cliente WHERE cpf = '" + cpf + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    cli.Nome = (String)reader["nome"];
                    cli.Cpf = (String)reader["cpf"];
                    cli.DataNascimento = (String)reader["dataNascimento"];
                    cli.Email = (String)reader["email"];
                    cli.Endereco = (String)reader["endereco"];
                    cli.Telefone = (String)reader["telefone"];
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
            
            return cli;
        }
        public void RemoverCliente(String cpf)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "UPDATE Cliente SET Ativo=0 WHERE CPF = '" + cpf + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
                MessageBox.Show("Cliente removido com sucesso!");
                
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
        public void AlterarCliente(Cliente cliente)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "update Cliente set Nome = '"+cliente.Nome+"', telefone = '"+cliente.Telefone+"', endereco = '"
                +cliente.Endereco+"', DataNascimento = '"+cliente.DataNascimento+"', email = '"+cliente.Email+"' where cpf = '"+cliente.Cpf+"'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());              
                SqlDataReader reader = comand.ExecuteReader();
                
                MessageBox.Show("Alterado com sucesso!");
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

        public bool VerificaExistenciaCliente(String cpf)
        {
            bool retorno = true;
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "select CPF from Cliente where CPF ='" + cpf + "'";

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
        }
        public ArrayList ListarCliente(String busca)
        {
            FactoryConnection conn = new FactoryConnection();
            ArrayList lista = new ArrayList();

            try
            {
                String query = "SELECT * FROM Cliente WHERE nome LIKE '%"+busca+"%'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cli = new Cliente();

                    cli.Nome = (String) reader["nome"];
                    cli.Cpf = (String)reader["cpf"];
                    cli.DataNascimento = (String)reader["dataNascimento"];
                    cli.Email = (String)reader["email"];
                    cli.Endereco = (String)reader["endereco"];
                    cli.Telefone = (String)reader["telefone"];
                    cli.Ativo = (Boolean)reader["Ativo"];

                    if (cli.Ativo == true)
                    {
                        lista.Add(cli);
                    }
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
        public ArrayList BuscarAniversariantes(String data)
        {
            FactoryConnection conn = new FactoryConnection();
            ArrayList lista = new ArrayList();

            try
            {
                String query = "SELECT * FROM Cliente WHERE DataNascimento LIKE '%" + data + "%'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cli = new Cliente();

                    cli.Nome = (String)reader["nome"];
                    cli.Cpf = (String)reader["cpf"];
                    cli.DataNascimento = (String)reader["dataNascimento"];
                    cli.Email = (String)reader["email"];
                    cli.Endereco = (String)reader["endereco"];
                    cli.Telefone = (String)reader["telefone"];
                    cli.Ativo = (Boolean)reader["Ativo"];

                    if (cli.Ativo == true)
                    {
                        lista.Add(cli);
                    }
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

            return lista;
        }
    }
}

