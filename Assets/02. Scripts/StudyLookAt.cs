using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firePos; // �߻� ��ġ

    public float timer;
    public float cooldownTime;
    
    void Start() // 1�� ���� -> �����ΰ��� �����ϴ� ���
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update() // �����ΰ��� �ٶ󺸴� ���
    {

        turretHead.LookAt(targetTf);

        timer += Time.deltaTime; // Ÿ�̸� ���
        if (timer >= cooldownTime) // ���� Ÿ�̸Ӱ� ��ٿ� �ð����� ũ�ٸ�
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            //          GameObjecty ���� ���, Vector3 ���� ��ġ, Quaternion ȸ�� ����
        }

    }
}
