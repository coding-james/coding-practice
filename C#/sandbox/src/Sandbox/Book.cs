namespace GradeBook
{
    class Book
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

        public void ShowStatistics()
        {
            var gradeResult = 0.0;
            var highGrade = double.MinValue; //MinValue provides lowest possible double number
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                gradeResult += number;
            }
            Console.WriteLine($"--- GRADES ---\nTotal: {gradeResult} \nAverage: {gradeResult / grades.Count:N2} \nLowest: {lowGrade:N2} \nHighest: {highGrade:N2}"); //N2 formats to two decimal places
        }

        private List<double> grades;
        private string name;
    }
}
