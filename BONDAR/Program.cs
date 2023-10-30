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
   TEMA NR. 3 **/


namespace OpenTK_console_01
{

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            using (SimpleWindow example = new SimpleWindow())
            {


                Console.WriteLine("     ** Apasati H pentru afisarea meniului de utilizare ** ");
                example.Run(30.0, 0.0);
            }
        }

    }
}
