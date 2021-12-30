using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity1 : MonoBehaviour
{
     Vector3 position;
     Vector3 movement;
     Vector3 value;
     float distanceFromGravityObject2;
    float gravity = -1f;
    Vector3 gravityObject2Position;
        public float distanceFromObject2;
    // Start is called before the first frame update
    void Start()
    {

        movement = new Vector3(0f, 5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        // gravityObject2Position = GravityObject2.GameObject.GetComponent<Transform>();
        // transform.position = transform.position + movement * Time.deltaTime;
        // movement = movement + new Vector3 (0f, PerSecond(gravity), 0f);

    }
    private float PerSecond(float something)
    {
        return something*Time.deltaTime;
    }
}
