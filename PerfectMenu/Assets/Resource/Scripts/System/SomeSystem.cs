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
            // 正式な処理
            Debug.Log("a");
        }

        public void DebugMethod()
        {
            // デバッグ用の処理
            Debug.Log("debug");
        }
    }
}