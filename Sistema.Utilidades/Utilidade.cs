using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIbade.Util
{
    /// <summary>
    /// Classe com métodos variados de utilidade
    /// </summary>
    public class Utilidade
    {
        /// <summary>
        /// Método que seleciona randomicamente uma quantidade X de items em uma lista
        /// </summary>
        /// <typeparam name="TEntity">Tipo genérico que recebe qualquer objeto</typeparam>
        /// <param name="objetos">Lista com todos os objetos</param>
        /// <param name="quantidadeItems">Quantidade de items a serem selecionado dentro da lista de objetos</param>
        /// <returns>uma lista com a quantidade de items selecinados randomicamente da lista de objetos original</returns>
        public static List<TEntity> SelecionaRandomicamente<TEntity>(List<TEntity> objetos, int quantidadeItems)
        {
            if (quantidadeItems > objetos.Count)
            {
                quantidadeItems = objetos.Count;
            }

            List<TEntity> lista = new List<TEntity>();

            Random random = new Random();

            for (int i = 0; i < quantidadeItems; i++)
            {
                int index = random.Next(objetos.Count);

                if ( !lista.Any<TEntity>(objeto => objeto.Equals(objetos[index])) )
                {
                    lista.Add(objetos[index]);
                }
                else
                {
                    quantidadeItems += 1;
                }
            }

            return lista;
        }

        /// <summary>
        /// Método para embaralhar os items de uma lista
        /// </summary>
        /// <typeparam name="TEntity">Tipo genérico que recebe qualquer objeto</typeparam>
        /// <param name="objetos">Lista com todos os objetos</param>
        /// <returns>Retorna a lista original com os items embaralhados</returns>
        public static List<TEntity> Embaralhador<TEntity>(List<TEntity> objetos)
        {
            Random random = new Random();


            for (int i = 0; i < objetos.Count; i++)
            {
                int a = random.Next(objetos.Count);
                TEntity objeto = objetos[i];
                objetos[i] = objetos[a];
                objetos[a] = objeto;
            }

            return objetos;
        }

        /// <summary>
        /// Método para obter o IP da conexão do usuário
        /// </summary>
        /// <returns>Retorna uma string com o endereço IP da conexão do usuário</returns>
        public static string ObterIP()
        {
            try
            {
                string nome = Dns.GetHostName();
                IPAddress[] IP = Dns.GetHostAddresses(nome);
                string IPString = Convert.ToString(IP[1]);
                return IPString;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<int> RetornaDropdownNumeroQuestoes(int quantidadeQuestoes)
        {
            List<int> numeroQuestoes = new List<int>();

            for (int i = 1; i <= quantidadeQuestoes; i++)
            {
                int numeroQuestao = i;

                numeroQuestoes.Add(numeroQuestao);
            }

            return numeroQuestoes;
        }
    }
}
