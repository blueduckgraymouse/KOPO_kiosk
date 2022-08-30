namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메세지다");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newform2 = new Form2();
            newform2.ShowDialog();
        }
    }
}