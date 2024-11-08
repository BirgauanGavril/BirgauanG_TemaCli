using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class ImmediateMode:GameWindow
    {
        
        public ImmediateMode():base(800,600)///adreseaza fereastrainvocand constructorul din clasa parinte// 800,600 reprezinta dimensiunea ferestrei in acesc caz lungime=800 si latime=600
        {
            VSync = VSyncMode.On;//daca nu il punem putem intampina lag in imagini(dar cu vsyncMode=on programul va rula mai greu adica timp de executie crescut)
            //protected-sunt declarate in clasa parinte,se executa pe de o parte in clasa parinte si in clasa mostenita copil


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);//incarca din clasa parinte
            //se pune pentru a fi desenata fereastra
            GL.ClearColor(Color.Green);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);


            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width / 6, Height);


        }


        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
        }


    }
}
