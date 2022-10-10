using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {
        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritméticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar uma variavel tipo inteiro
            int x = 42;
            x = -9;
            //x = "58"
            int meuInteiro = 10;
            string nome = "Leonardo";
            char letra = 'L';
            DateTime dataNascimento = new DateTime(1981, 5, 20);
            bool aprovado = true;
            decimal valor = 22.09m;

            object meuObjeto = 18;
            meuObjeto = "35";
            meuObjeto = false;
            meuObjeto = new DateTime(1981, 5, 20);

            //decimal 1bimestre = 8.5m;
            var nomeCancao = "Release";
            string @class ="5D";
            var a = 2;
            var b = 6;
            var c = 10;
            var d = 13;

            int f;

            resultadoListBox.Items.Add("a = "+ a);
            // outra forma de fazer concatenação ! usando o String.Concat() 
            //cstr() converter para string
            resultadoListBox.Items.Add(string.Concat("b = ",b));
            resultadoListBox.Items.Add(string.Format("c = {0}",c));
            resultadoListBox.Items.Add();
        }
    }
}
