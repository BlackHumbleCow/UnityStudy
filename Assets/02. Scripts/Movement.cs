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
        /// Input System(old - Legacy)
        /// �Է°��� ���� ��ӵ� �ý���
        /// �̵� - WASD, ȭ��ǥ Ű����
        /// ���� - Space
        /// �� ��� - ���콺 ��Ŭ��

        //if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        //{
        //    transform.position += Vector3.forward * Time.deltaTime * MoveSpeed;
        //}

        //if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
        //{
        //    transform.position += Vector3.back * Time.deltaTime * MoveSpeed;
        //}

        //if (Input.GetKey(KeyCode.A)) // �������� ���� ���
        //{
        //    transform.position += Vector3.left * Time.deltaTime * MoveSpeed;
        //}

        //if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
        //{
        //    transform.position += Vector3.right * Time.deltaTime * MoveSpeed;
        //}

        //�ε巴�� �����ϴ� ��
        //float h = Input.GetAxis("Horizontal"); // x�� ����. ������ -x�� �������� +��
        //float v = Input.GetAxis("Vertical"); //y�� ����. ������ +y�� �Ʒ����� -y��

        //1�� �� �������� �� 1 �ƴϸ� -1 Raw(�� ����)
        float hr = Input.GetAxisRaw("Horizontal"); // x�� ����. ������ -x�� �������� +��
        float vr = Input.GetAxisRaw("Vertical"); //y�� ����. ������ +y�� �Ʒ����� -y��

        Vector3 dir = new Vector3(hr, 0, vr); //�� ���� �ڿ� .normalized�� �ص� ����

        Vector3 normalDir = dir.normalized; // ����ȭ ����(0~1)

        Debug.Log($"���� �Է�: {normalDir}");

        transform.position += normalDir * MoveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + normalDir); 
    }
}
