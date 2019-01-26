using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   
    public void ChangeScene(string SceneName)
    {

        SceneManager.LoadScene("MaisonPlayerV1", LoadSceneMode.Additive);
      
    }




















}
