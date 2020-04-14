using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNote : MonoBehaviour
{
    [SerializeField] private GameObject startMessage;
    private bool messageVisible = false;

    // Start is called before the first frame update
    void Start()
    {
        startMessage.SetActive(true);
        Time.timeScale = 0;
        messageVisible = true;
    }

    private void Update()
    {
        if (messageVisible == true)
            if (Input.GetKeyDown(KeyCode.R))
            {
                startMessage.SetActive(false);
                Time.timeScale = 1;
            }
    }

}
