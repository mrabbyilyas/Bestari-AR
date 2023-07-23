using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public void ChangeScene(string NamaScene)
    {
        SceneManager.LoadScene(NamaScene);
        Debug.Log("berhasil pindah scene");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("berhasil keluar game");
    }
}
