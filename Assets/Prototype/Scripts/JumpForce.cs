using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpForce : MonoBehaviour
{
    [SerializeField]
    private float force = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Trigger")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, force, 0.0f), ForceMode.Impulse);
        }
    }
}
