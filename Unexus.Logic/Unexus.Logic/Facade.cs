using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unexus.Facade;
using Unexus.Facade.Classes;

namespace Unexus.Logic
{
    public class Facade : IFacade
    {
        private readonly string _connectionString;

        public Facade()
        {
            // createConnectionString
        }

        public int CreateEvent(string descr, DateTime datetime, int bonusPoint, int comersLimit)
        {
            int eventId = 0;

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "dbo.UpdateEvent";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@Descr", descr));
                    command.Parameters.Add(new SqlParameter("@Date", datetime));
                    command.Parameters.Add(new SqlParameter("@BonusPoint", bonusPoint));
                    command.Parameters.Add(new SqlParameter("@ComersLimit", comersLimit));

                    using (var reader = command.ExecuteReader())
                    {
                        // ...todo fck
                    }
                }
            }

            return eventId;
        }

        public void CreateNewUser(string name, string password, Role role)
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Registry> GetAllScheduledEvents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Event> GetEvents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fines> GetFines()
        {
            throw new NotImplementedException();
        }

        public void IsiueFine(int userId, int fineAmount)
        {
            throw new NotImplementedException();
        }

        public void RegisterForAScheduledEvent(int evtId, int comerId)
        {
            throw new NotImplementedException();
        }
    }
}
