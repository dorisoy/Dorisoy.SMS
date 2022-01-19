using Microsoft.EntityFrameworkCore;

namespace SMS.Data
{
   public class StateHelpers
    {
        public static EntityState ConvertState(ObjectState objstate)
        {
            switch (objstate)
            {
                case ObjectState.Added:
                    return EntityState.Added;
                case ObjectState.Modified:
                    return EntityState.Modified;
                case ObjectState.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }
    }
}
