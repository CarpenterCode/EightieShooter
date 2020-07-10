using System.Linq;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float mouseSensitivity;

    [SerializeField] Transform playerBody;

    Vector3 mousePos;
    float lookUp = 0;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    private void Update()
    {
        RotatePlayer();
    }


    void RotatePlayer()
    {
        mousePos.x = Input.GetAxis("Mouse X");
        mousePos.y = Input.GetAxis("Mouse Y");

        playerBody.Rotate(Vector3.up * mousePos.x);

        lookUp -= mousePos.y;
        lookUp = Mathf.Clamp(lookUp, -100, 100);
        transform.localRotation = Quaternion.Euler(lookUp, 0, 0);
    }
}
