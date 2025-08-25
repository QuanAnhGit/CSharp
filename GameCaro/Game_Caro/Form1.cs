using System;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class Form1 : Form
    {
        ChessBoardManager ChessBoard;

        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, pictureMark);

            ChessBoard.PlayerSwitched += ChessBoard_PlayerSwitched;
            ChessBoard.EndedGame += ChessBoard_EndedGame;

            pcbCoolDown.Step = Cons.COOLDOWN_STEP;
            pcbCoolDown.Maximum = Cons.COOLDOWN_TIME;
            pcbCoolDown.Value = 0;

            timerCoolDown.Interval = Cons.COOLDOWN_INTERVAL;

            ChessBoard.drawChessBoard();

            ResetCoolDown();
            timerCoolDown.Start();
        }

        private void ChessBoard_PlayerSwitched(object sender, EventArgs e)
        {
            ResetCoolDown();
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            timerCoolDown.Stop();
        }

        private void ResetCoolDown()
        {
            timerCoolDown.Stop();
            pcbCoolDown.Value = 0;
            timerCoolDown.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void In4OfMatch_Paint(object sender, PaintEventArgs e)
        {

        }


        private void timerCoolDown_Tick(object sender, EventArgs e)
        {
            pcbCoolDown.PerformStep();

            if (pcbCoolDown.Value >= pcbCoolDown.Maximum)
            {
                timerCoolDown.Stop();
                MessageBox.Show(ChessBoard.Player[ChessBoard.CurrentPlayer].Name + " đã hết thời gian! Thua cuộc.");
                pnlChessBoard.Enabled = false;
            }
        }
    }
}

