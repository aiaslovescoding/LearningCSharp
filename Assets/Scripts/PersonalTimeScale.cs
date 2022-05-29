using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTimeScale : MonoBehaviour
{
    // Start is called before the first frame update
    public float myTimeScale = 1;
    Vector3 previousVelocity = new Vector3(0,0,0);
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlanetProperties planetProperties = GetComponent<PlanetProperties>();
        this.transform.position = (planetProperties.velocity * (myTimeScale - 1) * Time.deltaTime) + this.transform.position;
        planetProperties.velocity = (planetProperties.velocity - previousVelocity) * (myTimeScale - 1) + planetProperties.velocity;
        previousVelocity = planetProperties.velocity;
    }
}
