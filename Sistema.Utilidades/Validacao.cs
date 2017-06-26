﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Utililidades
{
    /// <summary>
    /// classe com métodos de validações diversas
    /// </summary>
    public class Validacao
    {
        /// <summary>
        /// Método que valida se o número de CPF passado como parâmetro é válido ou inválido
        /// </summary>
        /// <param name="cpf">Número de CPF</param>
        /// <returns>Retorna uma variável booleana com o valor True se o número do CPF for válido ou o valor False se o número do CPF for inválido</returns>
        public static bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito = string.Empty;
            int soma;
            int resto;

            if (cpf != null && cpf != string.Empty)
            {
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");

                if (cpf.Length != 11)
                    return false;

                tempCpf = cpf.Substring(0, 9);
                soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();

                tempCpf = tempCpf + digito;

                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();

                return cpf.EndsWith(digito);
            }

            else
            {
                return false;
            }
        }
    }
}
