using System;
using System.Collections.Generic;
using System.Text;

namespace GoFState.States
{
    class Disconnected : PhoneState
    {
        public Disconnected(Phone phoneContext) : base(phoneContext)
        {
        }

        public override void OnEnter()
        {
            Console.WriteLine("OnEnter: Disconnected");
        }

        public override void OnExit()
        {
            Console.WriteLine("OnExit: Disconnected\n");
        }

        public override void HandleDisconnected()
        {
            Console.WriteLine("Disconnected called");
            PhoneContext.CurState = new Idle(PhoneContext);
        }
    }
}
