using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
RaycastHit hit;
public GameObject bullet;
float Counter;
public Transform pistol;
public float ratOfShoot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Counter +=Time.deltaTime;
        Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity);
                
        Vector3 direction =Camera.main.transform.TransformDirection(Vector3.forward);
        Quaternion hitRotaion = Quaternion.FromToRotation(Vector3.up,hit.normal);

    if(Input.GetKey(KeyCode.Mouse0)&& Counter>=ratOfShoot) {
        Instantiate(bullet,pistol.position,hitRotaion).GetComponent<Rigidbody>().AddForceAtPosition
        (direction*3500,hit.point);
        Counter=0f;
    }

    }
}
