/*
    Name: Tofayel Ahamd Tofo
    ID: CSE2202026024
    Section: 27M1
*/

using System;
using InventoryManagementSystem.Application.Common;
using InventoryManagementSystem.Application.Handlers;
using InventoryManagementSystem.Domain.Services;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clean Code: Main function only orchestrates, no business logic
            RunMainMenu();
            RunAdditionalOperations();
            RunDemoOperations();
            RunFinalOperations();
            
            InputOutput.ShowOutput("Done");
        }
        
        private static void RunMainMenu()
        {
            int choice = InputOutput.GetIntInput("Enter choice: 1=Student, 2=Teacher");
            
            IUserHandler? handler = choice switch
            {
                1 => new StudentHandler(),
                2 => new TeacherHandler(),
                _ => null
            };
            
            if (handler != null)
            {
                handler.Process();
            }
            else
            {
                InputOutput.ShowOutput("Invalid");
            }
        }
        
        private static void RunAdditionalOperations()
        {
            // DRY: Reusing the same grade calculation logic
            int marksAgain = InputOutput.GetIntInput("Enter marks again:");
            string gradeAgain = GradeCalculator.GetGrade(marksAgain);
            InputOutput.ShowOutput(gradeAgain);
        }
        
        private static void RunDemoOperations()
        {
            // YAGNI: Removed unnecessary nested loops
            // Kept only what's meaningful from original code
            int x = 10, y = 20;
            if (x < y && y > 5)
            {
                InputOutput.ShowOutput("Condition met");
            }
        }
        
        private static void RunFinalOperations()
        {
            int attendanceAgain = InputOutput.GetIntInput("Enter attendance again:");
            string eligibility = attendanceAgain < 75 ? "Not eligible" : "Eligible";
            InputOutput.ShowOutput(eligibility);
        }
    }
}