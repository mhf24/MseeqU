namespace Bdeir.Quizzer.Core
{
    public class QuizFactory : IQuizFactory
    {
        public IQuiz CreateQuiz(string file, IStorage storage, IParser parser)
        {
            string content = storage.Read(file);
            var (Title, Questions) = parser.Parse(content);
            return new Quiz(Title, Questions);
        }
    }
}