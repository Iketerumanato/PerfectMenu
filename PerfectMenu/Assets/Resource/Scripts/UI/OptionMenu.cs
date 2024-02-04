using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    CanvasGroup OptionCanvasGroup;
    readonly float MaxAlpha = 1f;
    readonly float MinAlpha = 0f;
    readonly MainMenu _mainmenu = new();
    [SerializeField] Slider FirstSelectSlider;

    // Start is called before the first frame update
    void Start()
    {
        OptionCanvasGroup = gameObject.GetComponent<CanvasGroup>();
        FirstSelectSlider.Select();
        FadeInOption();
    }

    public void OpenOption()
    {
        _mainmenu.enabled = false;
        this.GetComponent<OptionMenu>().enabled = true;
        OptionCanvasGroup.alpha = MaxAlpha;
    }

    public void CloseOption()
    {
        _mainmenu.enabled = true;
        this.GetComponent<OptionMenu>().enabled = false;
        OptionCanvasGroup.alpha = MinAlpha;
    }

    void FadeInOption()
    {
        this.GetComponent<OptionMenu>().enabled = false;
        OptionCanvasGroup.alpha = MinAlpha;
    }
}
