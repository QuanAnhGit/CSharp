using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
            {
                get { return chessBoard; }
                set { chessBoard = value; }
            }

        private List<Player> player;
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox PlayerMark { get => playermark; set => playermark = value; }

        private int currentPlayer;

        TextBox playerName;

        PictureBox playermark;
        #endregion

        #region Events
        public event EventHandler PlayerSwitched;
        public event EventHandler EndedGame;
        #endregion


        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox playermark) { 
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = playermark;
            this.Player = new List<Player>() { 
                new Player("AAA", Image.FromFile(Application.StartupPath + "\\Resources\\X.png")),
                new Player("BBB", Image.FromFile(Application.StartupPath + "\\Resources\\O.png"))
            };

            CurrentPlayer = 0;
            ChangePlayerName();
        }
        #endregion


        #region Methods
        public void drawChessBoard()
        {
            Button oldBt = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESSBOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Cons.CHESSBOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldBt.Location.X + oldBt.Width, oldBt.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch

                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);

                    oldBt = btn;
                }
                oldBt.Location = new Point(0, oldBt.Location.Y + Cons.CHESS_HEIGHT);
                oldBt.Width = 0;
                oldBt.Height = 0;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null) return;

            Mark(btn);

            Point point = GetChessPoint(btn);

            if (CheckWin(point))
            {
                MessageBox.Show("Chúc mừng " + Player[CurrentPlayer == 0 ? 1 : 0].Name + " đã giành chiến thắng!");
                ChessBoard.Enabled = false;
            }
            else
            {
                ChangePlayerName();
            }
        }

        private Point GetChessPoint(Button btn)
        {
            int col = btn.Location.X / Cons.CHESS_WIDTH;
            int row = btn.Location.Y / Cons.CHESS_HEIGHT;
            
            return new Point(row, col);
        }

        private bool CheckWin(Point point)
        {
            return CheckLine(point, new Point(0, 1))   // ngang
                || CheckLine(point, new Point(1, 0))   // dọc
                || CheckLine(point, new Point(1, 1))   // chéo chính
                || CheckLine(point, new Point(1, -1)); // chéo phụ
        }

        private bool CheckLine(Point point, Point direction)
        {
            // quân vừa đánh
            Button btn = GetButtonAtPoint(point);
            if (btn == null) return false;
            Image currentMark = btn.BackgroundImage;

            // đếm xuôi
            int count1 = CountDirection(point, direction, currentMark, out Point end1);

            // đếm ngược
            Point opposite = new Point(-direction.X, -direction.Y);
            int count2 = CountDirection(point, opposite, currentMark, out Point end2);

            int total = 1 + count1 + count2; // quân vừa đánh + 2 phía

            // kiểm tra chặn 2 đầu
            bool block1 = IsBlocked(end1, direction, currentMark);
            bool block2 = IsBlocked(end2, opposite, currentMark);

            if (total >= 5 && !(block1 && block2))
                return true;

            return false;
        }

        private int CountDirection(Point start, Point dir, Image mark, out Point endPoint)
        {
            int cnt = 0;
            int x = start.X + dir.X;
            int y = start.Y + dir.Y;

            while (x >= 0 && y >= 0 && x < Cons.CHESSBOARD_HEIGHT && y < Cons.CHESSBOARD_WIDTH)
            {
                Button btn = GetButtonAtPoint(new Point(x, y));
                if (btn != null && btn.BackgroundImage == mark)
                {
                    cnt++;
                    x += dir.X;
                    y += dir.Y;
                }
                else break;
            }

            endPoint = new Point(x, y);
            return cnt;
        }

        private bool IsBlocked(Point pos, Point dir, Image mark)
        {
            int x = pos.X;
            int y = pos.Y;


            // vượt ngoài bàn 
            if (x < 0 || y < 0 || x >= Cons.CHESSBOARD_HEIGHT || y >= Cons.CHESSBOARD_WIDTH)
                return true;

            Button btn = GetButtonAtPoint(new Point(x, y));
            if (btn == null) return true;
            if (btn.BackgroundImage != null && btn.BackgroundImage != mark)
                return true;

            return false;
        }


        private Button GetButtonAtPoint(Point point)
        {
            int index = point.X * Cons.CHESSBOARD_WIDTH + point.Y;
            if (index >= 0 && index < ChessBoard.Controls.Count)
                return ChessBoard.Controls[index] as Button;
            return null;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 0 ? 1 : 0;
        }

        private void ChangePlayerName()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
            PlayerSwitched?.Invoke(this, EventArgs.Empty);
        }

        #endregion


    }
}
