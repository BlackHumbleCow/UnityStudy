using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    //public GameObject destroyObj;

    //public Vector3 pos; // 위치 x,y,z 0 0 0
    //public Quaternion rot; // 회전 0,0,0,0

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //유니티 에디터 실행시 1번 작동
    {
        CreateAmogus();

        //Destroy(destroyObj, 3f); // 지정한 게임오브젝트 3초 뒤 파괴 
    }

    //void OnDestroy() // Spawner가 파괴될 때 작동
    //{
    //    Debug.Log("파괴되었습니다.");
    //}

    //어몽어스 캐릭터를 생성하고 이름을 부여하는 기능
    public void CreateAmogus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "AMOGUS SUS";

        Transform objTf = obj.transform;
        //자식 방향으로 접근
        int countObj = objTf.childCount; 

        //부모 방향으로 접근
        //objTf.parent;
        //objTf.root;

        Debug.Log($"캐릭터의 자식 오브젝트 수: {countObj}"); //자식 오브젝트의 수 접근은 transform을 통해
        
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트 수: {obj.transform.GetChild(0).name}"); //첫번째 자식 오브젝트 이름 접근

        Debug.Log($"캐릭터의 마지막 자식 오브젝트 수: {obj.transform.GetChild(countObj).name}"); //마지막 자식 오브젝트 이름 접근
    }

}