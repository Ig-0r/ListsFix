using ListsFix;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Collections;
using System.Diagnostics.Metrics;
internal class Program
{
    private static void Main(string[] args)
    {
        

        List<employees> info = new List<employees>();

        Console.Write("How many employees will be registered? ");
        int quant = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quant; i++)
        {
            Console.WriteLine("Emplyoee #" + i + ":");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            info.Add(new employees(id, name, salary));
            Console.WriteLine();
            // Falta usar o find pra puxar um funcionario e alterar o seu salario
            // se ele não existir, mostrar mensagem            
        }
        Console.Write("Enter the employee id that will have salary increase : ");
        int idinfo = int.Parse(Console.ReadLine());
        employees IDFind = info.Find(x => x.ID == idinfo);

        if (IDFind != null)
        {
            Console.Write("Enter the percentage: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            IDFind.SalaryAdd(porcentagem);
        }
        else
        {
            Console.WriteLine("This id does not exist!");
        }
        Console.WriteLine("Updated list of employees:");
        foreach (employees emp in info)
        {
            Console.WriteLine(emp);
        }
    }
}