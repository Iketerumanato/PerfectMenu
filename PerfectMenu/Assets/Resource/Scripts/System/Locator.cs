using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sumzap
{
    public static class Locator
    {
        // �P��C���X�^���X�p�f�B�N�V���i���[
        private static Dictionary<Type, object> _instanceDict = new();

        // �s�x�C���X�^���X�����p�f�B�N�V���i���[
        private static Dictionary<Type, Type> _typeDict = new Dictionary<Type, Type>();

        // �P��C���X�^���X��o�^����
        // �Ăђ����Ə㏑���o�^����
        public static void Register<T>(T instance) where T : class
        {
            _instanceDict[typeof(T)] = instance;
        }

        // �^��o�^����
        // ���̃��\�b�h�œo�^�����Resolve�����Ƃ��ɓs�x�C���X�^���X��������
        public static void Register<TContract, TConcrete>() where TContract : class
        {
            _typeDict[typeof(TContract)] = typeof(TConcrete);
        }

        // �^���w�肵�ēo�^����Ă���C���X�^���X���擾����
        public static T Resolve<T>() where T : class
        {
            T instance = default;

            Type type = typeof(T);

            if (_instanceDict.ContainsKey(type))
            {
                // ���O�ɐ������ꂽ�P��C���X�^���X��Ԃ�
                instance = _instanceDict[type] as T;
                return instance;
            }

            if (_typeDict.ContainsKey(type))
            {
                // �C���X�^���X�𐶐����ĕԂ�
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