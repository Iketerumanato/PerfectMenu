using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    MainMenu _mainmenu = new();

    public void OnOpenMainMenu(InputAction.CallbackContext context)
    {
        if (!context.started) return;
        _mainmenu.OpenMenu();
    }

    public void OnCloseMainMenu(InputAction.CallbackContext context)
    {
        if (!context.started) return;
        _mainmenu.CloseMenu();
    }
}