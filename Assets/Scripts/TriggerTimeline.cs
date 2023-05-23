using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour
{
    public Animator anim;
    int counter = 0;
    public PlayableDirector pdr;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (counter == 0)
        {
            anim.SetBool("IsRunning", false);
            pdr.Play();
            counter++;
        }
    }
}
