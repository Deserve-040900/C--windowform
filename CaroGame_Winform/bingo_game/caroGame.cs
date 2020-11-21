using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo_game
{
    public partial class Form : System.Windows.Forms.Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlDrawChessBoard, txbPlayerName, pctBoxMark);
            ChessBoard.drawChessBoard();
        }
    }
}
