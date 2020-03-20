using System;
using System.Collections.Generic;
using System.Text;

namespace GoFState.States
{
    public class Idle : PhoneState
    {
        private string number = "";
        public Idle(Phone phoneContext) : base(phoneContext)
        {
        }

        public override void OnEnter()
        {
            Console.WriteLine("OnEnter: Idle");
        }

        public override void OnExit()
        {
            Console.WriteLine("OnExit: Idle\n");
        }

        public override void HandleCallButtonPressed()
        {
            Console.WriteLine("Call button pressed");
            PhoneContext.CallNumber(number);
            PhoneContext.CurState = new Calling(PhoneContext, number);
        }

        public override void HandleDigitPressed(char c)
        {
            Console.WriteLine($"Digit ({c}) Pressed...");
            number += c;
        }
    }
}
