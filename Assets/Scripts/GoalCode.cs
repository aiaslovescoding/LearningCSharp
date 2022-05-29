using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class GoalCode : MonoBehaviour
{
    public UnityEvent myEvent;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("test1");
        // ExecuteEvents.ExecuteHierarchy<ICustomMessageTarget>(this.gameObject, null, (x,y)=>x.Message1());
        // Debug.Log("test2");

        Debug.Log("Before Invoke");
        
        Debug.Log("After Invoke");
    }

    // Update is called once per frame

    void Update()
    {   
        if (timer >= 10)
        {
            myEvent.Invoke();
        }
    }
    void OnTriggerStay2D (Collider2D targetObj)
    {
        if(targetObj.gameObject.tag == "Player")
        {
            Debug.Log(timer);
           timer = timer + Time.deltaTime;
        }
    }
    void OnTriggerExit2D (Collider2D targetObj)
    {
        if(targetObj.gameObject.tag == "Player")
        {
           timer = 0;
        }
    }
}

