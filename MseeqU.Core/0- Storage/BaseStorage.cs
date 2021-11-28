namespace Bdeir.Quizzer.Core
{
    public abstract class BaseStorage : IStorage
    {
        protected IStorageConfig config;
        public BaseStorage(IStorageConfig config)
        {
            this.config = config;
        }
        public abstract bool Exists(string fileName);
        public abstract string Read(string fileName);
        public abstract void Write(string fileName, string content);
    }
}
