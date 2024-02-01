using UnityEngine;

//public interface IOpenMenu
//{
//    void OpenMenu();
//}

public class MainMenu : MonoBehaviour//, IOpenMenu
{
    readonly float StopGameTime = 0f;
    readonly float ResumeGameTime = 1f;
    CanvasGroup MenuCanvasGroup;

    private void Start()
    {
        MenuCanvasGroup = gameObject.GetComponent<CanvasGroup>();
        CloseMenu();
    }

    public void OpenMenu()
    {
        MenuCanvasGroup.alpha = 1f;
        Time.timeScale = StopGameTime;
    }

    public void CloseMenu()
    {
        MenuCanvasGroup.alpha = 0f;
        Time.timeScale = ResumeGameTime;
    }

    //public void ToStartResumeButton()
    //{

    //}

    //public void ToStartGotoTitleButton()
    //{

    //}

    //public void ToStartOptionButton()
    //{

    //}
}