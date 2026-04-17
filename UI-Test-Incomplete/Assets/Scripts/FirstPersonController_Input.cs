using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

[RequireComponent(typeof(FirstPersonController))]
public class FirstPersonController_Input : MonoBehaviour
{
    FirstPersonController controller;
    InputSystem inputs;

    // Start is called before the first frame update
    void Start()
    {

        inputs = new InputSystem();
        inputs.Enable();

        controller = GetComponent<FirstPersonController>();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        Vector2 dir = inputs.Player.Move.ReadValue<Vector2>();

        controller.Move(dir, Time.fixedDeltaTime);
    }
    private void LateUpdate()
    {
        Vector2 look = inputs.Player.Look.ReadValue<Vector2>();

        controller.Look(new Vector2(look.x, look.y));
    }
}
