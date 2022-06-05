using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotationVelocity = 0;
    public float rotation = 0;

    public float force = 0.001f;

    public float rotationAcceleration = 10;

    public float time = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem rocketEngine = GetComponentInChildren<ParticleSystem>();
        
        GameObject body = this.gameObject;

        TrailRenderer trailTime = GetComponent<TrailRenderer>();

        GravityController gravityBrain = GetComponentInParent<GravityController>();

        BoxCollider2D colision = GetComponent<BoxCollider2D>();

        PlanetProperties planetProperties = GetComponent<PlanetProperties>();

        trailTime.time = time / gravityBrain.timeScale;




        if (Input.GetKey("a"))
        {
            accelerateRotationally(rotationAcceleration);
        }
        if (Input.GetKey("d"))
        {
            accelerateRotationally(-rotationAcceleration);
        }
        if (Input.GetKey("w"))
        {
            var emmision = rocketEngine.emission;
            emmision.enabled = true;
            accelerate(force*Time.deltaTime, rotation*Mathf.PI/180);
        }
        else 
        {
            var emmision = rocketEngine.emission;
            emmision.enabled = false;
        }
        if (rotationVelocity > 0 && ! Input.GetKey("a") || Input.GetKey("d"))
        {
            accelerateRotationally(-rotationAcceleration);
        }
        if (rotationVelocity < 0 && ! Input.GetKey("a") || Input.GetKey("d"))
        {
            accelerateRotationally(rotationAcceleration);
        }
        rotation = rotation + rotationVelocity * Time.deltaTime;
        body.transform.rotation = Quaternion.Euler (Vector3.forward * rotation);
    }
    void accelerateRotationally(float amount)
    {
        GravityController gravityBrain = GetComponentInParent<GravityController>();
        rotationVelocity = rotationVelocity + amount * Time.deltaTime * gravityBrain.timeScale;
    }
    void accelerate(float acceleration, float direction)
    {
        GravityController gravityBrain = GetComponentInParent<GravityController>();
        PlanetProperties gravity = GetComponent<PlanetProperties>();
        gravity.velocity = gravity.velocity + (new Vector3(Mathf.Cos(direction)*acceleration,Mathf.Sin(direction)*acceleration, 0)/gravity.mass) * gravityBrain.timeScale;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Respawn")
        {
        PlanetProperties planetProperties = GetComponent<PlanetProperties>();
        this.transform.position = new Vector3 (0, 2, 0);
        planetProperties.velocity = new Vector3 (0.5777f, 0, 0);
        }
    }
}