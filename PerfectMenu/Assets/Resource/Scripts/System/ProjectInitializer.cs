using UnityEngine;

namespace Sumzap
{
    /// <summary>
    /// プロジェクトの初期化
    /// </summary>
    public static class ProjectInitializer
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Initialize()
        {
            // この変数を切り替えることで生成するインスタンス切り替えます
            // 単純化のためクラス内の#defineで定義しています
            // 実際にはScripting Define Symbolsや設定ファイルを読み込んだりして切り替えます
            bool useDebugSystem;

#if DEBUG
            useDebugSystem = false;
#endif

            if (useDebugSystem)
            {
                // 正式な処理を行うインスタンスを登録
                Locator.Register<ISomeSystem>(new SomeSystem());
            }
        }
    }
}