using Fintech.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fintech.Correntista.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // um campo que existe no nivel da classe chama Field 
        // disponibilizar esses elesmentos para todos os metodos dessa classe
        // Campos Privados por isso o uso de privates existe apenas dentro dessa classe por isso um field !

        private List<Cliente> clientes = new();
        private Cliente clienteSelecionado;

        public MainWindow()
        {
            InitializeComponent();
            PopularControles();
        }

        private void PopularControles()
        {
            sexoComboBox.Items.Add(Sexo.Feminino);
            sexoComboBox.Items.Add(Sexo.Masculino);
            sexoComboBox.Items.Add(Sexo.Outro);

            clienteDataGrid.ItemsSource = clientes;

            tipoContaComboBox.Items.Add(TipoConta.ContaCorrente);
            tipoContaComboBox.Items.Add(TipoConta.ContaEspecial);
            tipoContaComboBox.Items.Add(TipoConta.Poupanca);

            Banco banco1 = new Banco();
            banco1.Nome = "Banco 1";
            banco1.Numero = 206;
            bancoComboBox.Items.Add(banco1);

           // mesma forma da instancia de cima porem in line !
            bancoComboBox.Items.Add(new Banco {Nome = "Banco 2", Numero = 211});
           
        }

        private void incluirClienteButton_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cpf = cpfTextBox.Text;
            cliente.DataNascimento = Convert.ToDateTime(dataNascimentoTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Sexo = (Sexo)sexoComboBox.SelectedItem;

            Endereco endereco = new Endereco();
            endereco.Cep = cepTextBox.Text;
            endereco.Cidade = cidadeTextBox.Text;
            endereco.Logradouro = logradouroTextBox.Text;
            endereco.Numero = Convert.ToInt32(numeroLogradouroTextBox.Text);
            endereco.Complemento = complementoTextBox.Text;

            cliente.EnderecoResidencial = endereco;

            clientes.Add(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso");
            LimparControleCliente();
            clienteDataGrid.Items.Refresh();
            pesquisaClienteTabItem.Focus();

        }

        private void LimparControleCliente()
        {
            cpfTextBox.Clear();
            nomeTextBox.Text = "";
            dataNascimentoTextBox.Text = null;
            sexoComboBox.SelectedIndex = -1;
            logradouroTextBox.Clear();
            cidadeTextBox.Clear();
            cepTextBox.Clear();
            complementoTextBox.Clear();
            numeroLogradouroTextBox.Clear();
        }

        private void SelecionarClienteButtonClick(object sender, RoutedEventArgs e)
        {
            // essa simbologia e um cast (Button)sender;
            var botaoClicado = (Button)sender;

            clienteSelecionado = (Cliente)botaoClicado.DataContext;

            clienteTextBox.Text = $"{clienteSelecionado.Nome} - {clienteSelecionado.Cpf}";

            contasTabItem.Focus();
        }

        private void tipoContaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var tipoConta = (TipoConta)tipoContaComboBox.SelectedItem;

            if (tipoConta == TipoConta.ContaEspecial)
            {
                // deixar a opcao de limite habilitado
                limiteDockPanel.Visibility = Visibility.Visible;
                // Nesse caso a baixo deixa ja o | na box para digitar o limite
                limiteTextBox.Focus();
            }
            else
            {
                // nesse caso sera escondido essa box para colocar o limite
                limiteDockPanel.Visibility = Visibility.Collapsed;
            }
        }
    }
}
