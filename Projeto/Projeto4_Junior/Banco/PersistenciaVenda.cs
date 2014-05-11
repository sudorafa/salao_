using Projeto4_Junior.Factory;
using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto4_Junior.Banco
{
    public class PersistenciaVenda : IBancoDadosVenda
    {
        

        public int CadastrarFuncionario(Modelo.Venda venda)
        {
                FactoryConnection conn = new FactoryConnection();
                int id = 0;
                string sSQL = @"INSERT INTO venda
					(ValorTotal, Data, CPFFuncionario, CPFCliente) VALUES (@valorTotal, @data, @cpfFuncionario, @cpfCliente)
					SET @id = SCOPE_IDENTITY()";
                try { 
                    SqlCommand cmd = new SqlCommand(sSQL, conn.AbrirConnexao());
                    cmd.Parameters.AddWithValue("@valorTotal", venda.ValorTotal);
                    cmd.Parameters.AddWithValue("@data", venda.Data);
                    cmd.Parameters.AddWithValue("@cpfFuncionario", venda.CPFFuncionario);
                    cmd.Parameters.AddWithValue("@cpfCliente", venda.CPFCliente);
                    cmd.Parameters.AddWithValue("@idVenda", 0).Direction = System.Data.ParameterDirection.Output;

                
                    cmd.ExecuteNonQuery();
                    id = Convert.ToInt32(cmd.Parameters["@idVenda"].Value);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
                }
                finally
                {
                    conn.FecharConnecxao();

                }
                return id;
                           
        }

        public Modelo.Venda BuscarFuncionario(int idVenda)
        {
            throw new NotImplementedException();
        }

        public void RemoverFuncionario(int idVenda)
        {
            throw new NotImplementedException();
        }

        public void AlterarFuncionario(Modelo.Venda venda)
        {
            throw new NotImplementedException();
        }

        public bool VerificaFunc(int idVenda)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ArrayList ListarFuncionario(int idVenda)
        {
            throw new NotImplementedException();
        }
    }
}
