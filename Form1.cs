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
    
    public partial class Form1 : Form
    {
        Board chessBoard;
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.chessBoard = new Board(this.ClientSize.Height, this.ClientSize.Width);
            this.Controls.Add(chessBoard.GetChessBoard());
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            chessBoard.reSize(this.ClientSize.Height, this.ClientSize.Width);
        }
    }

    
}
