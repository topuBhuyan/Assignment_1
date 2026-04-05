namespace StudentTeacherGradingSystem.Domain.Enums
{
    public enum TeacherRank
    {
        SENIOR, JUNIOR
    }
    
    public static class TeacherRankExtensions
    {
        public static string ToRankString(this TeacherRank rank)
        {
            switch (rank)
            {
                case TeacherRank.SENIOR: return "Senior Teacher";
                case TeacherRank.JUNIOR: return "Junior Teacher";
                default: return "Unknown";
            }
        }
    }
}