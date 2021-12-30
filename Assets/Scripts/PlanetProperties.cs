using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetProperties : MonoBehaviour
{
    // Start is called before the first frame update
    public float mass;
    public string title;
    public Vector3 velocity;

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = velocity.magnitude;
    }
}
