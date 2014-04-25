﻿using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Negocios;
using Projeto4_Junior.Factory;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Projeto4_Junior.Banco
{
    class PersistenciaUsuario : IBancoDadosUsuario
    {
        public void CadastrarUsuario(Usuario usuario)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "insert into Usuario (Nome, Login, Senha, TipoUsuario, Ativo) values" +
                "('" + usuario.Nome + "', '" + usuario.Login + "', '" + usuario.Senha +
                "', '" + usuario.isGestor + "', '" + usuario.Ativo + "')";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());                
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();                
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }          

        }
        public Usuario BuscarUsuario(String login)
        {
            FactoryConnection conn = new FactoryConnection();
            Usuario usu = new Usuario();
            try
            {
                String query = "SELECT * FROM Usuario WHERE login = '" + login + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    usu.Nome = (String)reader["nome"];
                    usu.Login = (String)reader["login"];
                    usu.Senha = (String)reader["senha"];
                    usu.isGestor = (int)reader["TipoUsuario"];
                }
                reader.Close();
                conn.FecharConnecxao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

            return usu;
            
        }
        public void RemoverUsuario(String login)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "UPDATE Usuario SET Ativo=0 WHERE Login = '" + login + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
                MessageBox.Show("Usuario removido com sucesso!");
                conn.FecharConnecxao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

        }

        public void AlterarUsuario(Usuario usuario, String login)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "UPDATE Usuario SET Nome = '" + usuario.Nome + "', Login = '" + usuario.Login +
                    "', Senha = '" + usuario.Senha + "', TipoUsuario = '" + usuario.isGestor + "' WHERE Login = '" + login + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();
                MessageBox.Show("Alterado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            } 
        }
        public bool Autenticar(String usuario, String senha)
        {
            bool retorno = false;
            try{                
                FactoryConnection conn = new FactoryConnection();   
                         
                    String query = "select Login, Senha, Ativo from Usuario where Login='" + usuario +
                        "' and Senha='" + senha + "' and Ativo=1 ";                

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
                
                conn.FecharConnecxao();  
            }
             catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }  
            
            return retorno;            
        }
        public bool VerificarUsuarioExistente(String login)
        {
            bool retorno = true;

            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "select Login from Usuario where Login ='" + login + "'";

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
                conn.FecharConnecxao();
            }
           catch (Exception e)
           {
               MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
           }
            return retorno;
        }


        public bool VerificaTipoUsuario(String login)
        {
           bool retorno = true;
           try{
                FactoryConnection conn = new FactoryConnection();

                String query = "select tipoUsuario from Usuario where Login='" + login + "' AND tipoUsuario = '1'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
            

                if (reader.Read())
                {
                    conn.FecharConnecxao();
                    retorno = true;
                }
                else
                {
                    conn.FecharConnecxao();
                    retorno = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

           return retorno;
        }

        public ArrayList ListarUsuario(String busca)
        {
           FactoryConnection conn = new FactoryConnection();
            ArrayList lista = new ArrayList();

            try
            {
                String query = "SELECT * FROM Usuario WHERE nome LIKE '%"+busca+"%'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Modelo.Usuario usu = new Modelo.Usuario();

                    usu.Nome = (String) reader["Nome"];
                    usu.Login = (String)reader["Login"];
                    usu.Senha = (String)reader["Senha"];
                    usu.isGestor = (int)reader["TipoUsuario"];
                    usu.Ativo = (Boolean)reader["Ativo"];

                    if(usu.Ativo == true)
                    {
                        lista.Add(usu);
                    }                   
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

