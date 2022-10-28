using Fintech.Dominio.Entidades;
using Fintech.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.IO;
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

        private readonly List<Cliente> clientes = new();
        private Cliente clienteSelecionado;
        private readonly MovimentoRepositorio movimentoRepositorio = new MovimentoRepositorio(Properties.Settings.Default.CaminhoArquivoMovimento);

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
            bancoComboBox.Items.Add(new Banco { Nome = "Banco 2", Numero = 211 });

            operacaoComboBox.Items.Add(TipoOperacao.Deposito);
            operacaoComboBox.Items.Add(TipoOperacao.Saque);

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
            SelecionarCliente(sender);

            clienteTextBox.Text = $"{clienteSelecionado.Nome} - {clienteSelecionado.Cpf}";

            contasTabItem.Focus();
        }

        private void SelecionarCliente(object sender)
        {
            var botaoClicado = (Button)sender;

            clienteSelecionado = (Cliente)botaoClicado.DataContext;
        }

        private void tipoContaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (tipoContaComboBox.SelectedItem == null)
            {
                return;
            }

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

        private void incluirContaButton_Click(object sender, RoutedEventArgs e)
        {
            Conta conta = null;

            Agencia agencia = new Agencia();

            agencia.Banco = (Banco)bancoComboBox.SelectedItem;
            agencia.Numero = Convert.ToInt32(numeroAgenciaTextBox.Text);
            agencia.DigitoVerificador = Convert.ToInt32(dvAgenciaTextBox.Text);

            var numero = Convert.ToInt32(numeroContaTextBox.Text);
            var digitoVerificador = dvContaTextBox.Text;

            switch ((TipoConta)tipoContaComboBox.SelectedItem)
            {
                case TipoConta.ContaCorrente:
                    conta = new ContaCorrente(agencia, numero, digitoVerificador);
                    break;
                case TipoConta.ContaEspecial:
                    var limite = Convert.ToDecimal(limiteTextBox.Text);
                    conta = new ContaEspecial(agencia, numero, digitoVerificador, limite);
                    break;
                case TipoConta.Poupanca:
                    conta = new Poupanca(agencia, numero, digitoVerificador);
                    break;
            }

            //clienteSelecionado.Contas = new List<Conta>();

            clienteSelecionado.Contas.Add(conta);
            MessageBox.Show("Conta adicionada com sucesso");
            LimparControlesConta();
            clienteDataGrid.Items.Refresh();
            clientesTabItem.Focus();
        }

        private void LimparControlesConta()
        {
            clienteTextBox.Clear();
            bancoComboBox.SelectedIndex = -1;
            numeroAgenciaTextBox.Clear();
            dvAgenciaTextBox.Clear();
            numeroContaTextBox.Clear();
            dvContaTextBox.Clear();
            tipoContaComboBox.SelectedIndex = -1;
            limiteTextBox.Clear();
        }

        private void SelecionarContaButtonClick(object sender, RoutedEventArgs e)
        {
            SelecionarCliente(sender);

            contaTextBox.Text = $"{clienteSelecionado.Nome} - {clienteSelecionado.Cpf}";

            contaComboBox.ItemsSource = clienteSelecionado.Contas;
            contaComboBox.Items.Refresh();

            LimparControlesOperacoes();

            operacoesTabItem.Focus();
        }

        private void LimparControlesOperacoes()
        {
            contaComboBox.SelectedIndex = -1;
            operacaoComboBox.SelectedIndex = -1;
            valorTextBox.Clear();
            movimentacaoDataGrid.ItemsSource = null;
            saldoTextBox.Clear();
        }

        private void contaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (contaComboBox.SelectedItem == null) return;

            var conta = (Conta)contaComboBox.SelectedItem;

            conta.Movimentos = movimentoRepositorio.Selecionar(conta.Agencia.Numero, conta.Numero);

            movimentacaoDataGrid.ItemsSource = conta.Movimentos;
            saldoTextBox.Text = conta.Saldo.ToString("C");
        }

        private void incluirOperacaoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var conta = (Conta)contaComboBox.SelectedItem;
                var operacao = (TipoOperacao)operacaoComboBox.SelectedItem;
                var valor = Convert.ToDecimal(valorTextBox.Text);

                var movimento = conta.EfetuarOperacao(valor, operacao);



                movimentoRepositorio.Inserir(movimento);

                movimentacaoDataGrid.ItemsSource = conta.Movimentos;
                movimentacaoDataGrid.Items.Refresh();

                saldoTextBox.Text = conta.Saldo.ToString("C");
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"O arquivo {ex.FileName} não foi encontrado !");
            }

            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"O diretório {Properties.Settings.Default.CaminhoArquivoMovimento} não foi encontrado ");
            }

            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception excecao)
            {

                MessageBox.Show("Eita! Algo deu errado em breve teremos uma solução.");
                //Logar(execao);//log4Net
            }


            finally
            {
                // é sempre executado , mesmo que haja um return no código !
            }
        }
    }
}