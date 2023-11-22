using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Games.GameName
{
    public class ExamOperatorOverload : MonoBehaviour
    {
        private void Start()
        {
            MyClass a = new MyClass();
            MyClass b = new MyClass();

            a.X = 10;
            b.X = 7;

            MyClass c = a + b;
            
            Debug.Log($"C {c.X}");
        }
    }

    public class MyClass
    {
        public int X { get; set; }

        public static MyClass operator +(MyClass left, MyClass right)
        {
            return new MyClass { X = left.X + right.X };
        }
    }
}
