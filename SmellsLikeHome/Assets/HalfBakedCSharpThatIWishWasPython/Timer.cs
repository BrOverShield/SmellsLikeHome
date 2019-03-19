using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    private Text text;
    private float timeleft = 300.0f;

    // shamelessly stolen from some forum, don't worry about it
    void Awake()
    {
        // Load the Arial font from the Unity Resources folder.
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        // Create Canvas GameObject.
        GameObject canvasGO = new GameObject();
        canvasGO.name = "Canvas";
        canvasGO.AddComponent<Canvas>();
        canvasGO.AddComponent<CanvasScaler>();
        canvasGO.AddComponent<GraphicRaycaster>();

        // Get canvas from the GameObject.
        Canvas canvas;
        canvas = canvasGO.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        // Create the Text GameObject.
        GameObject textGO = new GameObject();
        textGO.transform.parent = canvasGO.transform;
        textGO.AddComponent<Text>();

        // Set Text component properties.
        text = textGO.GetComponent<Text>();
        text.font = arial;
        text.fontSize = 24;
        text.alignment = TextAnchor.MiddleCenter;

        // Provide Text position and size using RectTransform.
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(-480, 180, 0);
        rectTransform.sizeDelta = new Vector2(600, 200);
    }

    void Update()
    {
        timeleft -= Time.deltaTime; // subtract off time since last loop
        if (timeleft < 0)
        {
            print("Time's Up"); // TODO: run function to do whatever we want to happen when time is up, and yes, I know this will spam the console
            GameObject camera = GameObject.Find("Main Camera");
            Credits play_credits = camera.AddComponent<Credits>();
            SceneManager.LoadScene("Victory", LoadSceneMode.Single);
        }
        else
        {
            TimeSpan time_display = TimeSpan.FromSeconds(timeleft);
            text.text = "Time Left: " + time_display.ToString(@"m\:ss");
        }
    }
}