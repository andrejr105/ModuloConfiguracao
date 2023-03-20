using System;
using BLL;
using System.Windows.Forms;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class FromCadastroUsuario : Form
    {
        public int Id;
        public FromCadastroUsuario(int _id = 0)
        {
            InitializeComponent();
            Id= _id;
        }

        private void nomeUsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FromCadastroUsuario_Load(object sender, EventArgs e)
        {
            if(Id == 0)
                usuarioBindingSource.AddNew();    
            else
                usuarioBindingSource.DataSource = new UsuarioBll().BuscarPorId(Id);
        }
        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();

            if (Id == 0)
                new UsuarioBll().Inserir((Usuario)usuarioBindingSource.Current);
            else
                new UsuarioBll().Alterar((Usuario)usuarioBindingSource.Current);

            MessageBox.Show("Registro salvo com sucesso!");
            Close(); 
        }
        private void ButonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
