using UnityEngine;
using UnityEngine.InputSystem;

public class HandleMovement : MonoBehaviour
{
    void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
        {
            return;
        }
    }
}
