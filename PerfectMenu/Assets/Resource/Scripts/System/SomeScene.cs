using UnityEngine;

namespace Sumzap
{
    public class SomeScene : MonoBehaviour
    {
        public void Start()
        {
            // システムの型を指定して登録されているインスタンスをServiceLocatorから取得
            var system = Locator.Resolve<ISomeSystem>();
            system.DebugMethod();


            /* 以下、比較用 */
            // newの場合
            var system2 = new SomeSystem();
            system2.DebugMethod();
        }
    }
}