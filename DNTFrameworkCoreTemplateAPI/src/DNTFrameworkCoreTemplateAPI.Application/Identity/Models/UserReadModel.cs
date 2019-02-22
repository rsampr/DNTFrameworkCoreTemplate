using System;
using DNTFrameworkCore.Application.Models;

namespace DNTFrameworkCoreTemplateAPI.Application.Identity.Models
{
    public class UserReadModel : MasterModel
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset? LastLoggedInDateTime { get; set; }
    }
}