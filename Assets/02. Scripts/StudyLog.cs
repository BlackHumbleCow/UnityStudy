using UnityEngine;

/// <summary>
/// ����Ƽ �����Ϳ� �ִ� Console View�� Log�� �׽�Ʈ�ϱ� ���� Ŭ����
/// </summary>

public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Start�� Update() ���� ���� �� ���� ���� �����Ѵ�.
    void Start() //Unity �⺻ �Լ�
    {
        Debug.Log("Start �Լ� ����");
        Debug.LogWarning("Start �Լ� ���");
        Debug.LogError("Start �Լ� ����");
    }

    // Update is called once per frame
    // Update�� �� �����Ӹ��� �� ���� �����Ѵ�.
    void Update() //Unity �⺻ �Լ�
    {

    }
}
