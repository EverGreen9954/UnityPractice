using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star3 : MonoBehaviour
{
    void Start()
    {
        int rows = 5; // 중간 줄까지 별 개수

        string result = "";

        // 위 삼각형 (1 ~ 5)
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                result += "★";
            }
            result += "\n";
        }

        // 아래 삼각형 (4 ~ 1)
        for (int i = rows - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                result += "★";
            }
            result += "\n";
        }

        Debug.Log(result);
    }
}
