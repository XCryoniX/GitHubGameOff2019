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

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetDir = target.position - spine4.position;
        spine1.eulerAngles = new Vector3(spine1X, spine1Y, spine1Z);
        spine2.eulerAngles = new Vector3(spine2X, spine2Y, spine2Z);
        spine3.eulerAngles = new Vector3(spine3X, spine3Y, spine3Z);
        Debug.Log(Vector3.SignedAngle(targetDir, -spine4.right, -Vector3.forward));
        spine4.eulerAngles = new Vector3(spine4X, spine4Y, Vector3.SignedAngle(targetDir, -spine4.right, -Vector3.forward));
    }
}
