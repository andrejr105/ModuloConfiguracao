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
            grupoUsuarioBindingSource.DataSource = new BLL.GrupoUsuarioBLL().BuscarTodos();
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            new GrupoUsuarioBLL().Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
        }
    }
}
