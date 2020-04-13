using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private bool enterTrigger = false;
    private bool signOpened = false;
    [SerializeField] private GameObject tutorialSign; // Sign object

    private void Update()
    {

        if (enterTrigger == true && Input.GetKeyDown(KeyCode.R) && signOpened == false)
        {
            tutorialSign.SetActive(true);
            Time.timeScale = 0;
            signOpened = true;
        }
        else if (Input.GetKeyDown(KeyCode.R) && signOpened == true)
        {
            tutorialSign.SetActive(false);
            Time.timeScale = 1;
            signOpened = false;
        }

       // if (Input.GetKeyDown(KeyCode.Mouse0))
       // {
        //    tutorialSign.SetActive(false);
       //     Time.timeScale = 1;
       //     signOpened = false;
       // }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Rigidbody2D triggeredObject = collision.GetComponent<Rigidbody2D>(); // Get the rigidbody of the object that collided with this object.
        Animator anim = this.GetComponentInChildren<Animator>(); //Get the animator in the child of the object this script is on.
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player triggered sign!");
            anim.SetBool("onEnter", true); // turn on the animation for the button
            enterTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Animator anim = this.GetComponentInChildren<Animator>(); //Get the animator in the child of the object this script is on.
        Debug.Log("Player left the boundaries of the sign!");
        anim.SetBool("onEnter", false); // turn on the animation for the button
        enterTrigger = false;
    }
}
