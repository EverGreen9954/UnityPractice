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
                Debug.Log("'은색 머리'를 뽑았다.");
                break;

            case 1:
                Debug.Log("'검은색 머리'를 뽑았다.");
                break;

            case 3:
                Debug.Log("'갈색 머리'를 뽑았다.");
                break;

            default:
                Debug.Log("'기타 머리'를 뽑았다.");
                break;
        }
    }

}

