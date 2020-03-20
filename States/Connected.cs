using System;
using System.Collections.Generic;
using System.Text;

namespace GoFState.States
{
    class Connected : PhoneState
    {
        public Connected(Phone phoneContext) : base(phoneContext)
        {
        }

        public override void OnEnter()
        {
            Console.WriteLine("OnEnter: Connected");
        }

        public override void OnExit()
        {
            Console.WriteLine("OnExit: Connected\n");
        }

        public override void HandleCallButtonPressed()
        {
            PhoneContext.TurnMicOff();
            PhoneContext.Disconnect();
            PhoneContext.CurState = new Disconnected(PhoneContext);
        }
    }
}
