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
            try
            {
                if (Id == 0)
                    new UsuarioBll().Inserir((Usuario)usuarioBindingSource.Current, textBoxComfirmarSenha.Text);
                else
                    new UsuarioBll().Alterar((Usuario)usuarioBindingSource.Current, textBoxComfirmarSenha.Text);

                MessageBox.Show("Registro salvo com sucesso!");
                usuarioBindingSource.EndEdit();
            }
            catch(Exception ex)
            {
                throw new Exception("Errou ao salvar o usuário", ex);
            }
            finally
            {
                Close();
            } 
        }
        private void ButonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
