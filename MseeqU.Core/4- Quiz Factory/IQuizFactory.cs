namespace Bdeir.Quizzer.Core
{
    public interface IQuizFactory
    {
        IQuiz CreateQuiz(string file, IStorage storage, IParser parser);
    }
}