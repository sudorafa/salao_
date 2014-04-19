using Projeto4_Junior.Modelo;
using Projeto4_Junior.Factory;//-----foi acrescentado-------//
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Negocios;
using System.Data.SqlClient; //---------foi acrescentado-----//
using System.Windows.Forms;  //-------foi acrescentado-------//

namespace Projeto4_Junior.Banco
{
    class PersistenciaServico : IBancoDadosServico
    {
        public void CadastrarServico(Servico servico) //--------foi acrescentado---------//
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "insert into Serviços(Descricao,Valor,Ativo) values" +
                "('" + servico.Descricao + "', '" + servico.Valor + "', '" + servico.isGestor + "')";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                //comand.ExecuteNonQuery(); <---- Não seria melhor usar o comand pra executar a instrução SQL ?
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");//----até aqui----/
            }   

        }
        public Servico BuscarServico(Servico servico)
        {
            return null;
        }
        public void RemoverServico(Servico servico)
        {

        }
        public void AlterarServico(Servico servico)
        {

        }
        public bool VerificaExistenciaServico(int IdServico)
        {
            return false;

        }//Foi acrescentado.
    }
}
