using System;
using UnityEngine;
using System.Linq;

public class GravityLogic
{
    public double bigG = 6.67408e-11;

    public Vector3 CalculateTotalForce(GameObject[] otherPlanets, GameObject currentBody)
    {
        Vector3 totalForce = new Vector3();
        PlanetProperties currentPlanetProperties = currentBody.GetComponent<PlanetProperties>();

        foreach (GameObject otherBody in otherPlanets)
        {
            PlanetProperties otherPlanetProperties = otherBody.GetComponent<PlanetProperties>();
            totalForce += CalculateForceVector(currentPlanetProperties, otherPlanetProperties);
        }
        return totalForce;
    }

    public Vector3 CalculateForceVector(PlanetProperties currentBody, PlanetProperties otherBody)
    {
        Vector3 diffInPos = currentBody.transform.position - otherBody.transform.position;
        float x = CalculateGravityForce(diffInPos.x, currentBody.mass, otherBody.mass, diffInPos);
        float y = CalculateGravityForce(diffInPos.y, currentBody.mass, otherBody.mass, diffInPos);
        float z = CalculateGravityForce(diffInPos.z, currentBody.mass, otherBody.mass, diffInPos);

        return new Vector3(x, y, z);

    }
    public GameObject[] FindOtherPlanets(GameObject[] bodies, GameObject currentBody)
    {
        return bodies.Where(body => body != currentBody).ToArray(); ;
    }
    // private double distance(Vector3 positions)
    // {
    //     return Math.Pow((Math.Pow(positions.x, 2) + Math.Pow(positions.y, 2) + Math.Pow(positions.z, 2)), 0.5);
    // }
    public float CalculateGravityForce(float weirdG, float m1, float m2, Vector3 diffInPos)
    {
        float x = diffInPos.x;
        float y = diffInPos.y;
        float z = diffInPos.z;
        return (float) (0 - (weirdG * bigG * m1 * m2 / Math.Pow((Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)), 1.5)));
    }
}
