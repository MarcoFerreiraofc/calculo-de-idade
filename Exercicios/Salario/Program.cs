﻿using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu salario: ");
            int salario = int.Parse(Console.ReadLine());
            
            if (salario <=500){
                
                double reajuste = salario * 1.30;
                Console.WriteLine("Seu salario foi reajuste de 30%, seu atual salário é: " + reajuste);}
            else
            {
                Console.WriteLine("Você não tem direito a  este ajuste");
                
            }

            }
        }
    }
