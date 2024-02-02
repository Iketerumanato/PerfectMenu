using UnityEngine;

public class Poser : MonoBehaviour
{
    [System.NonSerialized]
    public bool IsPose = false;
    readonly float StopGameTimeScale = 0f;
    readonly float ResumeGameTimeScale = 1f;

    public void PoseTime()
    {      
        Time.timeScale = StopGameTimeScale;
    }

    public void ResumeTime()
    {
        Time.timeScale = ResumeGameTimeScale;
    }
}