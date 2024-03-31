using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe concreta que representa a implementação de um arquivo TXT. Implementação concreta que herda de arquivo.
    /// </summary>
    internal class TXT : Arquivo
    {
        /// <summary>
        /// Obtém ou define o conteúdo do arquivo TXT.
        /// </summary>
        public IEnumerable<string>? Conteudo { get; set; }

        /// <summary>
        /// Construtor para a classe TXT, que inicializa uma instância de TXT com as informações fornecidas.
        /// </summary>
        /// <param name="arquivo">O caminho do arquivo TXT.</param>
        /// <param name="conteudo">O conteúdo do arquivo TXT.</param>
        public TXT(string arquivo, IEnumerable<string>? conteudo) : base(arquivo)
        {
            Conteudo = conteudo;
        }

        /// <summary>
        /// Escreve o conteúdo em um arquivo TXT, permitindo preservar o conteúdo existente ou substituí-lo.
        /// </summary>
        /// <param name="preservarConteudo">Indica se o conteúdo existente no arquivo deve ser preservado. 
        /// Se verdadeiro, o conteúdo existente será mantido e novas linhas serão adicionadas no final do arquivo. 
        /// Se falso, o conteúdo existente será substituído pelo novo conteúdo.</param>
        public void EscreveTXT(bool preservarConteudo = true)
        {
            if (Conteudo != null)
            {
                if (preservarConteudo)
                {
                    // Adiciona as linhas do conteúdo no final do arquivo
                    File.AppendAllLines(CaminhoArquivo, Conteudo);
                }
                else
                {
                    // Escreve as linhas do conteúdo no arquivo
                    File.WriteAllLines(CaminhoArquivo, Conteudo);
                }
            }
        }

        /// <summary>
        /// Obtém o número de linhas do arquivo TXT.
        /// </summary>
        /// <returns>O número de linhas do arquivo.</returns>
        public int NumeroLinhasArquivo()
        {
            // Lê todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(CaminhoArquivo);

            return linhas.Length;
        }
    }
}
