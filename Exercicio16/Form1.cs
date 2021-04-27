using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercicio16
{
    public partial class Form1 : Form
    {
        List<fabricante> Fabricante;
        List<Jogo> Lista;
        Jogo novojogo;


        public Form1()
        {
            InitializeComponent();
            cbDificuldade.DataSource = Enum.GetValues(typeof(EnumDificuldade));
            Fabricante = new List<fabricante>();
            Fabricante.Add(new fabricante(1, "Konami"));
            Fabricante.Add(new fabricante(2, "Capcom"));
            Fabricante.Add(new fabricante(3, "Nintendo"));
            Fabricante.Add(new fabricante(4, "EA"));
            Fabricante.Add(new fabricante(5, "Acclaim"));
            Fabricante.Add(new fabricante(6, "IronHide"));
            Fabricante.Add(new fabricante(7, "SEGA"));
            cbFabricante.DataSource = Fabricante;
            cbFabricante.DisplayMember = "Nome";
            cbPesquisa.DataSource = Enum.GetValues(typeof(EnumDificuldade));
            Lista = new List<Jogo>();







        }

        public  double Adicaoprecojogo(int percentual)
        {
            var porcentagem = ((double)percentual / 100) * Convert.ToDouble(txtvalor.Text);
            
            return Convert.ToDouble(txtvalor.Text) + porcentagem;
        }

        public double Adicaoprecojogo(double adicao)
        {
            return Convert.ToDouble(txtvalor.Text) + adicao;
        }

        private void btn_Carregar(object sender, EventArgs e)
        {
            txtLista.Clear();
            if (rbdificuldade.Checked)
            {
                txtLista.Text = Listagem.ListaGeral((EnumDificuldade)cbPesquisa.SelectedItem);
            }
            if (rbtodos.Checked)
            {

                txtLista.Text = Listagem.ListaGeral();
            }

        }

        private void btnPorcentage_Click(object sender, EventArgs e)
        {
            
            try
            {
                int adicaoporcent = Convert.ToInt32(txtporcentagem.Text);
                txtvalor.Text = Adicaoprecojogo(Convert.ToInt32(adicaoporcent)).ToString();
            }
            catch
            {
                MessageBox.Show("Porcentagem Invalida!");
            }

        }

        private void btnValor_Click(object sender, EventArgs e)
        {
          

            try
            {
                double Adicao = Convert.ToDouble(txtvaloradicao.Text);
                txtvalor.Text = Adicaoprecojogo(Adicao).ToString();
               
            }
            catch
            {
                MessageBox.Show("Valor Invalido!");
            }
        }

      

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            try
            {
                novojogo = new Jogo();
                novojogo.Codigo = Convert.ToInt32(txtcodigo.Text);
                novojogo.Descricao = txtdescricao.Text;
                novojogo.Dificuldade = (EnumDificuldade)cbDificuldade.SelectedItem;
                novojogo.Fabricante = cbFabricante.SelectedItem as fabricante;
                novojogo.Valor = Convert.ToDouble(txtvalor.Text);


                Lista.Add(novojogo);


                MessageBox.Show("Salvo!");

            }
            catch (Exception error)
            {
                MessageBox.Show("Error :" + error);
                return;
            }

            string texto = novojogo.Codigo
                    + "|"
                    + novojogo.Descricao
                    + "|"
                    + novojogo.Dificuldade.ToString()
                    + "|"
                    + novojogo.Fabricante.Codigo
                    + " -- "
                    + novojogo.Fabricante.Nome
                     + "|"
                    + $"R$ { novojogo.Valor:f2}"

                    + Environment.NewLine;
            File.AppendAllText("jogos.txt", texto, Encoding.UTF8);

            txtcodigo.Clear();
            txtdescricao.Clear();
            txtvalor.Clear();
            
        }
    }
}


