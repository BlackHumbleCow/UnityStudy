using UnityEngine;

/// <summary>
/// 유니티 에디터에 있는 Console View의 Log를 테스트하기 위한 클래스
/// </summary>

public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Start는 Update() 실행 전에 한 번만 먼저 실행한다.
    void Start() //Unity 기본 함수
    {
        Debug.Log("Start 함수 생성");
        Debug.LogWarning("Start 함수 경고");
        Debug.LogError("Start 함수 오류");
    }

    // Update is called once per frame
    // Update는 매 프레임마다 한 번씩 실행한다.
    void Update() //Unity 기본 함수
    {

    }
}
