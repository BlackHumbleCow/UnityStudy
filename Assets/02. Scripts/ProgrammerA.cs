using UnityEngine;

namespace DevA
{
    public class ProgrammerA : MonoBehaviour
    {
        int number1; // private ���� �������

        
        public int number2; // public �������
        
        private int number3; // private �������

        [SerializeField] int number4; // private �������

        [SerializeField]
        private int number5; // private �������
        

	void Start()
        {
            int number6; // ����(���� ����)
        }

    }
}
