using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int count;

    void Awake()
    {
        count = 0;
    }

    public void Gacha()
    {
        for (int i = 0; i < 10; i++)
        {
            
        }

        int number = 0;
        while(number < 10)
        {
            number++;
        }
    }

    public int selectNumbe = 5;

    public void GachaSwitch()
    {
        switch(selectNumbe)
        {
            case 0:
                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�.");
                break;

            case 1:
                Debug.Log("'������ �Ӹ�'�� �̾Ҵ�.");
                break;

            case 3:
                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�.");
                break;

            default:
                Debug.Log("'��Ÿ �Ӹ�'�� �̾Ҵ�.");
                break;
        }
    }

}

