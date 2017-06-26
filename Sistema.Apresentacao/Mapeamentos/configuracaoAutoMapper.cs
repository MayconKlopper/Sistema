using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;

namespace Sistema.Apresentacao.Mapeamentos
{
    public class ConfiguracaoAutoMapper
    {
        public static void Registrar()
        {
            Mapper.Initialize(
                mapper => {
                    mapper.AddProfile<MapeamentoComputador>();
                    mapper.AddProfile<MapeamentoFonte>();
                    mapper.AddProfile<MapeamentoHD>();
                    mapper.AddProfile<MapeamentoMemoriaRAM>();
                    mapper.AddProfile<MapeamentoPlacaMae>();
                    mapper.AddProfile<MapeamentoProcessador>();
                }
                );
        }
    }
}