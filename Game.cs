using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    /*
     the Game Contains all the squares of the game
     */
    public class Game
    {
        public Panel panelSquares; // buttons container 
        private Square[,] squares; // array of the buttons
        private int dimention;  // how many buttons in a row,col
    
        private int mines_count; // number of mines in the game >> get it from MASM 

        public Game(Panel panel,int dimention, int mines_count)
        {
            this.panelSquares = panel;
            this.dimention = dimention;
            this.mines_count = mines_count;
        }
       
        public void start()
        {

            panelSquares.Enabled = true;
      
            //create, add squares
            squares = new Square[getDimention(), getDimention()];
            for (int i = 0; i < getDimention(); i++)
            {
                for (int j = 0; j < getDimention(); j++)
                {
                    //int square_width = getPanel().Width /getWidth_count() ;
                    //int square_height = getPanel().Height /getHeight_count() ;
                    int square_dimention = getPanel().Width / getDimention();

                    Square s = new Square(i, j, square_dimention);
                    panelSquares.Controls.Add(s.getButton());
                    squares[i, j] = s;             
                }
            }            
          
        }

        public int getDimention()
        {
            return this.dimention;
        }
 

        public Panel getPanel()
        {
            return this.panelSquares;
        }
        

    }
}
