using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GravityControllerTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void GravityForceIsZeroWithNoMass()
    {

        GameObject moonGameObject = new GameObject("Moon");
        moonGameObject.transform.position += new Vector3(0f, 5f, 0f);
        GameObject earthGameObject = new GameObject("Earth");
        PlanetProperties moon = moonGameObject.AddComponent<PlanetProperties>();
        PlanetProperties earth = earthGameObject.AddComponent<PlanetProperties>();

        GravityLogic gravityLogic = new GravityLogic();
        Vector3 result = gravityLogic.CalculateForceVector(moon, earth);
        Assert.AreEqual(result.x, 0.0f);
    }

    [Test]
    public void GravityForceIsLittleGWith1KgMass()
    {

        GameObject moonGameObject = new GameObject("TestWeight");
        moonGameObject.transform.position += new Vector3(0f, 6371000f, 0f);
        GameObject earthGameObject = new GameObject("Earth");
        PlanetProperties moon = moonGameObject.AddComponent<PlanetProperties>();
        moon.mass = 1;
        PlanetProperties earth = earthGameObject.AddComponent<PlanetProperties>();
        earth.mass = 5.972f * (float)Math.Pow(10f, 24f);

        GravityLogic gravityLogic = new GravityLogic();
        Vector3 result = gravityLogic.CalculateForceVector(moon, earth);
        Assert.AreEqual(0.0f, result.x);
        Assert.AreEqual(9.8196497f, result.y);
        Assert.AreEqual(0.0f, result.z);
    }

        [Test]
    public void GravityForceHasMultidimensionalComponents()
    {

        GameObject moonGameObject = new GameObject("TestWeight");
        moonGameObject.transform.position += new Vector3(1f, 1f, 0f);
        GameObject earthGameObject = new GameObject("Earth");
        PlanetProperties moon = moonGameObject.AddComponent<PlanetProperties>();
        moon.mass = 1;
        PlanetProperties earth = earthGameObject.AddComponent<PlanetProperties>();
        earth.mass = 1;

        GravityLogic gravityLogic = new GravityLogic();
        Vector3 result = gravityLogic.CalculateForceVector(moon, earth);
        Assert.AreEqual(0.0f, result.z );
        Assert.AreEqual(2.35964356E-11f, result.x);
        Assert.AreEqual(2.35964356E-11f, result.y);
    }


    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
