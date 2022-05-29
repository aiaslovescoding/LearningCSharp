using System;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;
public class GravityController : MonoBehaviour, ICustomMessageTarget
{
    public bool won = false;
    GoalCode goalCode;

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
        }
        if (Input.GetKeyDown("e") & timeScale < 10)
        {
             timeScale += 1;
        }
        if (Input.GetKeyDown("q") & timeScale > 1)
        {
            timeScale += -1;
        }
    }
        public void Message1()
    {
        Debug.Log ("Message 1 received");
    }
    public void Message2()
    {
        Debug.Log ("Message 2 received");
    }
}