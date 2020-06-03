using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject ResultUI;
    private GameObject Stone;
    public GameObject controller;
    public Text shootNumber;
    public Text shootBingoNumber;


    public void Start()
    {
        controller.GetComponent<ActionController>().enabled = true;
        controller = GameObject.FindGameObjectWithTag("GameController");
    }

    private void Update()
    {
        if (Data.DestroyNumber == Data.Number)
        {
            controller.GetComponent<ActionController>().enabled = false;
            ResultUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            shootNumber.text = Data.ShootNumber.ToString();
            shootBingoNumber.text = Data.ShootBingoNumber.ToString();
        }
        else
        {
            controller.GetComponent<ActionController>().enabled = true;
            ResultUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }


}
