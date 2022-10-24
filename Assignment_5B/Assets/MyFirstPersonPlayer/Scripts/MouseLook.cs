/* Kyree Richardson
 * Assignment 5B
 * (Contorls mouse behavior)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;

    void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //gets mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotate player GameObject with horizontal mouse input
        player.transform.Rotate(Vector3.up * mouseX);

        //rotate camera around the x axis with vertical mouse input
        verticalLookRotation -= mouseY;

        //clamp the rotation so the player does not over-rotate
        //and look behind themselves upside down
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        //apply rotation based on the clamped input
        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }
}
