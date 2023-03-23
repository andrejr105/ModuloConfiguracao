using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultaGrupoUsuario : Form
    {
        public int IdUsuario;
        public void IdUser(int _id)
        {
            IdUsuario = _id;
        }
        public int Id;
        public FormConsultaGrupoUsuario()
        {
            InitializeComponent();
            grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarTodos();
        }

        private void FormConsultaGrupoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorNomeGrupo(textBoxBuscar.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxBuscar_Click(object sender, EventArgs e)
        {

        }

        private void Selecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count > 0)
                {
                    Id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                    new UsuarioBll().AdicionarGrupoUsuario(IdUsuario,Id);
                    Close();
                }
                else
                    MessageBox.Show("Não existe registro para ser selecionado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grupoUsuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
