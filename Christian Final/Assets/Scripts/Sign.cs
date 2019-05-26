using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;
    public string response;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {    // If player is in range and inputting space
            if (dialogBox.activeInHierarchy)
            {    // If dialog box is on screen
                if (dialogText.text != response)
                {    // If dialogBox.text is not the response text
                    dialogText.text = response;
                }
                else
                {    // dialogBox.text is response text
                    dialogBox.SetActive(false);
                }
            }
            else
            { // Dialog box was not on screen, so activate it
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }

    private     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);

        }
    }
}
