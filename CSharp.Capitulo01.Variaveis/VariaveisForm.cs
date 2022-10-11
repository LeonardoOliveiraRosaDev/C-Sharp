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
    //class é um agrupador de métodos
    // quando as variaves estão dentro do método ele ficara var
    // criada no nível da classe será chamada field ai tem que trocar para int
    {

        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;

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
            // podemos colocar tudo em mesma linha como abaixo ! com o c  e o d
            //resultadoListBox.Items.Add(string.Format("c = {0}, d ={1}", c, d));
            resultadoListBox.Items.Add(string.Format("c = {0}", c));
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add($"c * d = {c * d}");
            resultadoListBox.Items.Add($"d / a = {d / a}");
            // o operador modulo % retorna o resto da divisao para saber se e par ou impar
            resultadoListBox.Items.Add($"d % a = {d % a}");
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add(string.Concat("x = "+ x));

            //x = x - 3;
            // temos essa mesma expressão reduzida
            x -= 3;

            resultadoListBox.Items.Add(string.Concat("x = "+ x ));


        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // incremento e decremento ....

            int a;
            a = 5;
            resultadoListBox.Items.Add("Exemplo de pré-incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + ++a = {2 + ++a}");
            resultadoListBox.Items.Add("a = " + a);

            
            a = 5;
            resultadoListBox.Items.Add("Exemplo de pós-incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + a++ = {2 + a++}");
            resultadoListBox.Items.Add("a = " + a);
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // declarando variáveis
            //resultadoListBox.Items.Add("-----------------------------------------------");
            //resultadoListBox.Items.Add("Variáveis Declaradas");
            //resultadoListBox.Items.Add("-----------------------------------------------");

            // Imprimindo na tela
            resultadoListBox.Items.Add("-----------------------------------------------");
            resultadoListBox.Items.Add("Os Valores de cada Variável");
            resultadoListBox.Items.Add("-----------------------------------------------");
            ExibirValores();
            resultadoListBox.Items.Add(" ");
            // Fazendo a comparação !
            // Menor ou Igual
            resultadoListBox.Items.Add("---------------------------------------------------------------");
            resultadoListBox.Items.Add("Comparando se w e maior ou igual a x");
            resultadoListBox.Items.Add("---------------------------------------------------------------");
            resultadoListBox.Items.Add($" w <= x = {w <= x}");
            resultadoListBox.Items.Add(" ");
            //x é igual a z
            resultadoListBox.Items.Add("-----------------------------------------------");
            resultadoListBox.Items.Add("Comparando sex é igual a z");
            resultadoListBox.Items.Add("-----------------------------------------------");
            resultadoListBox.Items.Add($" x == z = {x == z}");
            resultadoListBox.Items.Add(" ");
            // x é diferente de z
            resultadoListBox.Items.Add("-----------------------------------------------------");
            resultadoListBox.Items.Add("Comparando se x é diferente de z");
            resultadoListBox.Items.Add("-----------------------------------------------------");
            resultadoListBox.Items.Add($" x != z = {x != z}");
            resultadoListBox.Items.Add(" ");
        }

        private void ExibirValores()
        {
            resultadoListBox.Items.Add("x = " + x);
            resultadoListBox.Items.Add("y = " + y);
            resultadoListBox.Items.Add("w = " + w);
            resultadoListBox.Items.Add("z = " + z);
        }

        private void logicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }
    }
}
