namespace ExaminationSystemm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var file1 = new QuestionList("ExamQuestion.txt");

            Subject subj = new Subject("OOP");

            var practiceExam = new PracticeExam( 1 , 2, subj);

            Question q1 = new TrueFalseQuestion("Q1", "C# is an Object-Oriented Language?", 2);
            q1.Answers.Add(new Answer("True", true));
            q1.Answers.Add(new Answer("False", false));
            file1.Add(q1);

            practiceExam.QuestionAnswerDictionary[q1] = new Answer("True", true);



            Question q2 = new ChooseOneQuestion("Q2", "Which of these is a value type?", 3);

            q2.Answers.Add(new Answer("int", true));
            q2.Answers.Add(new Answer("string", false));
            q2.Answers.Add(new Answer("object", false));

            file1.Add(q2);
            practiceExam.QuestionAnswerDictionary[q2] = new Answer("string", false);

            Question q3 = new ChooseAllQuestion("Q3", "Select all reference types:", 4);
            q3.Answers.Add(new Answer("class", true));
            q3.Answers.Add(new Answer("string", true));
            q3.Answers.Add(new Answer("struct", false));
            q3.Answers.Add(new Answer("enum", false));
            file1.Add(q3);
            
            practiceExam.QuestionAnswerDictionary[q3] = new Answer("string", true) ;









            //practiceExam.ShowExam();


            //--------------------------------------------------------------------
            var finalExam = new FinalExam( 2 , 2, subj);
            finalExam.QuestionAnswerDictionary[q1] = new Answer("False", false);
            finalExam.QuestionAnswerDictionary[q2] = new Answer("int", true);
            //finalExam.ShowExam();

            Console.WriteLine("Enter Exam Type (F/P): ");
            string type= Console.ReadLine();
            if(type.ToUpper() == "F")
                finalExam.ShowExam();
            else if(type.ToUpper() == "P")
                practiceExam.ShowExam();
            else
                Console.WriteLine("Invalid Type");




            //q1.Display();
            //foreach (var ans in q1.Answers)
            //    Console.WriteLine(ans);
            //q2.Display();
            //q3.Display();

        }
    }
}
