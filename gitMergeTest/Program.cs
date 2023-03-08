﻿using System;

namespace gitMergeTest
{
    // { 2023.03.08 Ruler 클래스 코드 위치 변경 - Alpha
    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }

        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter} cm는 {this.Inch} inch 입니다.");
        }
    }
    // } 2023.03.08 Ruler 클래스 코드 위치 변경 - Alpha

    internal class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }
}