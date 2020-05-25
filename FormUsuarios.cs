using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;

namespace Sistema
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            this.tbususarioBindingSource.DataSource = DataContextFactory.DataContext.tb_ususario;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.tbususarioBindingSource.AddNew();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.tbususarioBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Inserida com Sucesso!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.tbususarioBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Excuida com Sucesso!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tbususarioBindingSource.CancelEdit();
        }


        private bool valida()
        {
            if (txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo categoria é obrigatorio");
                txtNome.Focus();
                return false;
            }
            return true;
        }
    }
}
