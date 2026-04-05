using InventoryManagementSystem.Application.Common;

namespace InventoryManagementSystem.Application.Handlers
{
    // Clean Code: Single responsibility - only teacher operations
    public class TeacherHandler : IUserHandler
    {
        private const int SALARY_THRESHOLD = 50000;
        private const int SERVICE_THRESHOLD = 10;
        
        public void Process()
        {
            // Get salary and determine category
            int salary = InputOutput.GetIntInput("Enter salary:");
            string salaryCategory = GetSalaryCategory(salary);
            InputOutput.ShowOutput(salaryCategory);
            
            // Get years of service and determine rank
            int years = InputOutput.GetIntInput("Enter years of service:");
            string rank = GetTeacherRank(years);
            InputOutput.ShowOutput(rank);
        }
        
        // DRY: Salary logic in one place
        private string GetSalaryCategory(int salary)
        {
            return salary > SALARY_THRESHOLD ? "High salary" : "Low salary";
        }
        
        // DRY: Teacher rank logic in one place
        private string GetTeacherRank(int years)
        {
            return years > SERVICE_THRESHOLD ? "Senior Teacher" : "Junior Teacher";
        }
    }
}