using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // these variables will be used to change the speed of the player



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        setUpMovement();
    }

    void setUpMovement()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        Vector3 movementVector = new Vector3(xValue, 0, zValue);
        transform.Translate(movementVector, Space.Self);
    }
}
