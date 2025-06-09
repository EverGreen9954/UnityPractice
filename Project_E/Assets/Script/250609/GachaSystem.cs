using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    class Character
    {
        public string name;
        public float rate; // �����

        public Character(string name, float rate)
        {
            this.name = name;
            this.rate = rate;
        }
    }

    List<Character> characterPool;

    void Start()
    {
        characterPool = new List<Character>
        {
            new Character("����", 1.19f),
            new Character("����", 1.98f),
            new Character("���", 1.98f),
            new Character("����", 3.95f),
            new Character("����", 19.76f),
            new Character("�κ�", 19.76f),
            new Character("���", 19.76f),
            new Character("¡��", 31.62f)
        };
    }

    public void OnGachaButtonClick()
    {
        for (int i = 0; i < 10; i++)
        {
            var result = GetRandomCharacter();
            Debug.Log($"{result.rate}%�� Ȯ���� {result.name}�� ȹ���Ͽ����ϴ�.");
        }
    }

    Character GetRandomCharacter()
    {
        float rand = Random.Range(0f, 100f);
        float cumulative = 0f;

        foreach (var character in characterPool)
        {
            cumulative += character.rate;
            if (rand <= cumulative)
                return character;
        }

        return characterPool[characterPool.Count - 1]; // fallback
    }
}
