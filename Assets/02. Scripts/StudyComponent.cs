using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj; // ����Ƽ ���� ������Ʈ�� ����ϴ� ����

    public string changeName; //����Ƽ���� ���� ������ ���ڿ� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.Find("Main Camera"); // Main Camera ������Ʈ�� ã�Ƽ� �Ҵ��ϴ� ���

        obj.name = changeName;// ������Ʈ�� �̸��� �ٲٴ� ���
    }
}
