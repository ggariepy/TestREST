using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestREST.Model
{
    public record GarageDoorState
    {
        public bool IsOpen { get; }
        public bool IsClosed { get; }
        public bool IsMoving { get; }
        public bool IsError { get; }
        public bool IsUnknown { get; }
        public GarageDoorState(string Status)
        {
            switch (Status.ToLower())
            {
                case "open":
                    IsClosed = false;
                    IsOpen = true;
                    IsMoving = false;
                    IsError = false;
                    IsUnknown = false;
                    break;
                case "closed":
                    IsClosed = true;
                    IsOpen = false;
                    IsMoving = false;
                    IsError = false;
                    IsUnknown = false;
                    break;
                case "moving":
                    IsClosed = false;
                    IsOpen = false;
                    IsMoving = true;
                    IsError = false;
                    IsUnknown = false;
                    break;
                case "error":
                    IsClosed = false;
                    IsOpen = false;
                    IsMoving = false;
                    IsError = true;
                    IsUnknown = false;
                    break;
                case "unknown":
                    IsClosed = false;
                    IsOpen = false;
                    IsMoving = false;
                    IsError = false;
                    IsUnknown = true;
                    break;
                default:
                    IsClosed = false;
                    IsOpen = false;
                    IsMoving = false;
                    IsError = false;
                    IsUnknown = true;
                    break;
            }
        }
    }
}
