using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // 유니티 게임 오브젝트를 등록하는 변수

    public Transform objTf;// Tranform 타입의 변수

    //public string changeName; //유니티에서 설정 가능한 문자열 변수

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //obj.name = changeName; // 오브젝트의 이름을 바꾸는 기능

        //obj = GameObject.Find("Main Camera"); // Main Camera 오브젝트를 찾아서 할당하는 기능

        //Player라는 Tag를 가진 게임오브젝트를 찾아서 obj에 할당
        obj = GameObject.FindGameObjectWithTag("Player"); // 태그의 이름을 활용해 오브젝트 검색

        //Player라는 태그를 가진 게임오브젝트를 찾아서 .transform 형식으로 objTf에 할당
        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        // = objTf = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>;

        //obj = objTf.gameobject - 같은 게임오브젝트를 찾았기 때문

        //Debug.Log($"<color=#FF0000>이름: {obj.name}"); // 게임오브젝트의 이름
        //Debug.Log($"<color=#00FF00>태그: {obj.tag}"); // 게임오브젝트의 태그
        //Debug.Log($"<color=#0000FF>위치: {obj.transform.position}"); // 게임오브젝트의 transform 컴포넌트의 위치
        //Debug.Log($"<color=#FFFF00>회전: {obj.transform.rotation}"); // 게임오브젝트의 transform 컴포넌트의 회전
        //Debug.Log($"<color=#FF00FF>크기: {obj.transform.localScale}"); // 게임오브젝트의 transform 컴포넌트의 크기

        // MeshFilter 컴포넌트에 접근해서 mesh를 Log 메세지로 출럭하는 기능
        Debug.Log($"Mesh 데이터: {obj.GetComponent<MeshFilter>().mesh}");

        // MeshRenderer 컴포넌트에 접근해서 material을 Log 메세지로 출력하는 기능
        Debug.Log($"Material 데이터: {obj.GetComponent<MeshRenderer>().material}");

        //obj의 MeshRenderer에 접근해서 활성 상태를 false(끄는 기능)
        obj.GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<데이터타입>

        // obj의 GameObject 활성상태를 false(끄는 기능)
        obj.SetActive(false);

        //transform에는 SetActive는 없지만 transform의 게임오브젝트에는 있다는 것을 이용
        objTf.gameObject.SetActive(false);
    }
}
