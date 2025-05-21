using UnityEngine;

namespace DevA
{
    public class ProgrammerA : MonoBehaviour
    {
        int number1; // private 생략 멤버변수

        
        public int number2; // public 멤버변수
        
        private int number3; // private 멤버변수

        [SerializeField] int number4; // private 멤버변수

        [SerializeField]
        private int number5; // private 멤버변수
        

	void Start()
        {
            int number6; // 로컬(지역 변수)
        }

    }
}
