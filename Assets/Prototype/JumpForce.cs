using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpForce : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Trigger")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 500.0f, 0.0f), ForceMode.Impulse);
        }
    }
}
