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
        if(turnOnOff.WasPressedThisFrame())
        {
            if(rend.enabled) rend.enabled = false;
            else rend.enabled = true; 
        }
    }
}
