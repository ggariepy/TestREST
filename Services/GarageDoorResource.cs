using System;
using System.Collections.Generic;
using GenHTTP.Api.Protocol;
using GenHTTP.Modules.Webservices;
using TestREST.Model;

namespace TestREST.Services
{

    public class GarageDoorResource
    {
        public GarageDoorState CurrentState = new GarageDoorState("unknown");

        /// <summary>
        /// Returns all possible GarageDoorStates
        /// </summary>
        /// <returns>List<GarageDoorState></returns>
        [ResourceMethod(RequestMethod.GET, path:"all")]
        public List<GarageDoorState> GetAllPossibleStates()
        {
            Console.WriteLine($"GetAllPossibleStates:");
            // GET http://localhost:8080/door/{state}
            var retval = new List<GarageDoorState>();
            retval.Add(new GarageDoorState("Open"));
            retval.Add(new GarageDoorState("Closed"));
            retval.Add(new GarageDoorState("Moving"));
            retval.Add(new GarageDoorState("Error"));
            retval.Add(new GarageDoorState("Unknown"));
            return retval;
        }

        [ResourceMethod(RequestMethod.GET, path:"state")]
        public GarageDoorState GetCurrentState()
        {
            // GET http://localhost:8080/door/state
            Console.WriteLine("GetCurrentState");
            return CurrentState;
        }

        [ResourceMethod(RequestMethod.PUT, ":newstate")]
        public GarageDoorState ChangeState(string newstate)
        {
            // PUT http://localhost:8080/v1/GarageDoorState/
            Console.WriteLine($"ChangeState to {newstate}");
            CurrentState = new GarageDoorState(newstate);
            return CurrentState;
        }
    }
}
