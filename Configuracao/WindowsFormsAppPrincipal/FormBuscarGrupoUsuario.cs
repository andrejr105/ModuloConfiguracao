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
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                grupoUsuarioBindingSource.DataSource = new BLL.GrupoUsuarioBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario())
            {
                frm.ShowDialog();
            }
            Btn_Buscar_Click(null, null);
        }

        private void nomeGrupoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
            using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario(id))
            {
                frm.ShowDialog();
            }
            Btn_Buscar_Click(null, null);
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (grupoUsuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Escolha um registro para ser excluído.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
            new GrupoUsuarioBLL().Excluir(id);
            grupoUsuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void grupoUsuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
            new GrupoUsuarioBLL().BuscarPorId(id);
        }

        private void permissoesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
