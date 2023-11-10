using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;


/**STUDENT : BONDAR IRINA
   GRUPA   : 3131A
   TEMA NR. 4 **/

namespace OpenTK_console_02
{
    class Window3D : GameWindow
    {
        private int selectedFaceIndex = 0;
        const float rotation_speed = 180.0f;
        //float angle;
        bool showCube = true;
        KeyboardState lastKeyPress;
        private const int XYZ_SIZE = 75;
        private bool axesControl = true;
        private int transStep = 0;
        private int radStep = 0;
        private int attStep = 0;

        Color4 faceColor = Color4.Blue;

        

        private bool newStatus = false;

        private int[,] objVertices = {
            {5, 10, 5,
                10, 5, 10,
                5, 10, 5,
                10, 5, 10,
                5, 5, 5,
                5, 5, 5,
                5, 10, 5,
                10, 10, 5,
                10, 10, 10,
                10, 10, 10,
                5, 10, 5,
                10, 10, 5},
            {5, 5, 12,
                5, 12, 12,
                5, 5, 5,
                5, 5, 5,
                5, 12, 5,
                12, 5, 12,
                12, 12, 12,
                12, 12, 12,
                5, 12, 5,
                12, 5, 12,
                5, 5, 12,
                5, 12, 12},
            {6, 6, 6,
                6, 6, 6,
                6, 6, 12,
                6, 12, 12,
                6, 6, 12,
                6, 12, 12,
                6, 6, 12,
                6, 12, 12,
                6, 6, 12,
                6, 12, 12,
                12, 12, 12,
                12, 12, 12
            }
        };
        private Color[] colorVertices = { Color.Tomato, Color.LawnGreen, Color.WhiteSmoke, Color.Tomato, Color.Turquoise, Color.Tomato, Color.HotPink, Color.Tomato, Color.PowderBlue, Color.PeachPuff, Color.Tomato, Color.MediumAquamarine };

        public Window3D() : base(800, 600, new GraphicsMode(32, 24, 0, 8))
        {
            KeyDown += Keyboard_KeyDown;
            
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.LightCyan);
            GL.Enable(EnableCap.DepthTest);
            GL.Hint(HintTarget.PolygonSmoothHint, HintMode.Nicest);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double aspect_ratio = Width / (double)Height;

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            Matrix4 lookat = Matrix4.LookAt(30, 30, 30, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            showCube = true;
        }


       
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState keyboard = Keyboard.GetState();
            MouseState mouse = Mouse.GetState();

            if (keyboard[Key.Escape])
            {
                Exit();
                return;
            }

            if (keyboard[Key.P] && !keyboard.Equals(lastKeyPress))
            {

                if (showCube)
                {
                    showCube = false;
                }
                else
                {
                    showCube = true;
                }
            }
            if (keyboard[Key.R] && !keyboard.Equals(lastKeyPress))
            {
                if (newStatus)
                {
                    newStatus = false;
                }
                else
                {
                    newStatus = true;
                }
            }
            
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
                displayHelp();
            }

            /** rezolvarea cerintei 1 din tema 4, laborator 4 **/
            /** la apăsarea tastei C, schimbăm culoarea feței cubului **/

            if (e.Key==Key.C)
            {
                selectedFaceIndex = (selectedFaceIndex + 1) % (35 / 3);
            }

            /** rezolvarea cerintei 2 din tema 4, laborator 4 **/
            /** la apasarea tastei B, se schimba culorile vertexurilor triunghiurilor **/

            if (e.Key==Key.B)
            {
                selectedFaceIndex = (selectedFaceIndex + 1) % 12;
                for(int i=0;i<12;i++)
                {
                    if(i==selectedFaceIndex)
                    {
                        /** generare culoare random **/
                        Random random = new Random();
                        colorVertices[i] = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                        
                        /** afisare valori RGB **/
                        Console.WriteLine($"Valorile RGB sunt :  R={colorVertices[i].R}, G={colorVertices[i].G}, B={colorVertices[i].B}");
                    }
                    else
                    {
                        /** triunghiurile ramase au culorile initiale **/
                        colorVertices[i] = colorVertices[i / 3];
                    }
                }
                
            }

            /** rezolvarea cerintei 3 din tema 4, laborator 4 **/
            /** la apasarea tastei Y, se schimba culoarea cubului 3D **/

            if (e.Key == Key.Y)
            {
                /** generare culoare cub initiala **/
                Random random = new Random();
                Color newCubeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                for(int i=0;i<12;i++)
                {
                    colorVertices[i] = newCubeColor;
                }
            }

        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            if (newStatus)
            {
                DrawCube();
            }

            if (showCube == true)
            {
                GL.PushMatrix();
                GL.Translate(transStep, attStep, radStep);
                DrawCube();
                GL.PopMatrix();
            }
            SwapBuffers();
        }

       
        private void DrawCube()
        {
            
            GL.Begin(PrimitiveType.Triangles);
            for (int i = 0; i < 35; i = i + 3)
            {
                /** utilizăm indexul pentru a determina culoarea feței **/
                int faceColorIndex = i / 3;

                /** dacă indexul feței este cel selectat, folosim o altă culoare **/
                if (faceColorIndex == selectedFaceIndex)
                {
                    /** se schimba random culoarea unei fete **/
                    Random random = new Random();
                    faceColor = new Color4((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble(), 1.0f);
                }
                else
                {
                    GL.Color3(colorVertices[faceColorIndex]);
                }

                GL.Vertex3(objVertices[0, i], objVertices[1, i], objVertices[2, i]);
                GL.Vertex3(objVertices[0, i + 1], objVertices[1, i + 1], objVertices[2, i + 1]);
                GL.Vertex3(objVertices[0, i + 2], objVertices[1, i + 2], objVertices[2, i + 2]);
            }
            GL.End();
        }

        /** creare meniu de utilizare **/

        private void displayHelp()
        {
            Console.WriteLine("\n                                   === MENIU DE UTILIZARE === \n");
            Console.WriteLine("         TEMA 4  \n");
            Console.WriteLine(" C - culoarea unei fete ale unui cub 3D se va modifica\n");
            Console.WriteLine(" B - in consola vor aparea valorile RGB la fiecare schimbare a culorii >>\n");
            Console.WriteLine(" Y - culoarea cubului 3D se va modifica\n");

        }

    }
}

