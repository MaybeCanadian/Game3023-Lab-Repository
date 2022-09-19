using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    [SerializeField]
    private string destination = "";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //we check if this is a traveller

        Traveller traveller = collision.GetComponent<Traveller>();

        if(traveller != null)
        {
            traveller.Destination = destination;
            SceneManager.LoadScene(gameObject.tag, LoadSceneMode.Single);
        }
    }

}
