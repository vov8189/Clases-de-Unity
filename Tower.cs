using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] LineRenderer rayo;
    public bool isShooting = false;
    [SerializeField] GameObject player;
    float distanceToPlayer;
    public float towerradius = 4;

    void rayDirection(Vector3 playerPos)
    {
        rayo.SetPosition(0, playerPos);
    }
    void rayReset()
    {
        rayo.SetPosition(0, Vector3.zero); //new Vector3(0,0,0) = Vector3.zero
    }
    private void Update()
    {
        distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);
        if(distanceToPlayer <= towerradius)
        {
            isShooting = true;
        }
        else
        {
            isShooting = false;
        }
        if(isShooting)
        {
            
            Vector3 temp = player.transform.position;
            temp.x = temp.x * -1;
            temp.y = temp.y * -1;
            rayDirection(temp);
        }
        else
        {
            rayReset();
        }
    }
}
