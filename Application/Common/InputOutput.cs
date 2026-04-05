using System;

namespace InventoryManagementSystem.Application.Common
{
    // Clean Code: Single responsibility - only input/output operations
    public static class InputOutput
    {
        public static int GetIntInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public static void ShowOutput(string message)
        {
            Console.WriteLine(message);
        }
        
        // YAGNI: Removed unused methods (GetString, ShowLoopMessage, etc.)
        // Only keeping what's actually needed
    }
}