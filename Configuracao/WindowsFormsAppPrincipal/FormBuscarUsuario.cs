using System;
using System.Windows.Forms;
using BLL;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void ButaoBuscar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new BLL.UsuarioBll().BuscarPorTodos();
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new BLL.UsuarioBll().BuscarPorTodos();
        }

        private void ButonExcluirUsuario_Click(object sender, EventArgs e)
        {
            if(usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Escolha um registro para ser excluído.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

                int id = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBll().Excluir(id);
                usuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso!");
        }
    }
}
