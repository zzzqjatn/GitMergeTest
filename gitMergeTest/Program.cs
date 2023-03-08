﻿using System;

namespace gitMergeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // { 2023.03.08 유저 입력 추가함 - Beta
            string userInput = string.Empty;
            Console.WriteLine("이 프로그램은 cm를 inch로 변환하는 프로그램 입니다.");
            Console.Write("Cm 값을 입력하시오 :");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            // } 2023.03.08 유저 입력 추가함 - Beta

            ruler.Run();
        }
    }

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
}