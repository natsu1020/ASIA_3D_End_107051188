using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   
    public void Restart()
    {
        SceneManager.LoadScene("3D場景");
    }

    public void Quit()
    {
        Application.Quit();
    }




}
