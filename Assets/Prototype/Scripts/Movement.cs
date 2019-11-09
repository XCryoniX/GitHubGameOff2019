using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float slowMo = 1.0f;

    [SerializeField]
    private float rotationSpeed = 1.0f;

    [SerializeField]
    private float movementSpeed = 1.0f;

    private float x;
    private float y;

    private Vector3 deltaRotation;

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

        if (x != 0 || y != 0)
        {
            deltaRotation = new Vector3((-y) * Time.deltaTime * rotationSpeed, (x) * Time.deltaTime * rotationSpeed, 0.0f);
            GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(deltaRotation + GetComponent<Rigidbody>().rotation.eulerAngles));
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (transform.forward * Time.deltaTime * movementSpeed));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(transform.position + new Vector3(0.0f, 200.0f, 0.0f), ForceMode.Impulse);
        }
    }
}
