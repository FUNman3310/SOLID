namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetFullName();

            Teacher teacher = new Teacher();
            teacher.GetFullName();
            teacher.GetExperience();
        }
    }
}