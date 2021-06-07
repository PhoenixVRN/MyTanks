using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireIsGun : MonoBehaviour
{
    public GameObject ammo;
    public Transform shutDir;

    private float timeShot;
    public float startTime;
  
    void Start()
    {
        
    }


    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);


        if (timeShot <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(ammo, shutDir.position, transform.rotation);
                timeShot = startTime;
//                Debug.Log(timeShot);
            }
        }
        else
        {
            timeShot -= Time.deltaTime;
//            Debug.Log(timeShot + "   " + Time.deltaTime);
        }
    }
}
