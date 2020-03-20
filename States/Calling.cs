using System;

namespace GoFState.States
{
    class Calling : PhoneState
    {
        private string _number;
        public Calling(Phone phoneContext, string number) : base(phoneContext)
        {
            _number = number;
        }

        public override void OnEnter()
        {
            Console.WriteLine("OnEnter: Calling");
        }

        public override void OnExit()
        {
            Console.WriteLine("OnExit: Calling\n");
        }

        public override void HandleConnectionEstablished()
        {
            Console.WriteLine("Connection Established");
            PhoneContext.TurnMicOn();
            PhoneContext.CurState = new Connected(PhoneContext);
        }
    }
}
