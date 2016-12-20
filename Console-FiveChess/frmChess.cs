using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_FiveChess
{
    class frmChess
    {
        int[,] fiveChess = new int[15, 15];
        private int tempX;
        private int tempY;
        private int color = 1;

        public frmChess()
        {

            this.frmMain();
        }

        private void frmMain()
        {
            this.clearBoard();
            this.output();
            while (true)
            {
                this.readData();
                this.writeToDB();
                this.output();
            }
        }

        public void clearBoard()
        {
            for (int kiminona = 0; kiminona <= 14; kiminona++)
            {
                for (int okatu = 0; okatu <= 14; okatu++)
                {
                    fiveChess[kiminona, okatu] = 0;
                }
            }
        }

        public void output()
        {
            Console.Clear();
            int i, j;
            for (i = 0; i <= 14; i++)
            {
                for (j = 0; j <= 14; j++)
                {
                    switch (fiveChess[i, j])
                    {
                        case 0:
                            Console.Write("- ");
                            break;
                        case 1:
                            Console.Write("B ");
                            break;
                        case 2:
                            Console.Write("W ");
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void readData()
        {
            string myColor = string.Empty;
            switch (color)
            {
                case 1: myColor = "Black"; break;
                case 2: myColor = "White"; break;
            }
            Console.WriteLine(myColor + " player: ");
            Console.WriteLine("Enter your location X: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your location Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());
            tempX = X - 1;
            tempY = Y - 1;

        }

        private void writeToDB()
        {
            fiveChess[tempX, tempY] = color;
            if (color == 1) color = 2; else color = 1;
        }
    }

}