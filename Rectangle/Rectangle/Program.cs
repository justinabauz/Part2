using System;
using System.Collections.Generic;

namespace Rectangle
{
    class MainClass
    {
        public struct Rectangle
        {
            public int length;
            public int width;

            public int RectangleArea()

            {
                return length * width;
            }
        }

        public static void Main(string[] args)
        {
            List<Rectangle> RectanglesList = new List<Rectangle>();

            Rectangle list;
            list.length = 15;
            list.width = 6;

            RectanglesList.Add(list);

            list.length = 16;
            list.width = 3;

            RectanglesList.Add(list);

            list.length = 14;
            list.width = 1;

            RectanglesList.Add(list);

            for (int i = 0; i < RectanglesList.Count; i++)

            {
                Console.WriteLine(RectanglesList[i].length);
                Console.WriteLine(RectanglesList[i].width);
                int area = RectanglesList[i].RectangleArea();
                Console.WriteLine("Rectangle area is {0}:", area);
            }

        }
    }
}
