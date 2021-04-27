using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio16
{
    class Listagem
    {
        public static string ListaGeral()
        {
            if (File.Exists("jogos.txt"))
            {
                string retorno = string.Empty;
                string[] listagem = File.ReadAllLines("jogos.txt");
                foreach (var lista in listagem)
                {
                    retorno += lista;
                    retorno += Environment.NewLine;
                    retorno += "###################";
                    retorno += Environment.NewLine;


                }
                return retorno;
            }
            else
            {
                throw new Exception("O arquivo não existe ");
            }
        }

        public static string ListaGeral(EnumDificuldade dificuldade)
        {

            if (File.Exists("jogos.txt"))
            {
                string retorno = string.Empty;
                string criterio = dificuldade.ToString();
                string[] listagem = File.ReadAllLines("jogos.txt");
                foreach (var lista in listagem)
                {
                    string[] buscacriterio = lista.Split('|');
                    if (buscacriterio[2] == criterio)
                    {
                        retorno += lista;
                        retorno += Environment.NewLine;
                        retorno += "###################";
                        retorno += Environment.NewLine;
                    }
                }
                return retorno;
            }
            else
            {
                throw new Exception("O arquivo não existe ");
            }



        }

    }
}
