using UnityEngine;

public class StudyComponent2 : MonoBehaviour
{

    public GameObject obj;

    public Mesh mesh;
    public Material mat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        CreateCube();
        CreateCube("Hello World");
    }

    public void CreateCube(string name = "Cube") // 함수로 만들어 코드의 재사용성 증가 -> 기능 모듈화
    {
        // obj = new GameObject(); + obj.name = "Cube";
        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = mesh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;
        
        obj.AddComponent<BoxCollider>();

    }

}
