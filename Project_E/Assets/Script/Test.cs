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
//        Debug.Log("�ȳ��Ͻÿ�, �� �̸���" + name + "�̿ýô�.");
//        Debug.Log("���̴�" + age + "����.");
//        Debug.Log("Ű��" + height + "�����̿�.");
//        Debug.Log("���� MBTI��" + mbti + "�̿�.");
//        Debug.Log("��̴�" + hobbyOne + "�̿�.");
//        Debug.Log("�����ϴ� ������" + favoriteFood + "�̿�.");
//        Debug.Log("������ �̸���" + dogName + "�̿�.");
//        Debug.Log("��� ����" + loaction + "�̿�.");
//        Debug.Log("�����ϴ� ������" + favoriteGame + "�̿�.");
//        Debug.Log("��̴�" + hobbyTwo + "�̿�.");
//        Debug.Log("�̻��̿ýô�.");
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

    public Text dialogueText; // UI Text ������Ʈ ����
    public Button nextButton; // UI Button ����

    void Start()
    {
        dialogues.Add("�ȳ��Ͻÿ�, �� �̸��� " + name + "�̿ýô�.");
        dialogues.Add("���̴� " + age + "����.");
        dialogues.Add("Ű�� " + height + "�����̿�.");
        dialogues.Add("���� MBTI�� " + mbti + "�̿�.");
        dialogues.Add("��̴� " + hobbyOne + "�̿�.");
        dialogues.Add("�����ϴ� ������ " + favoriteFood + "�̿�.");
        dialogues.Add("������ �̸��� " + dogName + "�̿�.");
        dialogues.Add("��� ���� " + location + "�̿�.");
        dialogues.Add("�����ϴ� ������ " + favoriteGame + "�̿�.");
        dialogues.Add("��̴� " + hobbyTwo + "�̿�.");
        dialogues.Add("�̻��̿ýô�.");

        nextButton.onClick.AddListener(ShowNextDialogue); // ��ư Ŭ�� �� ����� �Լ� ����
        ShowNextDialogue(); // ������ �� ù ��� ���
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
            dialogueText.text = "��ȭ�� ������.";
            nextButton.interactable = false; // ��ư ��Ȱ��ȭ
        }
    }
}