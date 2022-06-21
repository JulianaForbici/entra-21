using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private List<Paciente> pacientes;
        private int codigo = 0;

        private int quantidadeLinhaSelecionada = -1;

        private int codigoSelecionado = -1;


        public PacientesForm()
        {
            InitializeComponent();

            //CRIA UMA LISTA DE OBJETOS PARA ARMAZENAR OS Pacientes
            pacientes = new List<Paciente>();

            //Ler do arquivo Json os pacientes cadastrados anteriormente
            LerArquivoApresentandoPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            // Calcular imc
            var imc = CalcularImc(peso,altura);

            // Verifica se esta em modo adição
            if (quantidadeLinhaSelecionada == -1)
            {
                // Adicionar linha no dataGridView do paciente
                dataGridView1.Rows.Add(new object[]{
             ++codigo, nome, altura, peso, imc.ToString("F")
            });

                textBoxNome.Text = "";
                textBoxAltura.Text = "";
                textBoxPeso.Text = "";

                return;
            }

            dataGridView1.Rows[quantidadeLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[quantidadeLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[quantidadeLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[quantidadeLinhaSelecionada].Cells[4].Value = imc.ToString("F");

            quantidadeLinhaSelecionada = -1;
            textBoxNome.Text = "";
            textBoxAltura.Text = "";
            textBoxPeso.Text = "";
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Pegar o indice da linha selecionada
            var quantidadeLinhaSelecionada = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhaSelecionada == 0)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Verifica se o usuário escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                // Remove a linha utilizando o índice do DataGridView
                dataGridView1.Rows.RemoveAt(quantidadeLinhaSelecionada);

                //Remove o paciente da lista de pacientes
                pacientes.RemoveAt(quantidadeLinhaSelecionada);

                //Atualiza o arquivo com lista de pacientes sem o paciente removido
                SalvarEmArquivo();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            quantidadeLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (quantidadeLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }

            // Obter a linha que o usuário selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter a informação da linha selecionada passado a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }
        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[quantidadeLinhaSelecionada].Nome = nome;
            pacientes[quantidadeLinhaSelecionada - 1].Peso = peso;
            pacientes[quantidadeLinhaSelecionada + 1].Altura = altura;

            SalvarEmArquivo();

            LimparCampos();
        }
        private void LimparCampos()
        {
            textBoxPeso.Text = "";
            textBoxNome.Text = "";
            textBoxAltura.Text = "";

            quantidadeLinhaSelecionada = -1;

            dataGridView1.ClearSelection();
        }
        private void SalvarDados(int codigo, string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = codigo,
                Nome = nome,
                Altura = altura,
                Peso = peso
            };
            //var paciente = new Paciente();
            //paciente.Codigo = codigo;
            //paciente.Nome = nome;

            pacientes.Add(paciente);

        }
        private void SalvarEmArquivo()
        {
            //Converter uma lista de objetos em uma string contendo o JSON
            var pacienteEmJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.json";
            //Salvar a string contendo o JSON em um arquivo no formato Json
            File.WriteAllText(caminho, pacienteEmJson);
        }
        private void LerArquivoApresentandoPacientes()
        {
            //Validar se arquivo não existe, consequentemente não é necessário percorrer uma lista que não existe
            if (File.Exists("pacientes.json") == false)
                return;
            //Ler arquivo json e armazenar os pacientes na lista de pacientes
            var conteudoArquivo = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);
            int maiorCodigo = 0;

            //Cria uma variavel para armazenar o codigo do ultimo produto, para quando
            // cadastrar um novo armazenar o código correto
            for (int i = 0; i < pacientes.Count; i++)
            {
                //Obtem o paciente que esta sendo percorrido
                var paciente = pacientes[i];
                //Adicionar o paciente que estava no arquivo de json no DataGridView
                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo, paciente.Nome,
                    paciente.Altura, paciente.Peso, 2.0
                });
                //rotina para descobrir o paciente com o maior código
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;

            }
            //Validar se conseguiu encontrar algumcodigo, caso contrario n deve atualiazar o codigo de novo paciente
            if (maiorCodigo != int.MinValue)
                codigo = maiorCodigo;
        }
        private double CalcularImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
