using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicOperations : MonoBehaviour
{
    public int firstValue;
    public int secondValue = 10;
    int operationResult;
    // Start is called before the first frame update
    void Start()
    {
        operationResult = firstValue + secondValue;
        
        // Debug.Log("Addition Operation Result = " + operationResult);

        operationResult = firstValue - secondValue;

        // Debug.Log("Subtraction Operation Result = " + operationResult);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
