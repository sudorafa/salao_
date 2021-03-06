﻿using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Projeto4_Junior;

namespace Projeto4_Junior.Negocios
{
    class FachadaServico : IfachadaServico
    {
        public IfachadaServico ifachada = new ControladorServico();

        public void CadastrarServico(Servico servico)
        {
            this.ifachada.CadastrarServico(servico);
        }
        public Servico BuscarServico(int idServico)
        {
            return this.ifachada.BuscarServico(idServico);
        }
        public void RemoverServico(String Descricao)
        {
            this.ifachada.RemoverServico(Descricao);
        }
        public void AlterarServico(Servico servico, String idServicoParaServico)
        {
            this.ifachada.AlterarServico(servico, idServicoParaServico);
        }
        public ArrayList ListarServico(String busca)
        {
            return this.ifachada.ListarServico(busca);
        }
    }
}
