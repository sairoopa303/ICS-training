﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Assign2
{
    static void Main(string[] args)
    {
        double rl, phy, che, ca, total;
        double per;
        string nm, div;

        Console.Write("\n\n");
        Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
        Console.Write("-------------------------------------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input the Roll Number of the student :");
        rl = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Name of the Student :");
        nm = Console.ReadLine();

        Console.Write("Input  the marks of Physics : ");
        phy = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of  Chemistry : ");
        che = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of Computer Application : ");
        ca = Convert.ToInt32(Console.ReadLine());

        total = phy + che + ca;
        per = total / 3.0;
        if (per >= 60)
            div = "First";
        else
            if (per < 60 && per >= 48)
            div = "Second";
        else
                if (per < 48 && per >= 36)
            div = "Pass";
        else
            div = "Fail";

        Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
        Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, ca);
        Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);

        Console.ReadLine();
    }
}
