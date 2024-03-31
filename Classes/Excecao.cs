using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe responsável por realizar logs das exceções em um arquivo de texto.
    /// </summary>
    internal class Excecao
    {
        /// <summary>
        /// Identificador da exceção (gerenciado pelo arquivo/banco de dados).
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Método onde a exceção ocorreu.
        /// </summary>
        public string Metodo { get; }
        /// <summary>
        /// Data e hora em que a exceção ocorreu.
        /// </summary>
        public DateTime DataHora = DateTime.Now;
        /// <summary>
        /// Mensagem de erro associada à exceção.
        /// </summary>
        public string MensagemErro { get; }
        /// <summary>
        /// Caminho do arquivo onde a exceção será registrada.
        /// </summary>
        public string Arquivo { get; }
        /// <summary>
        /// Objeto responsável por lidar com a escrita do log no arquivo de texto.
        /// </summary>
        public TXT TXT_ { get; }

        /// <summary>
        /// Inicializa uma nova instância da classe Excecao.
        /// </summary>
        /// <param name="metodo">O método onde a exceção ocorreu.</param>
        /// <param name="mensagemErro">A mensagem de erro associada à exceção.</param>
        /// <param name="arquivo">O caminho do arquivo onde a exceção será registrada.</param>
        public Excecao(string metodo, string mensagemErro, string arquivo)
        {
            if (string.IsNullOrEmpty(metodo) || string.IsNullOrEmpty(mensagemErro))
                throw new ArgumentNullException("");

            Metodo = metodo;
            MensagemErro = mensagemErro;
            Arquivo = arquivo;

            TXT_ = new TXT(Arquivo, null);
        }

        /// <summary>
        /// Formata a exceção para ser registrada no arquivo de texto.
        /// </summary>
        /// <returns>Uma coleção de strings contendo o conteúdo formatado da exceção.</returns>
        private IEnumerable<string> FormataCadastroExcecao()
        {
            // Cria uma lista de strings para armazenar a única linha de conteúdo
            List<string> conteudo = [$"{TXT_.NumeroLinhasArquivo() + 1} | {Metodo} | {MensagemErro} | {DataHora}"];

            // Retorna a lista de conteúdo
            return conteudo;
        }

        /// <summary>
        /// Registra a exceção no arquivo de texto.
        /// </summary>
        public void LogaExcecaoTXT()
        {
            // Cria o arquivo se não existir
            if (!File.Exists(TXT_.CaminhoArquivo))
                File.Create(TXT_.CaminhoArquivo);

            // Formata o conteúdo da exceção e define no objeto TXT
            TXT_.Conteudo = FormataCadastroExcecao();

            // Escreve a exceção no arquivo de texto
            TXT_.EscreveTXT(true);
        }
    }
}
