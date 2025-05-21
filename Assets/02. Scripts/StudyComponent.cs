using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj; // 유니티 게임 오브젝트를 등록하는 변수

    public string changeName; //유니티에서 설정 가능한 문자열 변수

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.Find("Main Camera"); // Main Camera 오브젝트를 찾아서 할당하는 기능

        obj.name = changeName;// 오브젝트의 이름을 바꾸는 기능
    }
}
