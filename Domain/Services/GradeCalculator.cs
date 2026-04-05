using InventoryManagementSystem.Domain.Enums;

namespace InventoryManagementSystem.Domain.Services
{
    // DRY: Single responsibility - only grade calculation
    public static class GradeCalculator
    {
        public static string GetGrade(int marks)
        {
            var grade = GradeExtensions.CalculateFromMarks(marks);
            return grade.ToGradeString();
        }
    }
}