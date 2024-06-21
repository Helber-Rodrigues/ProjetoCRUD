using Projeto3Camadas.CODE.BLL;
using Projeto3Camadas.CODE.DTO;

namespace Projeto3Camadas
{
    public partial class FrmCadastroCliente : Form
    {
        BLL_cliente bllCliente = new BLL_cliente();
        DTO_cliente dtoCliente = new DTO_cliente();

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        public void carregarTabela()
        {
            gridView.DataSource = bllCliente.selecionar();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dtoCliente.Nome = txtNome.Text;
            dtoCliente.Email = txtEmail.Text;
            bllCliente.inserir(dtoCliente);
            carregarTabela();
            limpar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dtoCliente.Id_cliente = Convert.ToInt32(txtID.Text);
            dtoCliente.Nome = txtNome.Text;
            dtoCliente.Email = txtEmail.Text;
            bllCliente.alterar(dtoCliente);
            carregarTabela();
            limpar();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtoCliente.Id_cliente = Convert.ToInt32(txtID.Text);
            bllCliente.excluir(dtoCliente);
            carregarTabela();
            limpar();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            carregarTabela();
        }

        private void limpar()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
        }
    }
}
