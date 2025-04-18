using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSettings : MonoBehaviour
{
    public int play_index = 0;
    public int home_index = 1;
    
    public void PlayButton()
    {
        Time.timeScale = 1f;
        Debug.Log("PLAY BUTTON CLICKED...!");
        SceneManager.LoadScene(play_index);
    }

    public void HomeButton()
    {
        Time.timeScale = 1f;
        Debug.Log("HOME BUTTON CLICKED...!");
        SceneManager.LoadScene(home_index);
    }
}