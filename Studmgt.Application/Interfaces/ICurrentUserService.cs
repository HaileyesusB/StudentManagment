using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application
{
    public interface ICurrentUserService
    {
        string UserId { get; }
    }
}
