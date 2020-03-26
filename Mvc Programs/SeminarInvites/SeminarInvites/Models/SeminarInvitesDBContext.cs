using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SeminarInvites.Models
{
    public class SeminarInvitesDBContext:DbContext
    {
        public DbSet<GuestResponse> GuestResponses { get; set; }
    }
}