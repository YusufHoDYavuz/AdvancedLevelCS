using System;
using UnityEngine;

namespace Core.Games.GameName
{
    public class ExeptionAndThrow : MonoBehaviour
    {
        void Start()
        {
            //Basic
            Exception ex = new Exception("This is Error");
            throw ex;

            //Advanced
            //MyException myException = new MyException("Hi", new Exception("Inner"));
        }
    }

    class MyException : Exception
    {
        public MyException():base() {} //Zaten boş constructor otomatik base'i alıyor
        
        public MyException(string message):base(message) {}
        
        public MyException(string message, Exception myException):base(message, myException) {}
    }
}
