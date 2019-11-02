using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    public Transform referenceObject;

    void Update()
    {
        transform.position += ((transform.forward * Time.deltaTime) * 100.0f);

        if(Vector3.Distance(transform.position, Camera.main.transform.position) >= 60.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "AI" || other.tag == "Obstacle")
        {
            if(other.tag == "AI")
            {
                Destroy(other.gameObject);
            }

            Destroy(gameObject);
        }
    }
}
