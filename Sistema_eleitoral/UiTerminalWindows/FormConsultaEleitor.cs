using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiTerminalWindows
{
    public partial class FormConsultaEleitor : Form
    {
        public FormConsultaEleitor()
        {
            InitializeComponent();
        }

        private void FormConsultaEleitor_Load(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTitulo("");

        }
        private void button_Buscar_Click(object sender, EventArgs e)
        {
            EleitorBLL eleitor = new EleitorBLL();
            bindingSourceEleitor.DataSource = eleitor.BuscarPorTitulo(textBoxBuscar.Text);

        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleitor frm = new FormCadastroEleitor())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja mesmo excluir este eleitor?", "Atençao", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            EleitorBLL eleitorBLL = new EleitorBLL();

            eleitorBLL.Excluir(Convert.ToInt32(((DataRowView)bindingSourceEleitor.Current).Row["id"]));

            MessageBox.Show("Registro excluido com sucesso");
            {

            }
        }
    }
}

