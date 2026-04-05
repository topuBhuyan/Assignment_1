namespace InventoryManagementSystem.Domain.Enums
{
    // DRY: Grade calculation logic is centralized here
    public enum Grade
    {
        A, B, C, D, FAIL
    }
    
    public static class GradeExtensions
    {
        public static string ToGradeString(this Grade grade)
        {
            return grade switch
            {
                Grade.A => "Grade A",
                Grade.B => "Grade B",
                Grade.C => "Grade C",
                Grade.D => "Grade D",
                Grade.FAIL => "Fail",
                _ => "Unknown"
            };
        }
        
        // DRY: Single place for grade calculation logic
        public static Grade CalculateFromMarks(int marks)
        {
            return marks switch
            {
                >= 90 => Grade.A,
                >= 80 => Grade.B,
                >= 70 => Grade.C,
                >= 60 => Grade.D,
                _ => Grade.FAIL
            };
        }
    }
}