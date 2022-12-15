using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmBrain : MonoBehaviour
{
    //While it has the hive, patrol around the hive
    //When no hive, pursue the player

    private bool hasHive = true;
    private Patrolling patrolling;
    private Bot bot;

    // Start is called before the first frame update
    void Start()
    {
        patrolling = GetComponent<Patrolling>();
        bot = GetComponent<Bot>();
        HivePickUp.HivePickedUp += HiveTaken;
    }

    void HiveTaken()
    {
        hasHive = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(hasHive)
        {
            patrolling.PatrolWaypoints();
        }
        else
        {
            bot.Pursue();
        }
    }
}
