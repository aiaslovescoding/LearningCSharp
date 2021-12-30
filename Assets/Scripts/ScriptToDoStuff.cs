using UnityEngine;

public class ScriptToDoStuff : MonoBehaviour
{
    public GameObject gameObjectToAccess;
    public GameObject [] gameObjects;

    private ScriptToAccess otherScript;
    private void Start()
    {
        otherScript = gameObjectToAccess.GetComponent<ScriptToAccess>();
    }
    private void Update()
    {
        // otherScript.testData = true;
        // Debug.Log("STDS" + otherScript.alive);
    }
}