using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Security.Cryptography;

namespace Sistema.Utililidades
{
    /// <summary>
    /// Classe com métodos de criptografia e descriptografia
    /// </summary>
    public class Criptografia
    {
        private readonly byte[] bIV = { 0x51, 0x18, 0xF1, 0xDD, 0xDE, 0x3D, 0xF2, 0x18, 0x46, 0x64, 0x23, 0xF5, 0x77, 0x50, 0xCD, 0xAF };

        private readonly string ChaveCriptografia = "Palavra de seguranca das empresa";

        /// <summary>
        /// Método para criptografia MD5
        /// </summary>
        /// <param name="senha">string contendo a senha a ser criptografada</param>
        /// <returns>Retorna uma string com a senha transformada em uma chave MD5</returns>
        public string CriptografiaMD5(string senha)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));

            senha = BitConverter.ToString(hash).Replace("-", string.Empty);

            return senha;
        }

        /// <summary>
        /// Método para criptografia Rijndael
        /// </summary>
        /// <param name="senha">string contendo a senha a ser criptografada</param>
        /// <returns>Retorna uma string com a senha transformada em uma chave rijndael</returns>
        public string CriptografiaRijndael(string senha)
        {
            byte[] bKey = Encoding.UTF8.GetBytes(ChaveCriptografia);
            byte[] bText = Encoding.UTF8.GetBytes(senha);

            Rijndael rijndael = new RijndaelManaged();

            rijndael.KeySize = 256;

            MemoryStream mStream = new MemoryStream();
            CryptoStream encryptor = new CryptoStream(
                mStream,
                rijndael.CreateEncryptor(bKey, bIV),
                CryptoStreamMode.Write);

            encryptor.Write(bText, 0, bText.Length);
            encryptor.FlushFinalBlock();
            return Convert.ToBase64String(mStream.ToArray());
        }

        /// <summary>
        /// Método para descriptografar uma chave rijndael
        /// </summary>
        /// <param name="senha">string com a senha tranformada em chave rijndael</param>
        /// <returns>Retorna uma string com a senha descriptografada</returns>
        public string DescriptografiaRijndael(string senha)
        {
            try
            {
                if (!string.IsNullOrEmpty(senha))
                {
                    byte[] bKey = Encoding.UTF8.GetBytes(ChaveCriptografia);
                    byte[] bText = Convert.FromBase64String(senha);

                    Rijndael rijndael = new RijndaelManaged();

                    rijndael.KeySize = 256;

                    MemoryStream mStream = new MemoryStream();

                    CryptoStream decryptor = new CryptoStream(
                        mStream,
                        rijndael.CreateDecryptor(bKey, bIV),
                        CryptoStreamMode.Write);

                    decryptor.Write(bText, 0, bText.Length);
                    decryptor.FlushFinalBlock();
                    return Encoding.UTF8.GetString(mStream.ToArray());
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao descriptografar", ex);
            }
        }
    }
}
