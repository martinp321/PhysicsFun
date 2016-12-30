using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

    public Vector3 velocityVector; // Average velocity this FixedUpdate()

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {

        transform.position += velocityVector * Time.deltaTime;
    }
}
