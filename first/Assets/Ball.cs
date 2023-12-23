using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float startingPoint;
    bool shouldPrintOver20 = true;
    bool shouldPrintOver30 = true;
    // Start is called before the first frame update
    void Start()
    {
    
        Rigidbody myRigidBody = GetComponent<Rigidbody>();
        Debug.Log("UseGravity?" + myRigidBody.useGravity);
        Debug.Log("start");
        startingPoint = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float distance;
        distance = transform.position.z - startingPoint;

        if(Input.GetKeyDown(KeyCode.Space))
            //Input.GetKeyDown 누르는 순간
            //Input.GetKeyUp 떼는 순간
            //Input.GetKey 누르는 동안
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }


    }

    void TestMethod()
    {
        Debug.Log("This is TestMethod");
    }
}
