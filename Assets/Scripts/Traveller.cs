using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Traveller : MonoBehaviour
{
    // Start is called before the first frame update
    public string Destination
    {
        get;
        set;
    } = "";

    void Start()
    {
#if UNITY_EDITOR
        DestroySelfIfNotOriginal();
#endif
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoadAction;
    }

    private void OnSceneLoadAction(Scene scene, LoadSceneMode loadMode)
    {
        if (Destination != "")
        {
            SpawnPoint[] spawnPoints = GameObject.FindObjectsOfType<SpawnPoint>();
            foreach (SpawnPoint spawn in spawnPoints)
            {
                if (spawn.name == Destination)
                {
                    transform.position = spawn.transform.position;
                }
            }
        }
    }

    private void DestroySelfIfNotOriginal()
    {
        if(SpawnPoint.Player != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
