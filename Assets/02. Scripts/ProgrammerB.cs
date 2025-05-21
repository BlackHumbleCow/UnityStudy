using UnityEngine;
using DevA;

public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA pA; // ProgrammerA 클래스 타입을 받는 변수 pA 선언
    // public 접근 가능 상태

    void Start()
    {
        //pA.number1 = 1;
        pA.number2 = 20;
        //pA.number3 = 3;
        //pA.number4 = 4;
        //pA.number5 = 5;

        //public인 number2 외에는 전부 접근 불가능 오류
    }
}
