﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_2_
{
    class Student
    {
        int rollNum;
        string name;
        string year;
        string branch;
        string sem;
        int[] mark = new int[5];
        int Total;
        int avg;
        string result;
        int Count = 0;

        public Student(int rollNum, string name, string year, string branch, string sem)
        {
            this.rollNum = rollNum;
            this.name = name;
            this.year = year;
            this.branch = branch;
            this.sem = sem;

        }
        public void Getmarks()
        {
            Console.WriteLine("Enter the marks");
            for (int i = 0; i < mark.Length; i++)
            {
                Console.WriteLine("enter the marks for subject:{0} ", i + 1);
                mark[i] = Convert.ToInt32(Console.ReadLine());
                if (mark[i] < 35)
                {
                    Count++;
                }

                Total = mark[i] + Total;
            }
            Console.WriteLine("Total of given marks : " + Total);
        }
        public void DisplayResult()
        {
            avg = Total / mark.Length;

            if (Count > 0 && avg < 50)
            {
                result = "Fail";
            }
            else
            {
                result = "Pass";
            }


        }

        public void DisplayData()
        {
            Console.WriteLine("************student details*************");
            Console.WriteLine("Roll Number: " + rollNum);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Year of Studying: " + year);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Semester: " + sem);
            Console.WriteLine("Result is: " + result);
            Console.ReadLine();
        }

    }
}


