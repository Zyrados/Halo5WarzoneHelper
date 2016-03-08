using UnityEngine;
using System.Collections;

public class MainMenuButtons : MonoBehaviour {

	public void OnClickEscape()
    {
        Application.LoadLevel(1);
    }

    public void OnClickMarch()
    {
        Application.LoadLevel(2);
    }

    public void OnClickRaid()
    {
        Application.LoadLevel(3);
    }

    public void OnClickInstructions()
    {
        Application.LoadLevel(4);
    }

    public void OnClickCredits()
    {
        Application.LoadLevel(5);
    }

    public void OnClickDonation()
    {
        Application.OpenURL("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=JDKWAX7KK8FGC");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
