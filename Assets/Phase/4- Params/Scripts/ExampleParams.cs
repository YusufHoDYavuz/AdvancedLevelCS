using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Games.GameName
{
    public class ExampleParams : MonoBehaviour
    {
        
        private void Start()
        {
            int mySum = Sum(2, 6, 87, 62, 6, 67);
            Debug.Log($"Sum: {mySum}");
            
            int mySum2 = Sum2(2, 6, 87, 62, 6, 67);
            Debug.Log($"Sum: {mySum2}");
        }

        //NORMAL USSAGE
        private int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int item in numbers)
            {
                sum += item;
            }

            return sum;
        }

        private int Sum2(int x, params int[] numbers)
        {
            return 0;
        }
        
    }
}
