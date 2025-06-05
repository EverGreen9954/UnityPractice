using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public class LSR : MonoBehaviour
//{
//    private string name = "Lee Sang Rok";
//    private int age = 26;
//    private float height = 1.70f;
//    private string mbti = "Istj";
//    private string hobbyOne = "Football";
//    private string favoriteFood = "Spycy Chicken Stew";
//    private string dogName = "MangBong";
//    private string loaction = "Seoul, South Korea";
//    private string favoriteGame = "StarCraft";
//    private string hobbyTwo = "Guitar";

//    void Start()
//    {
//        SelfIntroduction();
//    }

//    public void SelfIntroduction()
//    {
//        Debug.Log("안녕하시오, 내 이름은" + name + "이올시다.");
//        Debug.Log("나이는" + age + "세요.");
//        Debug.Log("키는" + height + "미터이오.");
//        Debug.Log("나의 MBTI는" + mbti + "이오.");
//        Debug.Log("취미는" + hobbyOne + "이오.");
//        Debug.Log("좋아하는 음식은" + favoriteFood + "이오.");
//        Debug.Log("강아지 이름은" + dogName + "이오.");
//        Debug.Log("사는 곳은" + loaction + "이오.");
//        Debug.Log("좋아하는 게임은" + favoriteGame + "이오.");
//        Debug.Log("취미는" + hobbyTwo + "이오.");
//        Debug.Log("이상이올시다.");
//    }

//}

public class LSR : MonoBehaviour
{
    private string name = "Lee Sang Rok";
    private int age = 26;
    private float height = 1.70f;
    private string mbti = "Istj";
    private string hobbyOne = "Football";
    private string favoriteFood = "Spycy Chicken Stew";
    private string dogName = "MangBong";
    private string location = "Seoul, South Korea";
    private string favoriteGame = "StarCraft";
    private string hobbyTwo = "Guitar";

    private List<string> dialogues = new List<string>();
    private int currentIndex = 0;

    public Text dialogueText; // UI Text 컴포넌트 연결
    public Button nextButton; // UI Button 연결

    void Start()
    {
        dialogues.Add("안녕하시오, 내 이름은 " + name + "이올시다.");
        dialogues.Add("나이는 " + age + "세요.");
        dialogues.Add("키는 " + height + "미터이오.");
        dialogues.Add("나의 MBTI는 " + mbti + "이오.");
        dialogues.Add("취미는 " + hobbyOne + "이오.");
        dialogues.Add("좋아하는 음식은 " + favoriteFood + "이오.");
        dialogues.Add("강아지 이름은 " + dogName + "이오.");
        dialogues.Add("사는 곳은 " + location + "이오.");
        dialogues.Add("좋아하는 게임은 " + favoriteGame + "이오.");
        dialogues.Add("취미는 " + hobbyTwo + "이오.");
        dialogues.Add("이상이올시다.");

        nextButton.onClick.AddListener(ShowNextDialogue); // 버튼 클릭 시 실행될 함수 연결
        ShowNextDialogue(); // 시작할 때 첫 대사 출력
    }

    public void ShowNextDialogue()
    {
        if (currentIndex < dialogues.Count)
        {
            dialogueText.text = dialogues[currentIndex];
            currentIndex++;
        }
        else
        {
            dialogueText.text = "대화가 끝났소.";
            nextButton.interactable = false; // 버튼 비활성화
        }
    }
}