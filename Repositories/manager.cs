using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    internal class manager
    {
        private readonly IConfiguration _configuration;
        public manager(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
