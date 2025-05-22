using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // ����Ƽ ���� ������Ʈ�� ����ϴ� ����

    public Transform objTf;// Tranform Ÿ���� ����

    //public string changeName; //����Ƽ���� ���� ������ ���ڿ� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //obj.name = changeName; // ������Ʈ�� �̸��� �ٲٴ� ���

        //obj = GameObject.Find("Main Camera"); // Main Camera ������Ʈ�� ã�Ƽ� �Ҵ��ϴ� ���

        //Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player"); // �±��� �̸��� Ȱ���� ������Ʈ �˻�

        //Player��� �±׸� ���� ���ӿ�����Ʈ�� ã�Ƽ� .transform �������� objTf�� �Ҵ�
        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        // = objTf = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>;

        //obj = objTf.gameobject - ���� ���ӿ�����Ʈ�� ã�ұ� ����

        //Debug.Log($"<color=#FF0000>�̸�: {obj.name}"); // ���ӿ�����Ʈ�� �̸�
        //Debug.Log($"<color=#00FF00>�±�: {obj.tag}"); // ���ӿ�����Ʈ�� �±�
        //Debug.Log($"<color=#0000FF>��ġ: {obj.transform.position}"); // ���ӿ�����Ʈ�� transform ������Ʈ�� ��ġ
        //Debug.Log($"<color=#FFFF00>ȸ��: {obj.transform.rotation}"); // ���ӿ�����Ʈ�� transform ������Ʈ�� ȸ��
        //Debug.Log($"<color=#FF00FF>ũ��: {obj.transform.localScale}"); // ���ӿ�����Ʈ�� transform ������Ʈ�� ũ��

        // MeshFilter ������Ʈ�� �����ؼ� mesh�� Log �޼����� �ⷰ�ϴ� ���
        Debug.Log($"Mesh ������: {obj.GetComponent<MeshFilter>().mesh}");

        // MeshRenderer ������Ʈ�� �����ؼ� material�� Log �޼����� ����ϴ� ���
        Debug.Log($"Material ������: {obj.GetComponent<MeshRenderer>().material}");

        //obj�� MeshRenderer�� �����ؼ� Ȱ�� ���¸� false(���� ���)
        obj.GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<������Ÿ��>

        // obj�� GameObject Ȱ�����¸� false(���� ���)
        obj.SetActive(false);

        //transform���� SetActive�� ������ transform�� ���ӿ�����Ʈ���� �ִٴ� ���� �̿�
        objTf.gameObject.SetActive(false);
    }
}
