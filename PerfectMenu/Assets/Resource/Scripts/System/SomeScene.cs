using UnityEngine;

namespace Sumzap
{
    public class SomeScene : MonoBehaviour
    {
        public void Start()
        {
            // �V�X�e���̌^���w�肵�ēo�^����Ă���C���X�^���X��ServiceLocator����擾
            var system = Locator.Resolve<ISomeSystem>();
            system.DebugMethod();


            /* �ȉ��A��r�p */
            // new�̏ꍇ
            var system2 = new SomeSystem();
            system2.DebugMethod();
        }
    }
}