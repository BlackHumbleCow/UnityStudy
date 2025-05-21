using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };
    public List<int> listNumber = new List<int>();

    //��µ��� �ʴ� private ���� ������
    int number1 = 1; // = private
    private int number2 = 2;
    
    //����� �Ǵ� ����������
    public int number3 = 3;

    [SerializeField]
    private int number4 = 4;
    [SerializeField] int number5 = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Array�� ù��° �� : {arrayNumber[0]}");
        Debug.Log($"Array�� ����° �� : {arrayNumber[2]}");
        Debug.Log($"Array�� ������° �� : {arrayNumber[5]}");

        Debug.Log($"���� Array�� �ִ� ������ ��: {arrayNumber.Length}");

        listNumber.Add(10);
        listNumber.Add(50);
        listNumber.Add(30);
        listNumber.Add(20);
        listNumber.Add(40);

        //listNumber[0] : ù��° ������
        //listNumber[2] : ����° ������
                                             // arrayNumber.Length
        Debug.Log($"���� List�� �ִ� ������ ��: {listNumber.Count}");
        Debug.Log($"���� List�� ������ ������: {listNumber[listNumber.Count - 1]}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
