using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string gameScene;

    public void NewGame()
    {
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Debug.Log("Leaving Game!");
        Application.Quit();
    }

    public void UpscaleButtons(GameObject obj)
    {
        RectTransform rectTransform = obj.GetComponent<RectTransform>();
        LeanTween.scale(obj, new Vector3(1.25f, 1.25f, 1.25f), 0.25f).setEase(LeanTweenType.easeOutQuad);
    }

    public void DownscaleButtons(GameObject obj)
    {
        RectTransform rectTransform = obj.GetComponent<RectTransform>();
        LeanTween.scale(obj, new Vector3(1f, 1f, 1f), 0.25f).setEase(LeanTweenType.easeOutQuad);
    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }


}
