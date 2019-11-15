using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum CameraType
{
    thirdPerson
}

public class Movement : MonoBehaviour
{
    [SerializeField]
    private CameraType cameraType = CameraType.thirdPerson;

    [SerializeField]
    private float slowMo = 1.0f;

    [SerializeField]
    private float rotationSpeed = 1.0f;

    [SerializeField]
    private float movementSpeed = 1.0f;

    private float x;
    private float y;

    private Vector3 deltaRotation;

    [SerializeField]
    private new Transform camera;

    [SerializeField]
    private Transform cameraTarget;

    [SerializeField]
    private float characterYOffset;

    private void Awake()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit(0);
        }

        if (Input.GetMouseButton(1))
        {
            Time.timeScale = 0.1f;
        }
        else
        {
            Time.timeScale = slowMo;
        }

        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Animator>().SetBool("Idle", false);
            GetComponent<Animator>().SetBool("RunForward", true);
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (transform.forward * Time.deltaTime * movementSpeed));
            transform.eulerAngles = new Vector3(0.0f, camera.localEulerAngles.y + characterYOffset, 0.0f);
        }
        else
        {
            GetComponent<Animator>().SetBool("RunForward", false);
            GetComponent<Animator>().SetBool("Idle", true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(transform.position + new Vector3(0.0f, 200.0f, 0.0f), ForceMode.Impulse);
        }

        camera.position = cameraTarget.position + camera.TransformDirection(new Vector3(0.0f, 0.0f, -20.0f));
        camera.position += camera.TransformDirection(new Vector3(-x, -y, 0.0f));
        camera.LookAt(cameraTarget.position, Vector3.up);
    }
}
