using Dapper.FluentMap;
using Repository.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RegisterMapping
    {
        public RegisterMapping()
        {
            FluentMapper.Initialize(cfg =>
            {
                cfg.AddMap(new RotaMap());
            });
        }
    }
}
