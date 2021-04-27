using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    

    class Jogo
    {
        
        private int codigo;
        private string descricao;
        private double valor;
        public EnumDificuldade Dificuldade { get; set; }
        public fabricante Fabricante { get; set; }

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Código Invalido!");
                }
                codigo = value;
            }
        }
        public string Descricao
        {
            get => descricao;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Descrição invalida!");
                }
                descricao = value;
            }
        }
        public double Valor
        {
            get => valor; set
            {
                if (value < 0)
                {
                    throw new Exception("Valor  Invalido!");
                }
                valor = value;
            }
        }

       
    }
}

        
        
        







