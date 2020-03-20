using System;
using System.Reflection.Metadata.Ecma335;
using GoFState.States;

namespace GoFState
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.DigitPressed();
            phone.CallButtonPressed();
            phone.ConnectionEstablished();
            phone.CallButtonPressed();
            phone.Disconnected();
        }
    }

    public class Phone
    {
        private PhoneState _curState;
        public PhoneState CurState
        {
            get => _curState;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                _curState.OnExit();
                _curState = value;
                _curState.OnEnter();
            }
        }

        public Phone() => _curState = new Idle(this);


        public void DigitPressed()
        {
            CurState.HandleDigitPressed(Console.ReadKey().KeyChar);
        }

        public void CallButtonPressed()
        {
            CurState.HandleCallButtonPressed();
        }

        public void ConnectionEstablished()
        {
            CurState.HandleConnectionEstablished();
        }

        public void Disconnected()
        {
            CurState.HandleDisconnected();
        }

        public void CallNumber(string number)
        {
            Console.WriteLine($"Calling Number {number}");
        }

        public void TurnMicOn()
        {
            Console.WriteLine("Mic has been turned on");
        }

        public void TurnMicOff()
        {
            Console.WriteLine("Mic has been turned off");
        }

        public void Disconnect()
        {
            Console.WriteLine("Call has been disconnected");
        }
    }
}
