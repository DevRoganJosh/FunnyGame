using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
public class NewScene : MonoBehaviour
{
    public PlayableDirector pd2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Invoke("LoadScene", 2f);
            pd2.Play();
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
