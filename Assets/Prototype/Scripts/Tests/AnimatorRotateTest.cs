using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorRotateTest : MonoBehaviour
{
    [SerializeField]
    private Transform spine1;
    [SerializeField]
    private Transform spine2;
    [SerializeField]
    private Transform spine3;
    [SerializeField]
    private Transform spine4;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float spine1X;
    [SerializeField]
    private float spine1Y;
    [SerializeField]
    private float spine1Z;

    [SerializeField]
    private float spine2X;
    [SerializeField]
    private float spine2Y;
    [SerializeField]
    private float spine2Z;

    [SerializeField]
    private float spine3X;
    [SerializeField]
    private float spine3Y;
    [SerializeField]
    private float spine3Z;

    [SerializeField]
    private float spine4X;
    [SerializeField]
    private float spine4Y;
    [SerializeField]
    private float spine4Z;

    [SerializeField]
    private bool debugAngle;
    [SerializeField]
    private bool rotateDebug;

    [SerializeField]
    private Camera cam;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetDir = target.position;

        if (rotateDebug)
        {
            transform.LookAt(new Vector3(targetDir.x, transform.position.y, targetDir.z));
            spine1.localEulerAngles = new Vector3(spine1X, spine1Y, spine1Z);
            spine2.localEulerAngles = new Vector3(spine2X, spine2Y, spine2Z);
            spine3.localEulerAngles = new Vector3(spine3X, spine3Y, spine3Z);
            spine4.LookAt(targetDir);
            spine4.localEulerAngles = new Vector3(spine4.localEulerAngles.x, 0.0f, 0.0f);
        }

        if (debugAngle)
        {
            Debug.Log(Vector3.SignedAngle(transform.forward, targetDir, transform.right));
        }
        else
        {
            Debug.Log("From angle: " + (new Vector3(0.0f, spine4.position.y, 0.0f)));
            Debug.Log("To angle: " + targetDir);
        }
    }
}
