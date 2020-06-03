using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
  
    private GameObject audioPlay;
    private void Start()
    {
        audioPlay = GameObject.FindGameObjectWithTag("GameController");
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject game = GameObject.FindGameObjectWithTag("Mark");

        if (other.tag == "Shoot")
        {
            Destroy(this.gameObject);
            audioPlay.GetComponent<ActionController>().myMusic2.Play();
            Data.DestroyNumber += 1;
            Data.ShootBingoNumber += 1;
        }
        if (other.tag == "Finish")
        {
            Destroy(this.gameObject);
            Data.DestroyNumber += 1;
        }
    }
}
