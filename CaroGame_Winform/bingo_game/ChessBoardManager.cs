using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo_game
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel DrawChessBoard;
        private List<Player> player;
        private int currentPlayer;
        private TextBox PlayerName;
        private PictureBox playerMark;
        private List<List<Button>> matrix;
        #endregion

        #region Initialize
        public ChessBoardManager(Panel ChessBoard, TextBox playerName, PictureBox mark)
        {
            chessboard = ChessBoard;
            PlayerName1 = playerName;
            playerMark = mark;

            player = new List<Player>()
            {
                new Player("boylove", Image.FromFile(Application.StartupPath + "\\Resources\\X_symbol_RGB.png")),
                new Player("muaythai", Image.FromFile(Application.StartupPath + "\\Resources\\O_symbol_RGB.png"))
            };
            currentPlayer = 0;
            changePlayer();
        }
        public Panel chessboard { get => DrawChessBoard; set => DrawChessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName1 { get => PlayerName; set => PlayerName = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        #endregion

        #region Methods
        public void drawChessBoard()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constain.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Constain.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constain.CHESS_WIDTH,
                        Height = Constain.CHESS_HEIGHT,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString(),
                    };
                    btn.Click += Btn_Click;

                    chessboard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Constain.CHESS_HEIGHT);
                oldBtn.Height = 0;
                oldBtn.Width = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackgroundImage != null)
            {
                MessageBox.Show("it's not your turn, are you cheating ?");
                return;
                
                changeMark(btn);
                changePlayer();
                if (isEndGame(btn))
                {
                    endGame();
                }
            }
        }
        #region theWinner
        private void endGame()
        {
            MessageBox.Show("The player is the winner<br>End game ! Press new game to continue");
        }
        private bool isEndGame(Button btn)
        {
            return Horizontal(btn) || Vertical(btn) || primaryDiagonal(btn) || subDiagonal(btn);
        }
        private Point getChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal,vertical);
            return point;
        }
        private bool Horizontal(Button btn)
        {
            Point p = getChessPoint(btn);
            int Left = 0;
            for(int i = p.X; i >= 0; i--)
            {
                if (Matrix[p.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    Left++;
                }
                else
                    break;
            }

            int Right = 0;
            for (int i = p.X + 1; i < Constain.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[p.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    Right++;
                }
                else
                    break;
            }

            return Left + Right == 5;
        }
        private bool Vertical(Button btn)
        {
            Point p = getChessPoint(btn);
            int Top = 0;
            for (int i = p.Y; i >= 0; i--)
            {
                if (Matrix[i][p.X].BackgroundImage == btn.BackgroundImage)
                {
                    Top++;
                }
                else
                    break;
            }

            int Bottom = 0;
            for (int i = p.Y + 1; i < Constain.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][p.X].BackgroundImage == btn.BackgroundImage)
                {
                    Bottom++;
                }
                else
                    break;
            }

            return Top + Bottom == 5;
        }
        private bool primaryDiagonal(Button btn)
        {
            Point p = getChessPoint(btn);
            int countT = 0;
            for (int i = 0; i <= p.X; i++)
            {
                if (p.X - i < 0 || p.Y - i < 0)
                    break;
                if (Matrix[p.Y - 1][p.X - 1].BackgroundImage == btn.BackgroundImage)
                {
                    countT++;
                }
                else
                    break;
            }

            int countB = 0;
            for (int i = 1; i <= Constain.CHESS_BOARD_WIDTH - p.X; i++)
            {
                if (p.Y + i > Constain.CHESS_BOARD_HEIGHT || p.X + i > Constain.CHESS_BOARD_WIDTH)
                    break;
                if (Matrix[p.Y + i][p.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countB++;
                }
                else
                    break;
            }

            return countT + countB == 5;
        }
        private bool subDiagonal(Button btn)
        {
            Point p = getChessPoint(btn);
            int countT = 0;
            for (int i = 0; i <= p.X; i++)
            {
                if (p.X + i > Constain.CHESS_BOARD_WIDTH || p.Y - i < 0)
                    break;
                if (Matrix[p.Y - 1][p.X + 1].BackgroundImage == btn.BackgroundImage)
                {
                    countT++;
                }
                else
                    break;
            }

            int countB = 0;
            for (int i = 1; i <= Constain.CHESS_BOARD_WIDTH - p.X; i++)
            {
                if (p.Y + i >= Constain.CHESS_BOARD_HEIGHT || p.X - i < 0)
                    break;
                if (Matrix[p.Y + i][p.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countB++;
                }
                else
                    break;
            }

            return countT + countB == 5;
        }
        #endregion
        private void changeMark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }
        private void changePlayer()
        {
            PlayerName1.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion
    }
}
