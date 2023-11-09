using UnityEngine;

namespace Core.Games.GameName
{
    public class MultiArrray : MonoBehaviour
    {
        private int[] tekBoyutluDizi = { -2, 5, 6 };

        private int[,] ikiBoyutluDizi = { { 2, 7 }, { 5, 9 }, { 6, 12 } };

        private int[,,] ucBoyutluDizi = { { { 2, 6 }, { 5, 1 } }, { { 8, 5 }, { 129, 51 } } };

        private void Start()
        {
            Debug.Log(tekBoyutluDizi[0]);

            Debug.Log(ikiBoyutluDizi[2, 1]);

            Debug.Log(ucBoyutluDizi[1, 0, 2]);
        }
    }
}