using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreen  : MonoBehaviour
{
    public List<CanvasGroup> panels = new List<CanvasGroup>();
    public int main_game_index;
    public Animator circleFadeInAnimator;
    public AnimationClip circleClip;
    public GameObject blackFadeObj;
    public void PlayButton()
    {
        blackFadeObj.SetActive(true);
        circleFadeInAnimator.Play(circleClip.name);
        StartCoroutine(OpenGameScene(circleClip.length)); 
    }

    public void OpenPanels(CanvasGroup currentPanel)
    {
        foreach(CanvasGroup panel in panels)
        {
            if(panel == currentPanel)
            {
                panel.alpha = 1;
                panel.interactable = true;
                panel.blocksRaycasts = true;
            }
            else
            {
                panel.alpha = 0;
                panel.interactable = false;
                panel.blocksRaycasts = false;
            }
        }
    }

    public void GoHomeButton(CanvasGroup homePanel)
    {
        foreach (CanvasGroup panel in panels)
        {
            if (panel == homePanel)
            {
                panel.alpha = 1;
                panel.interactable = true;
                panel.blocksRaycasts = true;
            }
            else
            {
                panel.alpha = 0;
                panel.interactable = false;
                panel.blocksRaycasts = false;
            }
        }
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    private IEnumerator OpenGameScene(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(main_game_index);
    }
}