using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class WinningCode : MonoBehaviour, ICustomMessageTarget
{
    // Start is called before the first frame update

    public UnityEvent myEvent;

    void Start()
    {
        myEvent.AddListener(WeWon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WeWon()
    {
        Text text = this.gameObject.GetComponent<Text>();
        text.enabled = true;
        Debug.Log ("We Won called from listener");
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
