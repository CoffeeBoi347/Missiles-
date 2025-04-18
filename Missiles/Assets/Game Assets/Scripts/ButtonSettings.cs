using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSettings : MonoBehaviour
{
    public int play_index = 0;
    
    public void PlayButton()
    {
        Time.timeScale = 1f;
        Debug.Log("PLAY BUTTON CLICKED...!");
        SceneManager.LoadScene(play_index);
    }

    public void HomeButton()
    {
        Debug.Log("HOME BUTTON CLICKED...!");
    }
}