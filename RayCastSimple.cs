using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastSimple : MonoBehaviour
{
    [SerializeField] float size = 10;
    [SerializeField] GameObject Player;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, size))
            {
                //Debug.Log(hit.point);
                Player.GetComponent<Player>().pToGo = hit.point;
                Player.transform.LookAt(hit.point);
            }
        }
        
    }
}
