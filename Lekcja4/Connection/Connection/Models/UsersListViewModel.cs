﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connection.Models
{
    public class UsersListViewModel
    {
        public IEnumerable<UserListItemViewModel> Users { get; set; }
    }
}
