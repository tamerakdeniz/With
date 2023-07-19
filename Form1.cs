namespace arama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text.StartsWith(textBox2.Text).ToString();
            textBox5.Text = textBox1.Text.EndsWith(textBox4.Text).ToString();

            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            
            if (textBox1.Text.StartsWith(textBox2.Text))
                listBox1.Items.Add("'" + textBox1.Text + "'" + " Cümlesinin İlk Bölmesi '" + textBox2.Text + "'dir.");
            else
                listBox1.Items.Add("'" + textBox1.Text + "'" + " Cümlesinin İlk Bölmesi " + "'" + textBox2.Text + "'" + " değildir.");
           
            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            
            if (textBox1.Text.EndsWith(textBox4.Text))
                listBox1.Items.Add("'" + textBox1.Text + "'" + " Cümlesinin Son Bölmesi '" + textBox4.Text + "'dir.");
            else
                listBox1.Items.Add("'" + textBox1.Text + "'" + " Cümlesinin Son Bölmesi " + "'" + textBox4.Text + "'" + " değildir.");
            
            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}