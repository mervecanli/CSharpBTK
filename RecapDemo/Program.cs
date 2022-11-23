using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RecapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateButtons();
        }

        private static void GenerateButtons()
        {
            //Button[,] buttons = new Button[8, 8];
            //int top = 0;
            //int left = 0;
            //for (int i = 0; i < buttons.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j < buttons.GetUpperBound(1); j++)
            //    {
            //        buttons[i, j] = new Button();
            //        buttons[i, j].Width = 50;
            //        buttons[i, j].Height = 50;
            //        buttons[i, j].Left = left;
            //        buttons[i, j].Top = top;
            //        left += 50;
            //        if ((i+j) % 2 == 0)
            //        {
            //            buttons[i, j].Background = Color.Black;
            //        }
            //        else
            //        {
            //            buttons[i, j].Background = Color.White;
            //        }
            //        this.Control.Add(buttons[i, j]);
            //    }
            //    left=0;
            //    top += 50;
            //}
        }
    }
}
