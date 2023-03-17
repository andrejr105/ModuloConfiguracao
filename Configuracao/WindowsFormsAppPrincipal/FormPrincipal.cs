using Models;
using System;
using BLL;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            usuario.Nome = "André Carlos";
            usuario.NomeUsuario = "Shaolin Matador de Porco";
            usuario.Ativo = true;
            usuario.CPF = "047.910.521-96";
            usuario.Senha = "3415";
            usuario.Email = "andrejrheringer@gmail.com";

            new UsuarioBll().Inserir(usuario);
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
