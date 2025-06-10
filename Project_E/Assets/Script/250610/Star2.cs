using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2 : MonoBehaviour
{
    void Start()
    {
        int rows = 6;
        string result = "";

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                result += "★ ";
            }
            result += "\n";
        }

        Debug.Log(result); // 콘솔에 출력
    }
}