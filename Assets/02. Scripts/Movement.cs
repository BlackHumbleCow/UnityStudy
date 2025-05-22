using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this.transform.position = this.transform.position + Vector3.forward;
        //현재 위치 = 현재 위치 + (x = 0, y = 0, z = 1)
    }

    // Update is called once per frame
    void Update()
    {
        /// Input System(old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 - WASD, 화살표 키보드
        /// 점프 - Space
        /// 총 쏘기 - 마우스 좌클릭

        //if (Input.GetKey(KeyCode.W)) // 앞으로 가는 기능
        //{
        //    transform.position += Vector3.forward * Time.deltaTime * MoveSpeed;
        //}

        //if (Input.GetKey(KeyCode.S)) // 뒤로 가는 기능
        //{
        //    transform.position += Vector3.back * Time.deltaTime * MoveSpeed;
        //}

        //if (Input.GetKey(KeyCode.A)) // 왼쪽으로 가는 기능
        //{
        //    transform.position += Vector3.left * Time.deltaTime * MoveSpeed;
        //}

        //if (Input.GetKey(KeyCode.D)) // 오른쪽으로 가는 기능
        //{
        //    transform.position += Vector3.right * Time.deltaTime * MoveSpeed;
        //}

        //부드럽게 증감하는 값
        float h = Input.GetAxis("Horizontal"); // x값 조작. 왼쪽은 -x값 오른쪽은 +값
        float v = Input.GetAxis("Vertical"); //y값 조작. 위쪽은 +y값 아래쪽은 -y값

        //1씩 딱 떨어지는 값 1 아니면 -1
        //float hr = Input.GetAxisRaw("Horizontal"); // x값 조작. 왼쪽은 -x값 오른쪽은 +값
        //float vr = Input.GetAxisRaw("Vertical"); //y값 조작. 위쪽은 +y값 아래쪽은 -y값

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력: {dir}");

        transform.position += dir * MoveSpeed * Time.deltaTime;
    }
}
