using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star3 : MonoBehaviour
{
    void Start()
    {
        int rows = 5; // �߰� �ٱ��� �� ����

        string result = "";

        // �� �ﰢ�� (1 ~ 5)
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                result += "��";
            }
            result += "\n";
        }

        // �Ʒ� �ﰢ�� (4 ~ 1)
        for (int i = rows - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                result += "��";
            }
            result += "\n";
        }

        Debug.Log(result);
    }
}
