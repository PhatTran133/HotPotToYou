using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.Common.Interfaces
{
    public interface IJwtService
    {
        string CreateToken(int ID, string roles);
    }
}
