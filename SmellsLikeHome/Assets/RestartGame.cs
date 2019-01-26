using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public void ChangeScene(string SceneName)
    {

        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

    }







}
