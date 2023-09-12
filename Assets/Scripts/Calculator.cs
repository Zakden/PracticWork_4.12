using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField firstNumber;
    [SerializeField] private InputField secondNumber;
    [SerializeField] private Text resultText;

    public void onClickButtonPlus()
    {
        if(firstNumber != null && secondNumber != null) 
        {
            int a = Convert.ToInt32(firstNumber.text);
            int b = Convert.ToInt32(secondNumber.text);
            int result = a + b;
            resultText.text = result.ToString();
        }
    }

    public void onClickButtonMinus()
    {
        if (firstNumber != null && secondNumber != null)
        {
            int a = Convert.ToInt32(firstNumber.text);
            int b = Convert.ToInt32(secondNumber.text);
            int result = a - b;
            resultText.text = result.ToString();
        }
    }
    public void onClickButtonMultiply()
    {
        if (firstNumber != null && secondNumber != null)
        {
            int a = Convert.ToInt32(firstNumber.text);
            int b = Convert.ToInt32(secondNumber.text);
            int result = a * b;
            resultText.text = result.ToString();
        }
    }

    public void onClickButtonDivision()
    {
        if (firstNumber != null && secondNumber != null)
        {
            if(secondNumber.text == "0")
            {
                resultText.text = "Нельзя делить на 0";
            }
            else
            {
                int a = Convert.ToInt32(firstNumber.text);
                int b = Convert.ToInt32(secondNumber.text);
                int result = a / b;
                resultText.text = result.ToString();
            }
        }
    }
}
