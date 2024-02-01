using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

//public interface IOpenMenu
//{
//    void OpenMenu();
//}

public class MainMenu : MonoBehaviour//, IOpenMenu
{
    readonly float StopGameTime = 0f;
    readonly float ResumeGameTime = 1f;
    CanvasGroup MenuCanvasGroup;
    [SerializeField] PlayerInput _playerinput;

    private void Start()
    {
        MenuCanvasGroup = gameObject.GetComponent<CanvasGroup>();
        CloseMenu();
    }

    public void OpenMenu()
    {
        this.gameObject.GetComponent<MainMenu>().enabled = true;
        _playerinput.actions.FindActionMap("Player").Disable();
        _playerinput.actions.FindActionMap("UI").Enable();
        MenuCanvasGroup.alpha = 1f;
        Time.timeScale = StopGameTime;
    }

    //ResumeButton‚É‚à“K‰ž‚³‚¹‚é
    public void CloseMenu()
    {
        this.gameObject.GetComponent<MainMenu>().enabled = false;
        _playerinput.actions.FindActionMap("UI").Disable();
        _playerinput.actions.FindActionMap("Player").Enable();
        MenuCanvasGroup.alpha = 0f;
        Time.timeScale = ResumeGameTime;
    }

    public void ToStartResumeButton()
    {
        Debug.Log("Resume InGame");
    }

    public void ToStartGotoTitleButton()
    {
        Debug.Log("Go to Title");
    }

    public void ToStartOptionButton()
    {
        Debug.Log("Open Option");
    }
}