namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "huhu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (object item in listBox1.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            MessageBox.Show(sb.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string? selectedItem = listBox1.Items[listBox1.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = false;
        }
    }
}
