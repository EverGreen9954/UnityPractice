using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star1 : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "�� ";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;
        int rows = 5;

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "�� ";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        int rows = 5;

        // ���� �ﰢ��
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "��";
            }
            star += "\n";
        }

        // �Ʒ��� �ﰢ��
        for (int i = rows - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "��";
            }
            star += "\n";
        }

        Debug.Log(star);
    }


    public void Phase4()
    {
        star = string.Empty;

        int rows = 5;

        // ���� (1 ~ 5)
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                star += "  "; // ���� 2ĭ
            }

            for (int k = 1; k <= i; k++)
            {
                star += "��";
            }

            star += "\n";
        }

        // �Ʒ��� (4 ~ 1)
        for (int i = rows - 1; i >= 1; i--)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                star += "  ";
            }

            for (int k = 1; k <= i; k++)
            {
                star += "��";
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        int rows = 5; // �߾� �� ����
        string space = "  "; // 2ĭ ����
        string symbol = "�� ";

        // ���� (1~5)
        for (int i = 1; i <= rows; i++)
        {
            int spaceCount = rows - i;
            int starCount = 2 * i - 1;

            star += new string(' ', spaceCount * 2); // 2ĭ ���� ����
            for (int j = 1; j <= starCount; j++)
            {
                star += "�� ";
            }
            star += "\n";
        }

        // �Ʒ��� (4~1)
        for (int i = rows - 1; i >= 1; i--)
        {
            int spaceCount = rows - i;
            int starCount = 2 * i - 1;

            star += new string(' ', spaceCount * 2);
            for (int j = 1; j <= starCount; j++)
            {
                star += "�� ";
            }
            star += "\n";
        }

        Debug.Log(star);
    }
}
