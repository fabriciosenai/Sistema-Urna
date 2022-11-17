using BLL;
using Models;

namespace UiTerminalWindows
{
    public partial class FormCadastroEleitor : Form
    {
        public FormCadastroEleitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSourceEleitor.EndEdit();
            
            EleitorBLL eleitorBLL = new EleitorBLL();

            eleitorBLL.Inserir((Eleitor)bindingSourceEleitor.Current);

            MessageBox.Show("Eleitor salvo com sucesso!");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eleitor eleitor = new Eleitor();
            bindingSourceEleitor.DataSource = eleitor;
            bindingSourceEleitor.AddNew();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Eleitor eleitor = new Eleitor();
            bindingSourceEleitor.DataSource = eleitor;
            bindingSourceEleitor.AddNew();
        }
    }
}