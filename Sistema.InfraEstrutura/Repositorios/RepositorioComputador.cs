﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Contratos.Repositorios;
using Sistema.Dominio.Entidades;

namespace Sistema.InfraEstrutura.Repositorios
{
    public class RepositorioComputador : RepositorioGenerico<Computador>, IRepositorioComputador
    {
        public List<Computador> FindByIDUsuario(string ID)
        {
            return conexao.Set<Computador>().Where(computador => computador.IDUsuario.Equals(ID)).ToList();
        }
    }
}
