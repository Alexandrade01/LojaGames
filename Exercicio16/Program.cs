using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio16
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// </summary>
        /// 
        ///


        /*16.	

        Crie uma classe para representar jogos.
        Deve haver os seguintes campos:


        Codigo  : int  ( > 0)
        Descricao  : string (obrigatório)
        Dificuldade: Enumerador(easy, normal, hard) (obrigatório)
        Valor : double  >= 1,00
        Fabricante : Obrigatório.Exiba uma lista(ou caixa combo) de fabricantes e permita que o usuário selecione 1 valor da lista.

        Deve haver 2 métodos sobrecarregados para atualizar o preço dos jogos.Um deles deverá receber por parâmetro um inteiro que representa o percentual que será aplicado sobre o preço do jogo.O outro deverá receber por parâmetro um double que representa o valor em reais que deverá ser adicionado ao preço do jogo.

        Crie a classe fabricante:
        Fabricante (int codigo, string nome)
        Crie uma lista com os seguintes fabricantes (pode ser fixo, no código)
        { 1 – Konami}  { 2 – Capcom
        }  { 3  - Nintendo
        }
        { 4 – EA}
        { 5 – Acclaim}
        { 6 – IronHide }
        { 7 – SEGA }

        No formulário para teste da classe, inclua os botões para salvar a Lista (que irá salvar todos os objetos da lista em um arquivo texto, usando para isso o salvar que há disponível na classe Jogo) e um botão para carregar, que irá preencher uma lista com os objetos carregados do arquivo.

        Deve haver um botão para listar todos os jogos cadastrados (verificar na lista).  
        O mesmo botão deve listar apenas os jogos de uma determinada dificuldade caso seja selecionada a dificuldade em uma caixa combo que ficará ao lado do botão. Para estes 2 utilize sobrecarga de métodos (métodos com o mesmo nome porém com parâmetros diferentes).

        Adicione também dois botões para realizar os aumentos de preço nos jogos.
        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
