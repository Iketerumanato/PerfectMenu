using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] MainMenu _mainmenu;
    [SerializeField] OptionMenu _optionmenu;

    public void ToStartGameResumeButton()
    {
        _mainmenu.CloseMenu();
        SEController._secontroller.PlaySE(SEController.SESoundData.SE.Click);
    }

    public void ToStartOptionButton()
    {
        _optionmenu.OpenOption();
        SEController._secontroller.PlaySE(SEController.SESoundData.SE.Click);
    }

    public void ToStartGotoTitleButton()
    {
        Debug.Log("Go to Title");
        SEController._secontroller.PlaySE(SEController.SESoundData.SE.Click);
    }
}
