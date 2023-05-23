using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Check : MonoBehaviour
{
    public PlayableDirector pd;
    public BoxCollider2D boxCollider;
    void Start()
    {
        boxCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pd.state==PlayState.Paused)
        {
            boxCollider.isTrigger = true;
        }
    }
}
