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
        private int win;

        public frmChess()
        {

            this.frmMain();
            win = 0;
        }

        private void frmMain()
        {
            this.clearBoard();
            this.output();
            while (true)
            {
                this.readData();
                this.writeToDB();
                output();
                check();
                if (win > 0) break;
                change();
            }
            string myColor = string.Empty;
            switch (color)
            {
                case 1: myColor = "Black"; break;
                case 2: myColor = "White"; break;
            }
            Console.Clear();
            Console.WriteLine("{0} Win!", myColor);
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
            Console.WriteLine("  A B C D E F G H I J K L M N O");
            for (i = 0; i <= 14; i++)
            {
                Console.Write(i + 1);
                if (i + 1 < 10) Console.Write(" ");
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
            int X = 0, charY = 0;
            Console.WriteLine("Enter your location X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your location Y: ");
            charY = Console.Read();
            Console.ReadLine();
            int Y = charY - 64;
            tempX = X - 1;
            tempY = Y - 1;
        }

        private void writeToDB()
        {
            fiveChess[tempX, tempY] = color;
        }

        private void change()
        {
            if (color == 1) color = 2; else color = 1;
        }

        private void check()
        {
            for (int i = 0; i <= 14; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (fiveChess[i, j] == fiveChess[i, j + 1] && fiveChess[i, j] == fiveChess[i, j + 2] && fiveChess[i, j] == fiveChess[i, j + 3] && fiveChess[i, j] == fiveChess[i, j + 4])
                    {
                        if (fiveChess[i, j] > 0) win++;
                    }
                }
            }

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 14; j++)
                {
                    if (fiveChess[i, j] == fiveChess[i + 1, j] && fiveChess[i, j] == fiveChess[i + 2, j] && fiveChess[i, j] == fiveChess[i + 3, j] && fiveChess[i, j] == fiveChess[i + 4, j])
                    {
                        if (fiveChess[i, j] > 0) win++;
                    }
                }
            }
            for (int i = 0; i <= 14; i++)
            {
                for (int j = 0; j <= 14; j++)
                {
                    if (i + 4 <= 14 && j + 4 <= 14)
                    {
                        if (fiveChess[i, j] == fiveChess[i + 1, j + 1] && fiveChess[i, j] == fiveChess[i + 2, j + 2] && fiveChess[i, j] == fiveChess[i + 3, j + 3] && fiveChess[i, j] == fiveChess[i + 4, j + 4])
                        {
                            if (fiveChess[i, j] > 0) win++;
                        }
                    }
                }
            }
            for (int i = 0; i <= 14; i++)
            {
                for (int j = 0; j <= 14; j++)
                {
                    if (i + 4 <= 14 && j - 4 >= 0)
                    {
                        if (fiveChess[i, j] == fiveChess[i + 1, j - 1] && fiveChess[i, j] == fiveChess[i + 2, j - 2] && fiveChess[i, j] == fiveChess[i + 3, j - 3] && fiveChess[i, j] == fiveChess[i + 4, j - 4])
                        {
                            if (fiveChess[i, j] > 0) win++;
                        }
                    }
                }
            }
        }
    }

}