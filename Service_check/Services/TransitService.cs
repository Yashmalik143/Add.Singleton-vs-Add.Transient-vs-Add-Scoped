namespace Service_check.Services
{
   
    public class TransitService : ITransitService
    {
        public string _guid;
        public TransitService() { 
        
            _guid = Guid.NewGuid().ToString();  
        }

        public string GetGuid() { return _guid; }

    }
}
