using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface ICustomMessageTarget : IEventSystemHandler
{
    // functions that can be called via the messaging system
    public void Message1();
    public void Message2();
}
