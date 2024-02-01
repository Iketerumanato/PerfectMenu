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

    //private void Update()
    //{
    //    var current = Keyboard.current;
    //    var mKey = current.mKey;

    //    if (current == null) return;

    //    if (mKey.wasPressedThisFrame)
    //    {
    //        _mainmenu.OpenMenu();
    //    }
    //}
}