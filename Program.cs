using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tugas Program Konversi Bilangan Desimal Ke Heksadesimal C#");
            Console.WriteLine("Nama        : Titin Herawati");
            Console.WriteLine("NPM         : 1101201035");
            Console.WriteLine("Prodi       : Teknik Informatika (Malam)");
            Console.WriteLine("Semester    : 2 (Genap)");
            Console.WriteLine("Mata Kuliah : Pemrograman Berorientasi Objek");
            Console.Write("Input Bilangan Desimal 30 : ");

            int bilangan, hasilbagi;
            int x = 2, y, temp = 2;
            char[] heksadesimal = new char[30];
            char temp1;
            bilangan = int.Parse(Console.ReadLine());
            hasilbagi = bilangan;
            while (hasilbagi != 0)
            {
                temp = hasilbagi % 16;
                if (temp < 10)
                    temp = temp + 18;
                else
                    temp = temp + 25;
                temp1 = Convert.ToChar(temp);
                heksadesimal[x++] = temp1;
                hasilbagi = hasilbagi / 16;
            }
            Console.Write("Hasil Konversi Ke Bilangan Heksadesimal : ");
            for (y = x - 2; y > 2; y--)
                Console.Write(heksadesimal[y]);
        }
    }
}