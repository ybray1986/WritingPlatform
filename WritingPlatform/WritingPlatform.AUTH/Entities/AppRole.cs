﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingPlatform.AUTH.Entities
{
    public class AppRole
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
