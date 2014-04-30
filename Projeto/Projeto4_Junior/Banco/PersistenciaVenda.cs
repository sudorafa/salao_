using Projeto4_Junior.Factory;
using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Projeto4_Junior.Banco
{
    public class PersistenciaVenda : IBancoDadosVenda
    {
        

        public void CadastrarFuncionario(Modelo.Venda venda)
        {
            //TODO- concluir o nsert com oretorno do id da venda

            /*
            FactoryConnection conn = new FactoryConnection();
            String query = "insert into venda (ValorTotal, Data, CPFFuncionario, CPFCliente) values (@param1,@param2) select SCOPE_IDENTITY()";
            //Crio meu objeto SqlCommand passando meu sql e o objeto de conexão (que cada um cria de um jeito)
            
            SqlCommand cmd = new SqlCommand(query, conn);

            // crio os parâmetros
            cmd.Parameters.Add("@campo1", SqlDbType.VarChar, 100);
            cmd.Parameters.Add("@campo2", SqlDbType.VarChar, 100);

            // valorizo os parâmetros
            cmd.Parameters["@campo1"].Value = "teste";
            cmd.Parameters["@campo2"].Value = "campo";

            // recupero o IDENTITY através da execução do ExecuteScalar
            int identity = Convert.ToInt16(cmd.ExecuteScalar());
             * 
             * */
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
