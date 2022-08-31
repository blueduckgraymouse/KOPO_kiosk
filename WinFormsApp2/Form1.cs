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
  
            Label label1 = new Label();
            String result = "";

            if (radioButton1.Checked)
                result += radioButton1.Text;
            else if (radioButton2.Checked)
                result += radioButton2.Text;

          if (textBox1.Text == "")
                MessageBox.Show("이름을 입력하세요", "Warning");
          else if(textBox2.Text != "A" && textBox2.Text !="a" && textBox2.Text !="b" && textBox2.Text != "B")
                MessageBox.Show("소속반을 다시 확인해주세요", "Warning");
          else if(textBox2.Text == "")
                MessageBox.Show("소속반을 입력하세요", "Warning");

          else MessageBox.Show("소속 반 : " + textBox2.Text + "   이름 : " + textBox1.Text + "\n선택한 메뉴 : " + result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}