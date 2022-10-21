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
        List<Cliente> clientes = new();

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
    }
}
