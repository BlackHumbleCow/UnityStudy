using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this.transform.position = this.transform.position + Vector3.forward;
        //���� ��ġ = ���� ��ġ + (x = 0, y = 0, z = 1)
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        {
            transform.position += Vector3.forward * Time.deltaTime * MoveSpeed;
        }
        
        if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
        {
            transform.position += Vector3.back * Time.deltaTime * MoveSpeed;
        }
        
        if (Input.GetKey(KeyCode.A)) // �������� ���� ���
        {
            transform.position += Vector3.left * Time.deltaTime * MoveSpeed;
        }
        
        if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
        {
            transform.position += Vector3.right * Time.deltaTime * MoveSpeed;
        }
    }
}
