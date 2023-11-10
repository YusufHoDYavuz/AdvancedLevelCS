using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Games.GameName
{
    public class ExamConstructor2 : MonoBehaviour
    {

        public string _name;
        public string _surname;
        
        // CONTRUCTOR BU SEKIL TANIMLANIR VE ILK CALISAN METODDUR
        public ExamConstructor2(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        
        //BİRDEN FAZLA CONSTRUCTOR KULLANILABİLİR
        public ExamConstructor2()
        {
            
        }

        public void PrintThis()
        {
            Debug.Log($"_name {_name} _surname {_surname}");
        }
    }
}
