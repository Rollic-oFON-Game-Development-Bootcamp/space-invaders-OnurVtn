using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    [SerializeField] private float sideMovementSensitivity = 1f;
    [SerializeField] private float sideMovementLerpSpeed = 20f;

    private Vector2 inputDrag;

    private Vector2 previousMousePosition;

    private float sideMovementTarget = 0f;

    private Vector2 mousePositionCM
    {
        get
        {
            Vector2 pixels = Input.mousePosition;
            var inches = pixels / Screen.dpi;
            var centimeters = inches * 2.54f;

            return centimeters;
        }
    }

    void Update()
    {
        HandleInput();
        HandleSideMovement();
    }

    private void HandleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousMousePosition = mousePositionCM;
        }
        if (Input.GetMouseButton(0))
        {
            var deltaMouse = mousePositionCM - previousMousePosition;
            inputDrag = deltaMouse;
            previousMousePosition = mousePositionCM;
        }
        else
        {
            inputDrag = Vector2.zero;
        }
    }

    private void HandleSideMovement()
    {
        sideMovementTarget += inputDrag.x * sideMovementSensitivity;

        var localPos = playerTransform.localPosition;

        localPos.x = Mathf.Lerp(localPos.x, sideMovementTarget, Time.deltaTime * sideMovementLerpSpeed);

        playerTransform.localPosition = localPos;
    }
}
