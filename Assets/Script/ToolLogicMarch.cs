using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ToolLogicMarch : MonoBehaviour {

    public GameObject[] Spots;

    public Text EnemyLabel;
    public Text ShowTime;
    public float DeactivationTimer;
    public float TimeReminder;
    public GameObject BackButton;

    public float Boss1;
    public float Boss2;
    public float Boss3;
    public float Boss4;
    public float Boss5;
    public float Boss6;
    public float Boss7;
    public float Boss8;
    public float Boss9;
    public float Boss10;

    float time;

    void Start ()
    {
        foreach (GameObject Spot in Spots)
        {
            Spot.SetActive(false);
        }
        Screen.sleepTimeout = (int)SleepTimeout.NeverSleep;
    }	
	
	void Update () {
        BackButton.SetActive(true);
        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        time += Time.deltaTime;
        Activation();
        ShowTime.text = niceTime;
    }

    private void Activator(GameObject Spot, String Name)
    {
        Spot.SetActive(true);
        EnemyLabel.text = Name;
    }

    private void Deactivator(GameObject Spot)
    {
        Spot.SetActive(false);
        EnemyLabel.text = "-";
    }

    private void Activation()
    {
        if(time >= Boss1 - TimeReminder) //Commander Lochagos Fortress
        {
            Activator(Spots[3], "Commander Lochagos");            

            if (time >= Boss1 + DeactivationTimer)
            {
                Deactivator(Spots[3]);
            }
        }

        if (time >= Boss2 - TimeReminder) //Elite General Transport Bay / Shipping Bay
        {
            Activator(Spots[0], "Elite General");
            Activator(Spots[1], "Elite General");
           
            if (time >= Boss2 + DeactivationTimer)
            {
                Deactivator(Spots[0]);
                Deactivator(Spots[1]);
            }
        }

        if (time >= Boss3 - TimeReminder) //Covert Major Outpost
        {
            Activator(Spots[2], "Covert Major");

            if (time >= Boss3 + DeactivationTimer)
            {
                Deactivator(Spots[2]);
            }
        }

        if (time >= Boss4 - TimeReminder) //Knight Luminary Frozen Cave / Ice Cavern
        {
            Activator(Spots[5], "Knight Luminary");
            Activator(Spots[4], "Knight Luminary");

            if (time >= Boss4 + DeactivationTimer)
            {
                Deactivator(Spots[5]);
                Deactivator(Spots[4]);
            }
        }

        if (time >= Boss5 - TimeReminder) //Captain Wamik Cargo Dock
        {
            Activator(Spots[6], "Captain Wamik (Banshee)");

            if (time >= Boss5 + DeactivationTimer)
            {
                Deactivator(Spots[6]); 
            }
        }

        if (time >= Boss6 - TimeReminder) //Soldier Commando Transport Bay  / Shipping Bay
        {
            Activator(Spots[1], "Soldier Commando");
            Activator(Spots[0], "Soldier Commando");
            if (time >= Boss6 + DeactivationTimer)
            {
                Deactivator(Spots[0]);
                Deactivator(Spots[1]);
            }
        }

        if (time >= Boss7 - TimeReminder) // Knight Bannerman Cargodock
        {
            Activator(Spots[6], "Knight Bannerman");
            if (time >= Boss7 + DeactivationTimer)
            {
                Deactivator(Spots[6]);
            }
        }

        if (time >= Boss8 - TimeReminder) //Serpent Hunter Transpiort Bay / Shpping Bay
        {
            Activator(Spots[0], "Hunters");
            Activator(Spots[1], "Hunters");
            
            if (time >= Boss8 + DeactivationTimer)
            {
                Deactivator(Spots[0]);
                Deactivator(Spots[1]);
            }
        }

        if (time >= Boss9 - TimeReminder) //Wraith Officer Cargo Dock
        {
            Activator(Spots[6], "Wraith Officer");

            if (time >= Boss9 + DeactivationTimer)
            {
                Deactivator(Spots[6]);
            }
        }

        if (time >= Boss10 - TimeReminder) //Ewiger Wärter Outpost
        {
            Activator(Spots[2], "Warden Eternal");
            if (time >= Boss10 + DeactivationTimer)
            {
                Deactivator(Spots[2]);
                
            }
        }
    }

    void OnClickBack()
    {
        Application.LoadLevel(1);
    }
}
