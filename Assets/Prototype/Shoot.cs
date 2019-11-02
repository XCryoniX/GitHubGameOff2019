using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform playerRotation;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletPrefab, Camera.main.transform.position, Quaternion.Euler(playerRotation.eulerAngles));

            Debug.Log("Bullet rotation: " + bullet.transform.eulerAngles + ", player rotation: " + playerRotation.eulerAngles);
        }
    }
}
