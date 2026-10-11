using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProj1
{

    public class Board
    {
        private TableLayoutPanel chessBoard;
        public TableLayoutPanel GetChessBoard()
        {
            return chessBoard;
        }
        public Board(int formHeight, int formWidth)
        {
            chessBoard = new TableLayoutPanel();
            chessBoard.Visible = true;
            int boardSize = (int)Math.Min(formHeight, formWidth);
            chessBoard.Size = new Size(boardSize, boardSize);
            chessBoard.RowCount = 8;
            chessBoard.ColumnCount = 8;
            equalSquares();
            colorBoard();
        }
        private void equalSquares()
        {
            for (int i = 0; i < 8; i++)
            {
                // equale space beetwen rows and columns
                chessBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
                chessBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
            }
        }
        private void colorBoard()
        {
            Boolean flag = true;
            for (int j = 0; j < chessBoard.ColumnCount; j++) { 

            for (int i = 0; i < chessBoard.RowCount; i++)
            {
                    Panel square = new Panel();
                    square.Dock = DockStyle.Fill;
                    square.Margin = Padding.Empty;
                    if (flag) 
                        square.BackColor = Color.White;
                    else
                    {
                        square.BackColor = Color.Black;
                    }
                    chessBoard.Controls.Add(square, i, j);
                    flag = !flag;
            }
                flag = !flag;
            }
    }
        public void reSize(int formHeight, int formWidth)
        {
            int boardSize = (int)Math.Min(formHeight, formWidth);
            chessBoard.Size = new Size(boardSize, boardSize);
        }
    
    }
}
