using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using GlobeCol.Core.Domain;

namespace GlobeCol.Infrastructure.Data
{
    public class GlobeColDbContext : DbContext
    {
        public GlobeColDbContext(DbContextOptions<GlobeColDbContext>options): base(options)
        {

        }

    }
   
}
