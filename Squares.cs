using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    class Square
    {
        private Button square_btn;
        private int x;
        private int y;
     

        public Square(  int x, int y , int dimention)
        {

            this.x = x;
            this.y = y;
         
            //set square attriputes
            square_btn = new Button();
            square_btn.Width = dimention;
            square_btn.Height = dimention;

            square_btn.Left = dimention * this.y;
            square_btn.Top = dimention * this.x;
           
            square_btn.Font = new System.Drawing.Font("Arial Black",1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            square_btn.MouseDown += new MouseEventHandler(squareClicked);

        }

        private void squareClicked(object sender, MouseEventArgs e)
        {
            MessageBox.Show("this row = " + this.x + ", col = " + this.y + " invoce to the MASM ");
        }

        public Button getButton()
        {
            return square_btn;
        }
    }
}
