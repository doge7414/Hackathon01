namespace ConvertTemperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button2_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button3_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button4_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button5_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button6_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button7_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button8_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button9_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button10_Click(object sender, EventArgs e) { BtnNumber(sender, e); }
        private void button11_Click(object sender, EventArgs e) { BtnNumber(sender, e); }


        private void BtnNumber(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            textBox1.Text += btn.Text;
        }
        // 轉換按鈕
        private void button12_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double input))
            {
                label1.Text = "請輸入有效數字";
                return;
            }

            string result = "";

            foreach (var item in checkedListBox1.CheckedItems)
            {
                switch (item.ToString())
                {
                    case "攝氏轉換為華氏":
                        result += $"華氏：{input * 9 / 5 + 32:F2} °F\n";
                        break;
                    case "華氏轉換為攝氏":
                        result += $"攝氏：{(input - 32) * 5 / 9:F2} °C\n";
                        break;

                }
            }

            label1.Text = string.IsNullOrEmpty(result) ? "請勾選轉換項目" : result;
        }

        // 清除按鈕
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}