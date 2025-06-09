using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    class Character
    {
        public string name;
        public float rate; // ¹éºÐÀ²

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
            new Character("·çÇÇ", 1.19f),
            new Character("³ª¹Ì", 1.98f),
            new Character("»óµð", 1.98f),
            new Character("Á¶·Î", 3.95f),
            new Character("ÃÝÆÄ", 19.76f),
            new Character("·Îºó", 19.76f),
            new Character("¿ì¼Ù", 19.76f),
            new Character("Â¡º£", 31.62f)
        };
    }

    public void OnGachaButtonClick()
    {
        for (int i = 0; i < 10; i++)
        {
            var result = GetRandomCharacter();
            Debug.Log($"{result.rate}%ÀÇ È®·ü·Î {result.name}¸¦ È¹µæÇÏ¿´½À´Ï´Ù.");
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
