using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform playerRotation;
    [SerializeField]
    private Transform instantiateFrom;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (gameObject.tag == "AI")
            {
                var bullet = Instantiate(bulletPrefab, instantiateFrom.position, Quaternion.Euler(playerRotation.eulerAngles - new Vector3(0.0f, 90.0f, 0.0f)));
                bullet.GetComponent<Bullet>().referenceObject = gameObject.transform;
            }
            else
            {
                var bullet = Instantiate(bulletPrefab, instantiateFrom.position, Quaternion.Euler(playerRotation.eulerAngles));
                bullet.GetComponent<Bullet>().referenceObject = gameObject.transform;
            }
        }
    }
}
