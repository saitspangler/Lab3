using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /// <summary>
    /// repository of methods for working with States table
    /// </summary>
    public static class StateDB
    {
        public static List<StateDTO> GetStateDTOs()
        {
            List<StateDTO> states = null;
            using (MMABooksContext db = new MMABooksContext())
            {
                states = db.States.Select(s => new StateDTO
                {
                    StateCode = s.StateCode,
                    StateName = s.StateName
                }).ToList();
            }
            return states;
        }

    }
}
