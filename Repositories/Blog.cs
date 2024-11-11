using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    internal class Blog
    {
        private readonly IConfiguration _configuration;
        public Blog(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
