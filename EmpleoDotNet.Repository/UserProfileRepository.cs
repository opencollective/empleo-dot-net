﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpleoDotNet.Core.Domain;
using EmpleoDotNet.Data;
using EmpleoDotNet.Repository.Contracts;

namespace EmpleoDotNet.Repository
{
    public class UserProfileRepository : BaseRepository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(EmpleadoContext context) : base(context)
        {
        }
    }
}
