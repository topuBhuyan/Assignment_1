using InventoryManagementSystem.Application.Common;
using InventoryManagementSystem.Domain.Services;

namespace InventoryManagementSystem.Application.Handlers
{
    // Clean Code: Single responsibility - only student operations
    public class StudentHandler : IUserHandler
    {
        private const int ATTENDANCE_THRESHOLD = 75;
        
        public void Process()
        {
            // Get marks and display grade
            int marks = InputOutput.GetIntInput("Enter marks:");
            string grade = GradeCalculator.GetGrade(marks);
            InputOutput.ShowOutput(grade);
            
            // Get attendance and check eligibility
            int attendance = InputOutput.GetIntInput("Enter attendance:");
            string eligibility = GetEligibilityStatus(attendance);
            InputOutput.ShowOutput(eligibility);
        }
        
        // DRY: Attendance logic in one place
        private string GetEligibilityStatus(int attendance)
        {
            return attendance < ATTENDANCE_THRESHOLD ? "Not eligible" : "Eligible";
        }
    }
}