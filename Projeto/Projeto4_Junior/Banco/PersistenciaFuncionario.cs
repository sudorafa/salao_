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

namespace Projeto4_Junior.Banco
{
    class PersistenciaFuncionario : IBancoDadosFuncionario
    {
        SqlCommand comm = new SqlCommand();
        FactoryConnection fc = new FactoryConnection();

        public void CadastrarFuncionario(Funcionario funionario)
        {
            try
            {
                comm.CommandText = "INSERT INTO FUNCIONARIOS(NOME, ENDERECO, DATADENASC, TELEFONE, TELEFONE2, CPF, IDGESTOR, LOGIN)" +
                    " VALUES(@nome, @endereco, @datadenasc, @telefone, @telefone2, @cpf, @IDGestor, @login) FROM FUNCIONARIO";
                comm.Parameters.AddWithValue("@nome", funionario.Nome);
                comm.Parameters.AddWithValue("@endereco", funionario.Endereco);
                comm.Parameters.AddWithValue("@datadenasc", funionario.Data_Nascimento);
                comm.Parameters.AddWithValue("@telefone", funionario.Telefone);
                //comm.Parameters.AddWithValue("@telefone2", funionario.Telefone2);
                comm.Parameters.AddWithValue("@cpf", funionario.Cpf);
                comm.Parameters.AddWithValue("@IDGestor", funionario.IdGestor);
                comm.Parameters.AddWithValue("@login", funionario.Login);

                fc.AbrirConnexao();
                comm.ExecuteNonQuery();
                fc.FecharConnecxao();
            }catch(SqlException e)
            {
                e.Message.GetType();
            }



        }
        public Funcionario BuscarFuncionario(Funcionario funionario)
        {
                       
            
            return null ;
        }
        public void RemoverFuncionario(Funcionario funionario)
        {
            try
            {
                comm.CommandText = "DELETE FROM FUNCIONARIO WHERE CPF=@CPF";
                comm.Parameters.AddWithValue("@cpf", funionario.Cpf);
                fc.AbrirConnexao();
                comm.ExecuteNonQuery();
                fc.FecharConnecxao();
            }
            catch (SqlException e)
            {
                e.Message.GetType();
            }


        }
        public void AlterarFuncionario(Funcionario funionario)
        {
            try
            {
                comm.CommandText = "UPDATE FUNCIONARIOS set NOME=@nome, endereco=@endereco, datadenasc=@datadenasc," +
                                   "telefone=@telefone, IDGestor=@IDGestor, login=@login where cpf=@cpf";
                comm.Parameters.AddWithValue("@nome", funionario.Nome);
                comm.Parameters.AddWithValue("@endereco", funionario.Endereco);
                comm.Parameters.AddWithValue("@datadenasc", funionario.Data_Nascimento);
                comm.Parameters.AddWithValue("@telefone", funionario.Telefone);
                //comm.Parameters.AddWithValue("@telefone2", funionario.Telefone2);
                comm.Parameters.AddWithValue("@cpf", funionario.Cpf);
                comm.Parameters.AddWithValue("@IDGestor", funionario.IdGestor);
                comm.Parameters.AddWithValue("@login", funionario.Login);

                fc.AbrirConnexao();
                comm.ExecuteNonQuery();
                fc.FecharConnecxao();
            }
            catch (SqlException e)
            {
                e.Message.GetType();
            }

        }

        public SqlDataReader VerificaFunc(Funcionario func)
        {
            SqlDataReader read = null;
            try
            {
                
                comm.CommandText = "select COUNT(*) from funcionario where cpf=@cpf";
                comm.Parameters.AddWithValue("@cpf", func.Cpf);
                comm.Connection = fc.AbrirConnexao();
                read = comm.ExecuteReader();
                
            }catch(SqlException e)
            {
                e.Message.GetType();
            }
            return read;
        }

    }
}
