using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    internal class TotalAccount
    {
        private readonly IConfiguration _configuration;
        public TotalAccount(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
