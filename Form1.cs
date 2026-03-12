using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 게임 점수를 저장할 변수
        int score = 0; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 잡았을 때 소리 내기 (청각 피드백) 
            System.Media.SystemSounds.Asterisk.Play();

            // 2. 점수 계산: 클릭 성공 시 100점 추가 [cite: 80]
            score += 100;

            // 3. 난이도 조절: 버튼 크기와 폰트 크기를 현재의 90%로 축소 (10% 축소) [cite: 83]
            MyButton.Width = (int)(MyButton.Width * 0.9);
            MyButton.Height = (int)(MyButton.Height * 0.9);

            MyButton.Font = new Font(MyButton.Font.FontFamily, MyButton.Font.Size * 0.9f, MyButton.Font.Style);

            // 4. 폼 제목 업데이트 및 메시지 박스
            this.Text = $"점수: {score}";
            MessageBox.Show($"축하합니다. 당신은 햄버거 입니다.\n현재 점수는 {score}점 입니다.");
        }

        private void MyButton_MouseEnter(object sender, EventArgs e)
        {
            // 도망갈 때 소리 내기 (청각 피드백)
            SystemSounds.Hand.Play();

            //점수 계산: 도망가면 10점 감점 [cite: 80]
            score -= 10;

            // 1. 난수 생성기 준비
            Random rd = new Random();
           
            // 2. 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            // ClientSize는 타이틀 바와 테두리를 제외한 실제 흰 도화지 영역임
            int maxX = this.ClientSize.Width - MyButton.Width;
            int maxY = this.ClientSize.Height - MyButton.Height;
           
            // 3. 랜덤 좌표 추출 (0 ~ 최대 가용치 사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            
            // 4. 위치 할당 (새로운 Point 객체 생성)
            MyButton.Location = new Point(nextX, nextY);

            // 5. 시각적 피드백 (폼 제목 표시줄에 점수와 좌표 출력)
            this.Text = $"점수: {score} | 버튼 위치: ({nextX}, {nextY})";
        }
    }
}
