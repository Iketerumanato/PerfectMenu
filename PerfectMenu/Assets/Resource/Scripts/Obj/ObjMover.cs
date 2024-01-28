using UnityEngine;

public class ObjMover : MonoBehaviour
{
    // ‰•œ‚·‚é’·‚³
    [SerializeField] float _length = 1;

    private void Update()
    {
        // ‰•œ‚µ‚½’l‚ğŠÔ‚©‚çŒvZ
        var value = Mathf.PingPong(Time.time, _length);

        // yÀ•W‚ğ‰•œ‚³‚¹‚Äã‰º‰^“®‚³‚¹‚é
        transform.localPosition = new Vector3(value, 0, 0);
    }
}
