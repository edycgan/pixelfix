namespace PixelFix
{
    public partial class Form1 : Form
    {
        private frmRunner form;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form = new frmRunner();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            form.Show();
            form.Size = new Size(3, 3);
            form.Left = 1617;
            form.Top = 1573;
            form.tmrRunner.Enabled = true;
        }
    }
}