using UnityEngine;

public class ObjectMoveLog : MonoBehaviour
{
    public float Speed; // float = �⺻�� 0.0f

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log($"���� Z���� ���� {this.transform.position.z}");

        //this.transform.position = this.transform.position + Vector3.forward;

        //Debug.Log($"���� Z���� ���� {this.transform.position.z}");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + Vector3.forward * Speed;

        Debug.Log($"���� Z���� ���� {this.transform.position.z}");
    }
}
