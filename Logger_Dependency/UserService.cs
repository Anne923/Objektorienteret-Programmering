using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Dependency
{
    public class UserService
    {
        private readonly ILogger _logger;
        public UserService(ILogger logger)
        {
            _logger = logger;
        }

        public void CreateUser(string username)
        {
            _logger.Log($"User '{username}' created.");

        }
    }
}
