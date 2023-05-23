using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class IsTrigger1 : MonoBehaviour
{
    public PlayableDirector pdr;
    BoxCollider2D bd;
    void Start()
    {
        bd = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (pdr.state == PlayState.Paused)
        {
            bd.isTrigger = false;
        }
        else
        {
            bd.isTrigger = true;
        }
    }
}
