﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ITokenManager
    {
        Task<string> GenerateUserTokenAsync(Users user);
    }
}
