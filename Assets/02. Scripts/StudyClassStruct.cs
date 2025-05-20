using UnityEngine;

public class Study_Class
{
    public int number;

    // 생성자: 생성될 때 실행되는 함수
    public Study_Class(int number)//(매개변수)
    {
        this.number = number;
    }
}

public struct Study_Struct
{
    public int number;

    public Study_Struct(int number)
    {
        this.number = number;
    }
}

public class StudyClassStruct : MonoBehaviour
{
    void Start()
    {
        Debug.Log("클래스----------------------------------"); // 클라우드 저장소를 공유 중
        Study_Class c1 = new Study_Class(10); //c1에 Study_Class가 가진 10이란 값을 참조
        Study_Class c2 = c1; //c2는 c1을 참조 -> c1은 Study_Class 값을 참조 -> c2도 그 값을 참조
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");//둘 다 10

        c1.number = 100;//c1이 Study_Class의 값을 100으로 변경
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");//c1 따라 c2도 100으로 값 변경


        Debug.Log("구조체----------------------------------"); // 로컬 저장소로 다운 받아둔 것
        Study_Struct s1 = new Study_Struct(10); //s1에 Study_Struct의 10이란 값을 가져온다
        Study_Struct s2 = s1; //s2는 s1의 값을 자신에게 가져온다
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");//둘 다 10

        s1.number = 100;//s1만 100으로 변경
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");//s1은 변경된 값으로, s2는 본래 가지고 있던 값을 출력
    }
}
