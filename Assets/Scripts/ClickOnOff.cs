using UnityEngine;
using UnityEngine.InputSystem;

public class ClickOnOff : MonoBehaviour
{
    [Tooltip("The input action that will turn the object on and off.")]
    [SerializeField] InputAction turnOnOff = new InputAction(type: InputActionType.Button);

    [Tooltip("The renderer of the object.")]
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        turnOnOff.Enable();
    }

    private void OnDisable()
    {
        turnOnOff.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (turnOnOff.WasPressedThisFrame()) // Fix on line 31: Added a space after `if`.
        {
            if (rend.enabled)                // Fix on line 33: Added a space after `if`.
            {
                rend.enabled = false;        // Fix on line 34: Properly indented this block with 9 spaces.
            }
            else
            {
                rend.enabled = true;
            }
        }
    }
}