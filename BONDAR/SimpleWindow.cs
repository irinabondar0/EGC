using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**STUDENT : BONDAR IRINA
   GRUPA   : 3131A
   TEMA NR. 4 **/


namespace OpenTK_console_01

{

    class SimpleWindow : GameWindow
    {
        private int anteriorMouseX, anteriorMouseY;
        //private int nr;
        private int pixeli_1 = 0, pixeli_2 = 0;
        private float red1, green1, blue1;
        private float red2, green2, blue2;
        private float red3, green3, blue3;



        public SimpleWindow() : base(800, 600)
        {
            KeyDown += Keyboard_KeyDown;
            GenerateRandomColors();
        }


        void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
        {


            if (e.Key == Key.Escape)
                this.Exit();

            if (e.Key == Key.F11)
                if (this.WindowState == WindowState.Fullscreen)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Fullscreen;
            if (e.Key == Key.H)
            {
                dispayHelp();
            }

            /** rezolvare cerinta 8 din tema 3 **/
            /** modificarea culorii triunghiului la apasarea tastei X **/

            /** rezolvare cerinta 9 din tema 3 **/
            /** afisarea in consola a valorilor RGB pentru fiecare vertex **/

            if (e.Key == Key.X)
            {



                GenerateRandomColors();
                Console.WriteLine("Vertex 1 - R: " + red1 + ", G: " + green1 + ", B: " + blue1);
                Console.WriteLine("Vertex 2 - R: " + red2 + ", G: " + green2 + ", B: " + blue2);
                Console.WriteLine("Vertex 3 - R: " + red3 + ", G: " + green3 + ", B: " + blue3 + " \n");

            }



            /**Rezolvarea problemei 2 din tema 2
             * Cerinta : controlul obiectului randat se face prin apasarea a 2 taste **/

            /** la apasarea tastei R (Right) obiectul randat se muta la dreapta **/
            if (e.Key == Key.R && pixeli_1 < Width)
            {
                pixeli_1 = pixeli_1 + 100;
            }


            /** la apasarea tastei L (Left) obiectul randat se muta la stanga **/
            if (e.Key == Key.L && pixeli_1 > -Width)
            {
                pixeli_1 = pixeli_1 - 100;
            }

            GL.Viewport(pixeli_1, pixeli_2, Width, Height);


        }

        /** Rezolvarea problemei 2 din tema 2 **/
        /** Cerinta : controlul obiectului randat se face prin miscarea mouse-ului **/

        protected void Mouse_Move()
        {
            /** starea curenta a mouse-lui **/
            int curentMouseX = Mouse.GetCursorState().X;
            int curentMouseY = Mouse.GetCursorState().Y;

            /** calculul schimbarii pozitiei **/
            int diferentaX = curentMouseX - anteriorMouseX;
            int diferentaY = curentMouseY - anteriorMouseY;

            if (diferentaY < 0 && pixeli_2 < Height)
            {
                pixeli_2 += 5;
            }

            if (diferentaY > 5 && pixeli_2 > -Height)
            {
                pixeli_2 -= 5;
            }
            GL.Viewport(pixeli_1, pixeli_2, Width, Height);

            anteriorMouseX = curentMouseX;
            anteriorMouseY = curentMouseY;
        }


        /** functie pentru generarea aleatorie a culorilor vertexurilor **/
        private void GenerateRandomColors()
        {
            Random random1 = new Random();
            red1 = (float)random1.NextDouble();
            green1 = (float)random1.NextDouble();
            blue1 = (float)random1.NextDouble();

            red2 = (float)random1.NextDouble();
            green2 = (float)random1.NextDouble();
            blue2 = (float)random1.NextDouble();

            red3 = (float)random1.NextDouble();
            green3 = (float)random1.NextDouble();
            blue3 = (float)random1.NextDouble();
        }


        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.WhiteSmoke);
            anteriorMouseX = Mouse.GetCursorState().X;

        }



        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Texture);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);
        }


        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            Mouse_Move();

        }



        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);


            GL.Begin(PrimitiveType.Triangles);

            /** rezolvare tema 3 - cerinta 1 - desenare axe coordonate **/
            /** acestea sunt desenate in sens anti-orar **/

            /** setarea culorilor pentru fiecare varf al triunghiului **/
            GL.Color3(red1, green1, blue1);
            GL.Vertex2(-0.5, 0.5);

            GL.Color3(red2, green2, blue2);
            GL.Vertex2(0.5, -0.5);

            GL.Color3(red3, green3, blue3);
            GL.Vertex2(0.5, 0.5);


            GL.End();

            this.SwapBuffers();

        }

        /** crearea si afisarea unui meniu in consola **/
        private void dispayHelp()
        {
            Console.WriteLine("\n                                   === MENIU DE UTILIZARE === \n");
            Console.WriteLine("         TEMA 2 - Miscarea obiectului randat la apasarea a 2 taste si prin miscarea mouse-ului \n");
            Console.WriteLine(" R - obiectul se misca la dreapta\n");
            Console.WriteLine(" L - obiectul se misca la stanga\n");
            Console.WriteLine(" Miscare mouse sus - obiectul se va misca in sus\n");
            Console.WriteLine(" Miscare mouse jos - obiectul se va misca in jos\n");

            Console.WriteLine("         TEMA 3 - La apasarea unui set de taste se vor schimba culorile triunghiului \n");
            Console.WriteLine(" X - se schimba aleatoriu culoarea triunghiului\n");
            Console.WriteLine(" In consola vor aparea valorile RGB la fiecare schimbare a culorii >>\n");




        }


    }
}
