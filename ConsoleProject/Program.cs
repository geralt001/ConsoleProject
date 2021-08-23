using System;
using ConsoleProject.Models;
using ConsoleProject.Services;
namespace ConsoleProject
{
    class Program
    {
        private static HumanResourceManager humanResource = new HumanResourceManager();
        public Program()
        {
            humanResource = new HumanResourceManager();
        }
        static void Main(string[] args)
        
            