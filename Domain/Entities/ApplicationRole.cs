﻿using Domain.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class ApplicationRole : IdentityRole<Guid>, IEntity
    {
    }
}
