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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace UiTerminalWindows
{
    public partial class FormEleicao : Form
    {
        public FormEleicao()
        {
            InitializeComponent();
        }

        private void FormEleicao_Load(object sender, EventArgs e)
        {
            Eleicao eleicao = new Eleicao();
            bindingSourceEleicao.DataSource = eleicao;
            bindingSourceEleicao.AddNew();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            bindingSourceEleicao.EndEdit();
            EleicaoBLL eleicaoBLL = new EleicaoBLL();
            eleicaoBLL.Inserir((Eleicao)bindingSourceEleicao.Current);
            MessageBox.Show("Salvo com sucesso");
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
