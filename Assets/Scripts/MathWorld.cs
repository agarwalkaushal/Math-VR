using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MathWorld : MonoBehaviour
{

    public TextMesh argument1;
    public TextMesh argument2;
    public TextMesh answer;
    public TextMesh result;

    public TextMesh number1;
    public TextMesh number2;
    public TextMesh number3;

    public GameObject resultBox;

    private System.Random rand;

    private int math = 0;
    private int arg1;
    private int arg2;
    private int arg3;

    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random();
        result.text = "Solve the equation";
        resetEquation();
    }

    public void getArguments(int number)
    {
        int value;

        if (number == 1)
            value = arg1;
        else if (number == 2)
            value = arg2;
        else
            value = arg3;

        if (argument1.text.ToString() == "")
            argument1.text = value.ToString();

        else if (argument2.text.ToString() == "")
            argument2.text = value.ToString();


        if (argument2.text.ToString() != "" && argument1.text.ToString() != "" && math==0)
            add(argument2.text.ToString(),argument1.text.ToString());
        
        
    }

    private void add(string a2, string a1)
    {
        int sum = int.Parse(a2) + int.Parse(a1);
        resultBox.SetActive(true);

        if(sum == int.Parse(answer.text.ToString()))
        {
            result.text = "You are correct";
        }
        else
        {
            result.text = "You are incorrect";
        }
    }

    public void resetEquation()
    {
        result.text = "Solve the equation";

        int num = rand.Next(100);

        if(math == 0)
        {
            arg1 = rand.Next(num - 1);
            arg2 = num - arg1;

            if (arg1 < arg2)
                arg3 = rand.Next(arg1 - 1);
            else
                arg3 = rand.Next(arg2 - 1);

            argument1.text = "";
            argument2.text = "";
            number1.text = arg1.ToString();
            number2.text = arg2.ToString();
            number3.text = arg3.ToString();
            answer.text = num.ToString();

        }
    }

    public void changeMath(int sign)
    {
        if (sign == 1)
        {
            Debug.Log("Subtraction");
            math = 1;
        }
        else if (sign == 2)
        {
            Debug.Log("Multiplication");
            math = 2;
        }
        else
        {
            Debug.Log("Division");
            math = 3;
        }
    }
}
