using Microsoft.EntityFrameworkCore;
using Net_Core_Web_API.Database;
using Net_Core_Web_API.Models;

namespace Net_Core_Web_API.CustomSql
{

    /// <summary>
    /// Stored Procedure class containing all of the Result models
    /// </summary>
    public class StoredProcedureClass : OnlineTeachingContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public StoredProcedureClass(DbContextOptions<OnlineTeachingContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            : base(options)
        {
        }

        public virtual DbSet<CustomSPModel_Get_Result> CustomSPModel_Get_Result { get; set; }
    }
}
