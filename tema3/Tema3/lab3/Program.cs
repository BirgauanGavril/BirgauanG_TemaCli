﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanta a clasei GameWindow
            using (ImmediateMode example = new ImmediateMode()) 
            {
                example.Run(30.0, 0.0);//activeaza bucla de control 
            }
        }
    }
}
