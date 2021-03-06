﻿using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Repositories
{
    public interface IFoxRepository
    {
        void Create(Fox fox);
        Fox Read(string name);
        void Update(Fox fox);
        void Delete(Fox fox);
    }
}
