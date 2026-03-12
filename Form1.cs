namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 1. 랜덤 숫자를 만들기 위한 도구 준비
            Random rand = new Random();

            // 2. 버튼이 움직일 수 있는 안전한 최대 범위 계산 
            // 폼의 전체 너비에서 버튼의 너비를 빼야 버튼이 오른쪽 벽 뚫고 나가지 않음
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;

            // 3. 범위 안에서 랜덤한 X, Y 좌표 생성
            int nextX = rand.Next(0, maxX);
            int nextY = rand.Next(0, maxY);

            // 4. 버튼의 위치를 새로운 좌표로 이동 
            button1.Location = new Point(nextX, nextY);

            // 5. 폼 제목에 현재 좌표 실시간 표시 
            this.Text = $"버튼 위치: ({nextX}, {nextY})";
        }
    }
}
