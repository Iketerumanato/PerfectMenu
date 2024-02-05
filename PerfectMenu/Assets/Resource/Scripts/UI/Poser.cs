using UnityEngine;

public class Poser
{
    public bool IsPose = false;
    readonly float StopGameTimeScale = 0f;
    readonly float ResumeGameTimeScale = 1f;

    public static Poser _poser;

    public void PoseTime()
    {      
        Time.timeScale = StopGameTimeScale;
    }

    public void ResumeTime()
    {
        Time.timeScale = ResumeGameTimeScale;
    }
}