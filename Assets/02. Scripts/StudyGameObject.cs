using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    //public GameObject destroyObj;

    //public Vector3 pos; // ��ġ x,y,z 0 0 0
    //public Quaternion rot; // ȸ�� 0,0,0,0

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //����Ƽ ������ ����� 1�� �۵�
    {
        CreateAmogus();

        //Destroy(destroyObj, 3f); // ������ ���ӿ�����Ʈ 3�� �� �ı� 
    }

    //void OnDestroy() // Spawner�� �ı��� �� �۵�
    //{
    //    Debug.Log("�ı��Ǿ����ϴ�.");
    //}

    //���� ĳ���͸� �����ϰ� �̸��� �ο��ϴ� ���
    public void CreateAmogus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "AMOGUS SUS";

        Transform objTf = obj.transform;
        //�ڽ� �������� ����
        int countObj = objTf.childCount; 

        //�θ� �������� ����
        //objTf.parent;
        //objTf.root;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ ��: {countObj}"); //�ڽ� ������Ʈ�� �� ������ transform�� ����
        
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ ��: {obj.transform.GetChild(0).name}"); //ù��° �ڽ� ������Ʈ �̸� ����

        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ ��: {obj.transform.GetChild(countObj).name}"); //������ �ڽ� ������Ʈ �̸� ����
    }

}