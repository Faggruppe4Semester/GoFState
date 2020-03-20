using System;
using System.Collections.Generic;
using System.Text;

namespace GoFState
{
    public abstract class PhoneState
    {
        protected Phone PhoneContext;
        protected PhoneState(Phone phoneContext) => PhoneContext = phoneContext;
        public virtual void HandleDigitPressed(char c) { }
        public virtual void HandleCallButtonPressed() { }
        public virtual void HandleConnectionEstablished() { }
        public virtual void HandleDisconnected() { }

        public virtual void OnEnter() { }

        public virtual void OnExit() { }
    }
}
