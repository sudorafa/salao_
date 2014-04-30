﻿using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Banco
{
    public class BancoDadosVenda : IBancoDadosVenda
    {
        IBancoDadosVenda ibanco = new PersistenciaVenda();

        public void CadastrarFuncionario(Modelo.Venda venda)
        {
            ibanco.CadastrarFuncionario(venda);
        }

        public Modelo.Venda BuscarFuncionario(int idVenda)
        {
            return ibanco.BuscarFuncionario(idVenda);
        }

        public void RemoverFuncionario(int idVenda)
        {
            ibanco.RemoverFuncionario(idVenda);
        }

        public void AlterarFuncionario(Modelo.Venda venda)
        {
            ibanco.AlterarFuncionario(venda);
        }

        public bool VerificaFunc(int idVenda)
        {
            return ibanco.VerificaFunc(idVenda);
        }

        public System.Collections.ArrayList ListarFuncionario(int idVenda)
        {
            return ibanco.ListarFuncionario(idVenda);
        }
    }
}
