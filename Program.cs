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
   TEMA NR. 2 **/


namespace OpenTK_console_01
{
    class SimpleWindow : GameWindow
    {

      
        public SimpleWindow() : base(800, 600)
        {
            KeyDown += Keyboard_KeyDown;
           
           
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

            /**Rezolvarea problemei 2 din tema 2
             * Cerinta : controlul obiectului randat se face prin apasarea a 2 taste si prin miscarea mouse-ului**/
                
            KeyboardState keyboard = Keyboard.GetState();
            
            //la apasarea tastei R (Right) obiectul randat se muta la dreapta
            if (keyboard[Key.R])
            {
                base.OnResize(e);
                GL.Viewport(200, 200, Width, Height);
            }

            //la apasarea tastei L (Left) obiectul randat se muta la stanga
            if (keyboard[Key.L])
            {
                base.OnResize(e);
                GL.Viewport(-200, -200, Width, Height);
            }

            //la efectuarea unui click stanga obiectul revine la pozitia initiala
            MouseState mouse = Mouse.GetState();
            if (mouse[MouseButton.Left])
            {
                base.OnResize(e);
                GL.Viewport(0, 0, Width, Height);
            }


        }

       


        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.Khaki);
        }

        
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);

            

        }

        
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            
        }

      
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

           
            GL.Begin(PrimitiveType.Lines);

            GL.Color3(Color.MidnightBlue);
            GL.Vertex2(-1, 1);
            GL.Color3(Color.SpringGreen);
            GL.Vertex2(0, -1);
            GL.Color3(Color.Ivory);
            GL.Vertex2(1, 1);

            GL.End();
            

            this.SwapBuffers();
        }



        [STAThread]
        static void Main(string[] args)
        {

            using (SimpleWindow example = new SimpleWindow())
            {

              
                example.Run(30.0, 0.0);
            }
        }
    }
}
