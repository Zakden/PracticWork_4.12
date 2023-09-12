using System;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField firstNumber;
    [SerializeField] private InputField secondNumber;
    [SerializeField] private Text resultText;
    
    public void onClickResult()
    {
        if (firstNumber != null && secondNumber != null) 
        {
            int a = Convert.ToInt32(firstNumber.text);
            int b = Convert.ToInt32(secondNumber.text);
            if (a < b)
            {
                resultText.text = $"{b}";
            }
            else if(a > b)
            {
                resultText.text = $"{a}";
            }
            else
            {
                resultText.text = "Равны";
            }
        }
    }
}
