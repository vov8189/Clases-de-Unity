using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpdate : MonoBehaviour
{
    [SerializeField] GameObject character;

    void Update()
    {
        transform.position = character.transform.position;
    }
}
