using OpenTK.Input;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


/**STUDENT : BONDAR IRINA
   GRUPA   : 3131A
   TEMA NR. 4 **/ 

namespace OpenTK_console_02
{
    class Program1
    {

        [STAThread]
        static void Main(string[] args)
        {

            using (Window3D example = new Window3D())
            {
                Console.WriteLine("     ** Apasati H pentru afisarea meniului de utilizare ** ");
                example.Run(30.0, 0.0);
            }

        }
    }
}

