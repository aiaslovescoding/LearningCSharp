using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVariables : MonoBehaviour
{
    // Start is called before the first frame update
    int playerHealth = 100;
    const int playerReceivedDamage = 10;
    float playerVelocity = 14.74f;
    const float planetGravity = 7.44f;
    string welcomeMessage = "Welcome to this Great Game. ";
    const string gameStartMessage = "Please, Click to Start";
    bool isGameStarted = true;
    public float characterPositionX;
    private const int characterJumpForce = 15;
    void Start()
    {
        // Debug.Log("Intitial health: " + playerHealth);
        // Debug.Log("Received Damage: " + playerReceivedDamage);
        // Debug.Log("Player Velocity: " + playerVelocity);
        // Debug.Log("Planet Gravity: " + planetGravity);
        // Debug.Log(welcomeMessage + gameStartMessage);
        // Debug.Log("Game Started: " + isGameStarted);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
