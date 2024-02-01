using UnityEngine;

namespace Sumzap
{
    public interface ISomeSystem
    {
        void SomeMethod();
        void DebugMethod();
    }

    public class SomeSystem : ISomeSystem
    {
        public void SomeMethod()
        {
            // �����ȏ���
            Debug.Log("a");
        }

        public void DebugMethod()
        {
            // �f�o�b�O�p�̏���
            Debug.Log("debug");
        }
    }
}