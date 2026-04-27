using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel; // Necessário para BindingList

namespace AgendaContatos
{
    public partial class Form1 : Form
    {
        private const string NomeArquivo = "contatos.txt";
        // BindingList atualiza a ListBox automaticamente quando você adiciona/remove itens
        private BindingList<Contato> listaContatos = new BindingList<Contato>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarInterface();
        }

        private void ConfigurarInterface()
        {
            lstContatos.DataSource = listaContatos;
            // Melhora a visualização com fonte monoespaçada para alinhar o "pipe" |
            lstContatos.Font = new System.Drawing.Font("Consolas", 10);
        }

        private void Form1_Load(object sender, EventArgs e) => CarregarContatos();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var novo = new Contato { Nome = txtNome.Text.Trim(), Telefone = txtTelefone.Text.Trim() };

            listaContatos.Add(novo);
            SalvarContatos();
            LimparCampos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            return true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstContatos.SelectedItem is Contato selecionado)
            {
                var msg = $"Tem certeza que deseja excluir {selecionado.Nome}?";
                if (MessageBox.Show(msg, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listaContatos.Remove(selecionado);
                    SalvarContatos();
                }
            }
        }

        private void SalvarContatos()
        {
            try
            {
                var linhas = listaContatos.Select(c => $"{c.Nome} | {c.Telefone}");
                File.WriteAllLines(NomeArquivo, linhas);
            }
            catch (Exception ex)
            {
                MostrarErro("Erro ao salvar", ex);
            }
        }

        private void CarregarContatos()
        {
            if (!File.Exists(NomeArquivo)) return;

            try
            {
                var linhas = File.ReadAllLines(NomeArquivo);
                listaContatos.Clear();
                foreach (var linha in linhas)
                {
                    var c = Contato.DaLinha(linha);
                    if (c != null) listaContatos.Add(c);
                }
            }
            catch (Exception ex)
            {
                MostrarErro("Erro ao carregar", ex);
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void MostrarErro(string titulo, Exception ex)
            => MessageBox.Show($"{titulo}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}