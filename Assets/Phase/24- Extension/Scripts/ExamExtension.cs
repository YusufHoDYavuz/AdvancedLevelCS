using UnityEngine;

namespace Core.Games.GameName
{
    public class ExamExtension : MonoBehaviour
    {
        void Start()
        {
            string x = "Test".AddMyTexts("SecondTextParamter");
            Debug.Log(x);
        }
    }

    public static class MyExtensions
    {
        public static string AddMyTexts(this string obj, string myText)
        {
            return obj + myText;
        }
    }
}
