using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;

    public float rotSpeed = 30f; //자전속도

    public float revolutionSpeed = 100f; // 공전속도

    public bool isRevolution = false; // 논리타입

    // Update is called once per frame
    void Update()
    {
        // 자전 기능
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if(isRevolution == true) // 조건문 -> 만약 공전을 한다면
        {
            //공전 기능
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
            //주변을 돌아라(목표 행성의 위치, 방터 방향 양수, 공전속도, 델타 타임)
        }
    }
}
