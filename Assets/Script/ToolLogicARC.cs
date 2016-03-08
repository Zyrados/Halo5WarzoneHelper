using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ToolLogicARC : MonoBehaviour {

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
        EnemyLabel.text = "-";

        if (time >= Boss1 - TimeReminder) //Elite General Com / Relay
        {
            Activator(Spots[0], "Sangheili General");
            Activator(Spots[1], "Sangheili General");
                     
            if (time >= Boss1 + DeactivationTimer)
            {
                Deactivator(Spots[0]);
                Deactivator(Spots[1]);
            }
        }

        if (time >= Boss2 - TimeReminder) //Ranger Dig Site / Mineshaft
        {
            Activator(Spots[2], "Ranger Commander");
            Activator(Spots[3], "Ranger Commander");
            
            if (time >= Boss2 + DeactivationTimer)
            {
                Deactivator(Spots[2]);
                Deactivator(Spots[3]);
            }
        }

        if (time >= Boss3 - TimeReminder) //Soldier Grotto / Loading Dock
        {
            Activator(Spots[4], "Soldier Enforcer");
            Activator(Spots[5], "Soldier Enforcer");
           
            if (time >= Boss3 + DeactivationTimer)
            {
                Deactivator(Spots[4]);
                Deactivator(Spots[5]);
            }
        }

        if (time >= Boss4 - TimeReminder) //Banshee Yard
        {
            Activator(Spots[6], "Baron 'Sraom (Banshee)");
                       
            if (time >= Boss4 + DeactivationTimer)
            {
                Deactivator(Spots[6]);
            }
        }

        if (time >= Boss5 - TimeReminder) //Springer Dig Site / Mineshaft
        {
            Activator(Spots[2], "Knight Marshal");
            Activator(Spots[3], "Knight Marshal");
           
            if (time >= Boss5 + DeactivationTimer)
            {
                Deactivator(Spots[2]);
                Deactivator(Spots[3]);
            }
        }

        if (time >= Boss6 - TimeReminder) //Ghost Com / Relay
        {
            Activator(Spots[0], "Patrol Leader (Ghost)");
            Activator(Spots[1], "Patrol Leader (Ghost)");
           
            if (time >= Boss6 + DeactivationTimer)
            {
                Deactivator(Spots[0]);
                Deactivator(Spots[1]);
            }
        }

        if (time >= Boss7 - TimeReminder) //Springer Strategos Yard
        {
            Activator(Spots[6], "Knight Strategos");
                     
            if (time >= Boss7 + DeactivationTimer)
            {
                Deactivator(Spots[6]);
            }
        }

        if (time >= Boss8 - TimeReminder) //Hunter Dig Site / Mineshaft
        {
            Activator(Spots[2], "Hunters");
            Activator(Spots[3], "Hunters");
           
            if (time >= Boss8 + DeactivationTimer)
            {
                Deactivator(Spots[2]);
                Deactivator(Spots[3]);
            }
        }

        if (time >= Boss9 - TimeReminder) //Springer Würdenträger Grotto / Loading Dock
        {
            Activator(Spots[4], "Knight Dignitary");
            Activator(Spots[5], "Knight Dignitary");

            if (time >= Boss9 + DeactivationTimer)
            {
                Deactivator(Spots[4]);
                Deactivator(Spots[5]);
            }
        }

        if (time >= Boss10 - TimeReminder) //Ewiger Wärter Yard
        {
            Activator(Spots[6], "Warden Eternal");
           
            if (time >= Boss10 + DeactivationTimer)
            {
                Deactivator(Spots[10]);
            }
        }
    }

   
    void OnClickBack()
    {
        Application.LoadLevel(1);
    }
}
