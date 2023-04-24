using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Models
{
    public interface IModem
    {
        public void Dial(string pno);
        public void Hangup();
        public void Send(char c);
        public char Recv();
    }

    //public interface IModemConnection
    //{
    //    public void Dial(string pno);
    //    public void Hangup();
    //}

    //public interface IModemDataChannel
    //{
    //    public void Send(char c);
    //    public char Recv();
    //}
}
