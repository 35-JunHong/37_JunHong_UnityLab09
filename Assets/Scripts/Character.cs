using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;

    public GameObject Text;

    public float PositionX;
    public float PositionY;
    public float PositionZ;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PositionX = gameObject.transform.position.x;
        PositionY = gameObject.transform.position.y;
        PositionZ = gameObject.transform.position.z;

        //forward && forward moving
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0, 0, Time.deltaTime * speed);
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        //backward
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position -= new Vector3(-0, -0, Time.deltaTime * speed);
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        //right turning
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed, 0));
        }

        //left turning
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotateSpeed, 0));
        }

        //display position
        Text.GetComponent<Text>().text = "Position: ( " + PositionX + ", " + PositionY + ", " + PositionZ + " )";
    }
}
