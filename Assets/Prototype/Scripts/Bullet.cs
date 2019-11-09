using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    public Transform referenceObject;

    void Update()
    {
        transform.position += ((transform.forward * Time.deltaTime) * 20.0f);

        if(Vector3.Distance(transform.position, referenceObject.position) >= 60.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "AI" || other.tag == "Obstacle")
        {
            //Destroy(gameObject);
        }
    }
}
