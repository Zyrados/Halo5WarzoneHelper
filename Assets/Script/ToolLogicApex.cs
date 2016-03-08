using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;


public class ToolLogicApex : MonoBehaviour {

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
        if (time >= Boss1 - TimeReminder) //Hunter Spire
        {
            Activator(Spots[4], "Hunters");          

            if (time >= Boss1 + DeactivationTimer)
            {
                Deactivator(Spots[4]);
            }
        }

        if (time >= Boss2 - TimeReminder) //Zealot Assassin Passage/ Caves
        {
            Activator(Spots[0], "Zealot Assassins");
            Activator(Spots[2], "Zealot Assassins");
            
            if (time >= Boss2 + DeactivationTimer)
            {
                Deactivator(Spots[0]);
                Deactivator(Spots[2]);
            }
        }

        if (time >= Boss3 - TimeReminder) //Elite Ultras Crags / Plateau
        {
            Activator(Spots[7], "Elite Ultras");
            Activator(Spots[8], "Elite Ultras");           

            if (time >= Boss3 + DeactivationTimer)
            {
                Deactivator(Spots[7]);
                Deactivator(Spots[8]);                
            }
        }

        if (time >= Boss4 - TimeReminder) //Ghost Marauder Ridge / Waterfront
        {
            Activator(Spots[3], "Ghost Marauders");
            Activator(Spots[6], "Ghost Marauders");           

            if (time >= Boss4 + DeactivationTimer)
            {
                Deactivator(Spots[3]);
                Deactivator(Spots[6]);                
            }
        }

        if (time >= Boss5 - TimeReminder) //Beach
        {
            Activator(Spots[1], "Tankmaster Rok (Wraith)");
            
            if (time >= Boss5 + DeactivationTimer)
            {
                Deactivator(Spots[1]);                
            }
        }

        if (time >= Boss6 - TimeReminder) //Banshee Ridge / Waterfront
        {
            Activator(Spots[3], "Banshee");
            Activator(Spots[6], "Banshee");

            if (time >= Boss6 + DeactivationTimer)
            {
                Deactivator(Spots[3]);
                Deactivator(Spots[6]);                
            }
        }

        if (time >= Boss7 - TimeReminder) //Hestro Beach
        {
            Activator(Spots[1], "Captain Hestro (Phaeton)");
            
            if (time >= Boss7 + DeactivationTimer)
            {
                Deactivator(Spots[1]);
            }
        }

        if (time >= Boss8 - TimeReminder) //Solider Tunnel, Chasm
        {
            Activator(Spots[9], "Soldiers");
            Activator(Spots[5], "Soldiers");
            
            if (time >= Boss8 + DeactivationTimer)
            {
                Deactivator(Spots[9]);
                Deactivator(Spots[5]);
            }
        }

        if (time >= Boss9 - TimeReminder) //Knight Champion Crossroad
            
            Activator(Spots[10], "Knight Champion");
       
            if (time >= Boss9 + DeactivationTimer)
            {
                Deactivator(Spots[10]);                
            }
        

        if (time >= Boss10 - TimeReminder) //Ewiger Wärter Crossroad
        {
            Activator(Spots[10], "Warden Eternal ");

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
