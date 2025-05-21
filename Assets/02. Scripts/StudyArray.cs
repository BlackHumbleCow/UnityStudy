using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };
    public List<int> listNumber = new List<int>();

    //출력되지 않는 private 접근 제한자
    int number1 = 1; // = private
    private int number2 = 2;
    
    //출력이 되는 접근제한자
    public int number3 = 3;

    [SerializeField]
    private int number4 = 4;
    [SerializeField] int number5 = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
        Debug.Log($"Array의 세번째 값 : {arrayNumber[2]}");
        Debug.Log($"Array의 여섯번째 값 : {arrayNumber[5]}");

        Debug.Log($"현재 Array에 있는 데이터 수: {arrayNumber.Length}");

        listNumber.Add(10);
        listNumber.Add(50);
        listNumber.Add(30);
        listNumber.Add(20);
        listNumber.Add(40);

        //listNumber[0] : 첫번째 데이터
        //listNumber[2] : 세번째 데이터
                                             // arrayNumber.Length
        Debug.Log($"현재 List에 있는 데이터 수: {listNumber.Count}");
        Debug.Log($"현재 List의 마지막 데이터: {listNumber[listNumber.Count - 1]}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
