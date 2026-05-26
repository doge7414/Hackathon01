using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "攝氏 → 華氏";
            radioButton2.Text = "華氏 → 攝氏";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double value))
            {
                label1.Text = "請輸入正確數字";
                return;
            }

            if (radioButton1.Checked)
            {
                double f = value * 9.0 / 5 + 32;
                label1.Text = $"結果：{value}℃ = {f:F1}℉";
            }
            else if (radioButton2.Checked)
            {
                double c = (value - 32) * 5.0 / 9;
                label1.Text = $"結果：{value}℉ = {c:F1}℃";
            }
            else
            {
                label1.Text = "請選擇轉換方式";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            var btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
            if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }
    }

}
//private void button5_Click(object sender, EventArgs e)
//{

//}
//private void button3_Click(object sender, EventArgs e)
//{

//}