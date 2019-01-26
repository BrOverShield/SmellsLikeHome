using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{

    public void ChangeScene(string SceneName)
    {

        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

    }







}
