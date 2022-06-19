using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unexus.Facade.Classes;

namespace Unexus.Facade
{
    interface Facade
    {
        /// <summary>
        /// Returns ALL events
        /// </summary>
        /// <returns></returns>
        IEnumerable<Event> GetEvents();

        /// <summary>
        /// Create new event
        /// </summary>
        /// <param name="descr"></param>
        /// <param name="datetime"></param>
        /// <param name="bonusPoint"></param>
        /// <param name="comersLimit"></param>
        /// <returns></returns>
        int CreateEvent(string descr, DateTime datetime, int bonusPoint, int comersLimit);

        /// <summary>
        /// Delete event
        /// </summary>
        /// <param name="id"></param>
        void DeleteEvent(int id);

        IEnumerable<Fines> GetFines();

        /// <summary>
        /// Выписать штраф
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="fineAmount"></param>
        void IsiueFine(int userId, int fineAmount);


        IEnumerable<Registry> GetAllScheduledEvents();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="evtId"></param>
        /// <param name="comerId">User ID</param>
        void RegisterForAScheduledEvent(int evtId, int comerId);


        //-------------------

        void CreateNewUser(string name, string password, Role role);
        IEnumerable<User> GetAllUsers();
    }
}