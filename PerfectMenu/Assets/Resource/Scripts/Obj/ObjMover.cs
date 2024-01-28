using UnityEngine;

public class ObjMover : MonoBehaviour
{
    // �������钷��
    [SerializeField] float _length = 1;

    private void Update()
    {
        // ���������l�����Ԃ���v�Z
        var value = Mathf.PingPong(Time.time, _length);

        // y���W�����������ď㉺�^��������
        transform.localPosition = new Vector3(value, 0, 0);
    }
}
