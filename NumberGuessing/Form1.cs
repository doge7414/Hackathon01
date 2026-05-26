namespace NumberGuessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string answer = "";
        private int guessCount=0;

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }
    
        private void StartBtn(object sender, EventArgs e)
        {
            Random random = new Random();
            var numbers = new List<int>();

            while (numbers.Count < 4)
            {
                int n = random.Next(0, 10);
                if (!numbers.Contains(n))      
                    numbers.Add(n);
            }

            answer = string.Concat(numbers);
            guessCount = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add("遊戲開始！猜一個 4 位不重複數字");
            textBox1.Clear();

        }
        private void checkBtn(object sender, EventArgs e)
        {
            if (answer == "")
            {
                MessageBox.Show("請先按「開始遊戲」");
                return;
            }

            string guess = textBox1.Text;

            
            if (guess.Length != 4 || !guess.All(char.IsDigit))
            {
                MessageBox.Show("請輸入 4 位數字");
                return;
            }
            if (guess.Distinct().Count() != 4)
            {
                MessageBox.Show("4 位數字不可重複");
                return;
            }

            // 計算 A 和 B
            int a = 0, b = 0;
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == answer[i])
                    a++;                          
                else if (answer.Contains(guess[i]))
                    b++;                          
            }

            guessCount++;
            listBox1.Items.Add($"第{guessCount}次：{guess} → {a}A{b}B");

            if (a == 4)
            {
                MessageBox.Show($"🎉 答對了！共猜了 {guessCount} 次");
                answer = "";   // 結束遊戲
            }

            textBox1.Clear();

        }
        private void ShowAnswerBtn(object sender, EventArgs e)
        {
            if (answer == "")
                MessageBox.Show("還沒開始遊戲");
            else
                MessageBox.Show($"答案是：{answer}");
        }
        private void ResetBtn(object sender, EventArgs e)
        {
            listBox1.Items.Add($"答案是 {answer}");
            answer = "";
            textBox1.Clear();
        }
    }
}
