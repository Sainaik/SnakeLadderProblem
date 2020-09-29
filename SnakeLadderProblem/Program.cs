﻿using System;

namespace SnakeLadderProblem
{
    class Program
    {
        public static int GetPositon(int start, int end)
        {
            Random rand = new Random();

            return rand.Next(start, end);
        }
        static void Main(string[] args)
        {

            //Constants

            const int NO_Play = 0;
            const int Ladder = 1;
            const int Snake = 2;


            //variables


            int position = 0;
            int next_position = 0;
            int play_option = 0;
            //int count1 = 0;




            while (position != 100)
            {
                next_position = GetPositon(0, 7);

                play_option = GetPositon(0, 3);

                switch (play_option)
                {
                    case NO_Play:
                        Console.Out.WriteLine("NO_PLAY, ur postion is " + position);
                        break;
                    case Ladder:
                        position += next_position;
                        if (position > 100)
                        {
                            position -= next_position;
                            break;
                        }
                        Console.Out.WriteLine("Moved forward to " + position);
                        break;
                    case Snake:
                        position -= next_position;
                        if (position <= 0)
                        {
                            position = 0;
                        }
                        Console.Out.WriteLine("Moved backward to " + position);
                        break;
                    default:
                        break;
                }
                //count1++;
            }
            //Console.Out.WriteLine("The dice is rolled " + count1 + " times to reach 100");
        }
    }
}