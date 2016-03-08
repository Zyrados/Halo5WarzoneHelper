using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public GameObject ToolManager;
    public GameObject StartButton;
    public GameObject BackButton;

    public void OnClickStart()
    {
        ToolManager.SetActive(true);
        StartButton.SetActive(false);
        BackButton.SetActive(false);
        
    }

    public void OnClickExit()
    {
        Debug.Log("Click on Exit");
        Application.LoadLevel("MainMenu");
    }

    public void Update()
    {
        if (ToolManager == null && StartButton == null)
        {
            Debug.Log("Credits or Instruction");
        }
    }
    
}
