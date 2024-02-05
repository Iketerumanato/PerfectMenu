using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

//public interface IOpenMenu
//{
//    void OpenMenu();
//}

public class MainMenu : MonoBehaviour//, IOpenMenu
{
    [SerializeField] CanvasGroup MainCanvasGroup;
    [SerializeField] CanvasGroup MenuCanvasGroup;
    [SerializeField] PlayerInput _playerinput;
    [SerializeField] Button FirstSelectButton;
    readonly float MaxAlpha = 1f;
    readonly float MinAlpha = 0f;

    private void Start()
    {
        MainCanvasGroup.alpha = MinAlpha;
        FadeInMenu();
    }

    public void OpenMenu()
    {
        FadeOutMenu();
        //Poser._poser.PoseTime();
        _playerinput.actions.FindActionMap("Player").Disable();
        _playerinput.actions.FindActionMap("UI").Enable();
        MainCanvasGroup.alpha = MaxAlpha;
        FirstSelectButton.Select();
    }

    //ResumeButton‚É‚à“K‰ž‚³‚¹‚é
    public void CloseMenu()
    {
        FadeInMenu();
        //Poser._poser.ResumeTime();
        _playerinput.actions.FindActionMap("UI").Disable();
        _playerinput.actions.FindActionMap("Player").Enable();
        MainCanvasGroup.alpha = MinAlpha;
    }

    public void FadeOutMenu()
    {
        this.GetComponent<MainMenu>().enabled = true;
        MenuCanvasGroup.alpha = MaxAlpha;
        FirstSelectButton.Select();
    }

    public void FadeInMenu()
    {
        this.GetComponent<MainMenu>().enabled = false;
        MenuCanvasGroup.alpha = MinAlpha;
    }
}