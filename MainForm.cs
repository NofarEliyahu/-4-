namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.Text = "MainForm";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            
        }

        private void viewSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;
            viewForm.Show();
        }
    }
}
