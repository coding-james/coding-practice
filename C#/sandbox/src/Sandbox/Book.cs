namespace Sandbox
{
    public class Book
    {
        // CONSTRUCTORS
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }


        // METHODS
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var gradeResult = new Statistics();
            gradeResult.Total = 0.0;
            gradeResult.Average = 0.0;
            gradeResult.High = double.MinValue; //MinValue provides lowest possible double number
            gradeResult.Low = double.MaxValue;
            
            foreach (double grade in grades)
            {
                gradeResult.High = Math.Max(grade, gradeResult.High);
                gradeResult.Low = Math.Min(grade, gradeResult.Low);
                gradeResult.Total += grade;
            }
            
            gradeResult.Average = gradeResult.Total / grades.Count;
            return gradeResult;
        }

        private List<double> grades;
        private string name;
    }
}
