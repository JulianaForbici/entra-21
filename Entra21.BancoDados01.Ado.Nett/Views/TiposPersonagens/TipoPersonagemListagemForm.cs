using Entra21.BancoDados01.Ado.Nett.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Nett.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;
        public TipoPersonagemListagemForm()
        {
            InitializeComponent();
            // Instanciando objeto da classe TipoPersonagemService para permitir:
            // Listar Todos, Editar e Apagar
            tipoPersonagemService = new TipoPersonagemService();
        }

        private void TipoPersonagemListagemForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicaoForm = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }
        private void AtualizarRegistrosDataGridView()
        {

            // Obter todos os tipos de personagens cadastrados na tabela 
            // tipos_personagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            // removido todos os registros do dataGridView1
            dataGridViewTipoPersonagem.Rows.Clear();

            // Percorrido todos os tipos de personagens encontrados para 
            // adicionar no DataGridView permitindo o usuário visualiza-los
            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridViewTipoPersonagem.Rows.Add(new object[]
                {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewTipoPersonagem.SelectedRows[0].Cells[0].Value);

           tipoPersonagemService.Apagar(id);

            MessageBox.Show("Registro apagado com sucesso.");
        }
    }
}
