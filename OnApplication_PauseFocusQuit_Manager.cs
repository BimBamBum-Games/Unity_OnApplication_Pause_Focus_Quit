using UnityEngine;

public class OnApplication_PauseFocusQuit_Manager : MonoBehaviour
{
    //For all situations, you must save the user data to take quarantee.
    void Start()
    {
        Debug.LogWarning("System Awaken");
    }

    private void OnApplicationFocus(bool focus)
    {
        //This will work in all situations. (Before quitting)
        Debug.LogWarning("OnApplicationFocus >>>>> " + focus);
        SaveUserData();
    }

    private void OnApplicationPause(bool pause)
    {
        //This will work in all situations. (Before quitting)
        Debug.LogWarning("OnApplicationPause >>>>> " + pause);
        SaveUserData();
    }

    private void OnApplicationQuit()
    {
        //This will work if user wants to quit game using in app quit system.
        //If user wants to quit with brute / hard way then kernel will kill the program and this method will never run.
        Debug.LogWarning("OnApplicationQuit Has Executed!");
        SaveUserData();
    }

    public void QuitApplication()
    {
        //Assign it to Button Delegate. This is soft quitting method.
        Debug.LogWarning("Quit will running!");
        Application.Quit();
    }

    public void SaveUserData()
    {
        //Fake User Data Save Method
        Debug.LogWarning("User Data Saved!");
    }
}
