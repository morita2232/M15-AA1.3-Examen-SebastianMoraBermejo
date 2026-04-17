using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public RectTransform rect;
    public GameObject inventory;

    InputSystem inputs;

    public Vector2 size;

    private void Start()
    {

        inputs = new InputSystem();
        inputs.Enable();

        size = rect.sizeDelta;
    }

    private void Update()
    {
        if (inputs.Player.Interact.WasPressedThisFrame())
        {
            inventory.SetActive(true);


            Debug.Log("Pressed");

        }

    }


    public void CloseInventoryPanel()
    {
        inventory.SetActive(false);
    }

    public void HorizontalSlider(float value)
    {

        size.x = -value * 2;

        if (size.x <= -340f) size.x = -340f;

        rect.sizeDelta = size;

    }

    public void VerticalSlider(float value)
    {

        size.y = -value;

        rect.sizeDelta = size;

    }

}
