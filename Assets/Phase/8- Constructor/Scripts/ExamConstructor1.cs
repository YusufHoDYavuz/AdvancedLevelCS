using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Games.GameName
{
    public class ExamConstructor1 : MonoBehaviour
    {
       
        void Start()
        {
            ExamConstructor2 test = new ExamConstructor2("Yusuf", "Uavuz");
            
            
            ExamConstructor2 test2 = new ExamConstructor2();

            test2._name = "Ahmet";
            test2._surname = "Yaxz";
            
            test.PrintThis();
            test2.PrintThis();
        }

    }
}
