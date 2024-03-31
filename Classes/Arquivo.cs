using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe abstrata que representa um arquivo genérico. Define propriedades e comportamentos comuns a todos os arquivos.
    /// </summary>
    internal abstract class Arquivo
    {
        public string CaminhoArquivo { get; set; }

        /// <summary>
        /// Construtor da classe abstrata Arquivo.
        /// </summary>
        /// <param name="arquivo">O caminho do arquivo.</param>
        /// <exception cref="ArgumentNullException">Lançada quando o caminho do arquivo é nulo ou vazio.</exception>
        protected Arquivo(string arquivo)
        {
            if (string.IsNullOrEmpty(arquivo))
                throw new ArgumentNullException("O caminho do arquivo não pode ser nulo ou vazio!");

            CaminhoArquivo = arquivo;
        }
    }
}
