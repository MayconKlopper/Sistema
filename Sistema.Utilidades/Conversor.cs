using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Utililidades
{
    /// <summary>
    /// Classe que contém métodos úteis de conversão
    /// </summary>
    public class Conversor
    {
        /// <summary>
        /// Converte o valor de uma variável booleana para o portugûes
        /// </summary>
        /// <param name="booleano">Váriável booleana que contém o valor True para verdadeiro e False para Falso</param>
        /// <returns>Retorna uma string com a tradução do valor de uma variável booleana sendo Sim para True e Não para False</returns>
        public static string BooleanoParaPortugues(bool booleano)
        {
            if(booleano)
            {
                return "Sim";
            }
            else
            {
                return "Não";
            }
        }

        /// <summary>
        /// Converte o valor de uma string em portugues para o equivalente em um valor Booleano
        /// </summary>
        /// <param name="booleanoPortugues">string que deve conter o valor SIM ou NÃO, somente estes valores serão aceitos</param>
        /// <returns>uma variável booleana com a tradução da string em português sendo True para Sim e False para Não</returns>
        public static bool PortuguesParaBooleano(string booleanoPortugues)
        {
            if(booleanoPortugues.Equals("Sim"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
