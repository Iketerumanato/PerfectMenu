using UnityEngine;
using UnityEngine.InputSystem;

//public interface IOpenMenu
//{
//    void OpenMenu();
//}

public class MainMenu : MonoBehaviour//, IOpenMenu
{
    CanvasGroup MenuCanvasGroup;
    [SerializeField] PlayerInput _playerinput;
    readonly float MaxAlpha = 1f;
    readonly float MinAlpha = 0f;
    readonly Poser _poser = new();
    readonly OptionMenu _optionmenu = new();

    private void Start()
    {
        MenuCanvasGroup = gameObject.GetComponent<CanvasGroup>();
        FadeInMenu();
    }

    public void OpenMenu()
    {
        this.GetComponent<MainMenu>().enabled = true;
        _poser.PoseTime();
        _playerinput.actions.FindActionMap("Player").Disable();
        _playerinput.actions.FindActionMap("UI").Enable();
        MenuCanvasGroup.alpha = MaxAlpha;
    }

    //ResumeButton‚É‚à“K‰ž‚³‚¹‚é
    public void CloseMenu()
    {
        this.GetComponent<MainMenu>().enabled = false;
        _poser.ResumeTime();
        _playerinput.actions.FindActionMap("UI").Disable();
        _playerinput.actions.FindActionMap("Player").Enable();
        MenuCanvasGroup.alpha = MinAlpha;

        SEController._secontroller.PlaySE(SEController.SESoundData.SE.Click);
    }

    void FadeInMenu()
    {
        this.GetComponent<MainMenu>().enabled = false;
        MenuCanvasGroup.alpha = MinAlpha;
    }

    public void ToStartGotoTitleButton()
    {
        Debug.Log("Go to Title");
        SEController._secontroller.PlaySE(SEController.SESoundData.SE.Click);
    }

    public void ToStartOptionButton()
    {
        _optionmenu.OpenOption();
        SEController._secontroller.PlaySE(SEController.SESoundData.SE.Click);
    }
}