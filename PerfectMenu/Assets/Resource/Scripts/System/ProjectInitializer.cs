using UnityEngine;

namespace Sumzap
{
    /// <summary>
    /// �v���W�F�N�g�̏�����
    /// </summary>
    public static class ProjectInitializer
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Initialize()
        {
            // ���̕ϐ���؂�ւ��邱�ƂŐ�������C���X�^���X�؂�ւ��܂�
            // �P�����̂��߃N���X����#define�Œ�`���Ă��܂�
            // ���ۂɂ�Scripting Define Symbols��ݒ�t�@�C����ǂݍ��񂾂肵�Đ؂�ւ��܂�
            bool useDebugSystem;

#if DEBUG
            useDebugSystem = false;
#endif

            if (useDebugSystem)
            {
                // �����ȏ������s���C���X�^���X��o�^
                Locator.Register<ISomeSystem>(new SomeSystem());
            }
        }
    }
}