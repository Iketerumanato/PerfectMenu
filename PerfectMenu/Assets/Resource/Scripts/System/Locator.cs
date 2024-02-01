using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sumzap
{
    public static class Locator
    {
        // 単一インスタンス用ディクショナリー
        private static Dictionary<Type, object> _instanceDict = new();

        // 都度インスタンス生成用ディクショナリー
        private static Dictionary<Type, Type> _typeDict = new Dictionary<Type, Type>();

        // 単一インスタンスを登録する
        // 呼び直すと上書き登録する
        public static void Register<T>(T instance) where T : class
        {
            _instanceDict[typeof(T)] = instance;
        }

        // 型を登録する
        // このメソッドで登録するとResolveしたときに都度インスタンス生成する
        public static void Register<TContract, TConcrete>() where TContract : class
        {
            _typeDict[typeof(TContract)] = typeof(TConcrete);
        }

        // 型を指定して登録されているインスタンスを取得する
        public static T Resolve<T>() where T : class
        {
            T instance = default;

            Type type = typeof(T);

            if (_instanceDict.ContainsKey(type))
            {
                // 事前に生成された単一インスタンスを返す
                instance = _instanceDict[type] as T;
                return instance;
            }

            if (_typeDict.ContainsKey(type))
            {
                // インスタンスを生成して返す
                instance = Activator.CreateInstance(_typeDict[type]) as T;
                return instance;
            }

            if (instance == null)
            {
                Debug.LogWarning($"Locator: {typeof(T).Name} not found.");
            }
            return instance;
        }
    }
}