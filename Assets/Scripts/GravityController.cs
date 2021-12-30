using System;
using UnityEngine;
using System.Linq;

public class GravityController : MonoBehaviour
{
    public GameObject[] bodies;
    public GameObject bodies2;

    public float timeScale = 1f;


    // Start is called before the first frame update
    void Start()
    {
        // otherScript = gameObjectToAccess.GetComponent<ScriptToAccess>();
        //PlanetProperties planet = bodies[1].GetComponent<PlanetProperties>();
        // Debug.Log(planet.mass);
        // planet.transform.position = new Vector3(0f,0f,0f);
        // Debug.Log(planet.transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        
        GravityLogic gl = new GravityLogic();
        // foreach (GameObject body in bodies)
        foreach (Transform childTransform in bodies2.transform)
        {
            GameObject body = childTransform.gameObject;
            PlanetProperties planet = body.GetComponent<PlanetProperties>();
            // Debug.Log(planet.mass);
            // planet.transform.position = new Vector3(0f,0f,0f);
            // Debug.Log(planet.transform.position.x);
            GameObject[] otherPlanets = gl.FindOtherPlanets(bodies, body);
            Vector3 totalForce = gl.CalculateTotalForce(otherPlanets, body);
            Vector3 acceleration = totalForce/planet.mass;
            planet.velocity += acceleration * timeScale * Time.deltaTime;
            planet.transform.position += planet.velocity * timeScale * Time.deltaTime;
            Debug.Log(otherPlanets);
            Debug.Log(body);
            Debug.Log(totalForce);


        }
    }
}
