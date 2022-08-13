using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace _4_Turtle
{
    class Program
    {
        static void DrawT (int height)
            {
            Turtle.Angle = 0; // угол 0, черепашка смотрит наверх
            Turtle.Move(height);
            Turtle.TurnLeft(); // или Turtle.Angle = 270;
            Turtle.Move(20);
            Turtle.Angle = 90; // угол 90
            Turtle.Move(40);
            }
        static void Main(string[] args) //место откуда стартует программа
        {
            Turtle.Speed = 9;





            /* Рисуем слово ТОРт
            Turtle.X = 220;
            Turtle.Y = 200;
            // T
            
            DrawT(60); //рисуем Т большую

            Turtle.X = 260;
            Turtle.Y = 200;
            Turtle.Angle = 0; // угол 0, черепашка смотрит наверх
            for (int i=0; i<4; i++)
            {
               Turtle.Move(60);
                Turtle.TurnRight(); 
            }
            
            Turtle.X = 340;
            Turtle.Y = 200;
            Turtle.Angle = 0;
            Turtle.Move(60);
            for (int i=0; i<3;i++)
            {
               Turtle.TurnRight();
                Turtle.Move(40); 
            }

            Turtle.X = 420;
            Turtle.Y = 200;
            DrawT(30); //рисуем Т большую
            */
            



            //for ( int i=0; i<6; i++) черепашка рисует 6угольник
            //{
            //   Turtle.Move(60);
            //    Turtle.Turn(60); //поворот на угол 60                              
            //}        
        }
    }
}
