namespace Service_check.Services
{
    public class SingletonService :ISingletonService
    {
        private string _guid;

        public SingletonService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        { return _guid; }
    }
}
