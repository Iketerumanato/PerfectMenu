using UnityEngine;

public class ObjMover : MonoBehaviour
{
    // 往復する長さ
    [SerializeField] float _length = 1;

    private void Update()
    {
        // 往復した値を時間から計算
        var value = Mathf.PingPong(Time.time, _length);

        // y座標を往復させて上下運動させる
        transform.localPosition = new Vector3(value, 0, 0);
    }
}
