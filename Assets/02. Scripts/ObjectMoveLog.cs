using UnityEngine;

public class ObjectMoveLog : MonoBehaviour
{
    public float Speed; // float = 기본값 0.0f

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log($"현재 Z축의 값은 {this.transform.position.z}");

        //this.transform.position = this.transform.position + Vector3.forward;

        //Debug.Log($"현재 Z축의 값은 {this.transform.position.z}");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + Vector3.forward * Speed;

        Debug.Log($"현재 Z축의 값은 {this.transform.position.z}");
    }
}
