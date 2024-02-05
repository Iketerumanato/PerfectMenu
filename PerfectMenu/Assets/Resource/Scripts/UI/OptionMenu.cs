using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    [SerializeField] CanvasGroup OpitonCanvasGroup;
    [SerializeField] Slider FirstSelectSlider;
    [SerializeField] MainMenu _mainmenu;
    readonly float MaxAlpha = 1f;
    readonly float MinAlpha = 0f;

    private void Start()
    {
        FadeInOption();
    }

    public void OpenOption()
    {
        FadeOutOption();
        _mainmenu.FadeInMenu();
        FirstSelectSlider.Select();
    }

    public void CloseOption()
    {
        FadeInOption();
        _mainmenu.FadeOutMenu();
    }

    void FadeOutOption()
    {
        this.GetComponent<OptionMenu>().enabled = true;
        OpitonCanvasGroup.alpha = MaxAlpha;
    }

    void FadeInOption()
    {
        this.GetComponent<OptionMenu>().enabled = false;
        OpitonCanvasGroup.alpha = MinAlpha;
    }
}
