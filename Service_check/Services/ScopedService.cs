﻿namespace Service_check.Services
{
   
    public class ScopedService : IScopedService
    {
        private string _guid;

        public ScopedService() { 
        _guid = Guid.NewGuid().ToString();
        }
        
        public string GetGuid()
            { return _guid; }
    }
}
