using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PieHealth : MonoBehaviour
{

    public int starting_health = 8;
    public int current_health = 8;

    void Start()
    {
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        GameObject canvasGO = GameObject.Find("Canvas");

        Vector3 local_position = new Vector3(500, 150, 0);

        // initialize pie health icon with 8 slices
        GameObject tarte = Resources.Load("PieUI/tarte") as GameObject;
        GameObject pie_health = Instantiate(tarte, new Vector3(0, 0, 0), Quaternion.identity);
        pie_health.transform.parent = canvasGO.transform;
        Transform pieTransform = pie_health.GetComponent<Transform>();
        pieTransform.localPosition = local_position;
        pieTransform.localScale += new Vector3(9, 9, 0);

        GameObject tarte1 = Resources.Load("PieUI/Tarte1") as GameObject;
        GameObject pie_health1 = Instantiate(tarte1, new Vector3(0, 0, 0), Quaternion.identity);
        pie_health1.transform.parent = canvasGO.transform;
        Transform pieTransform1 = pie_health1.GetComponent<Transform>();
        pieTransform1.localPosition = local_position;
        pieTransform1.localScale += new Vector3(9, 9, 0);

        GameObject tarte2 = Resources.Load("PieUI/tarte2") as GameObject;
        GameObject pie_health2 = Instantiate(tarte2, new Vector3(0, 0, 0), Quaternion.identity);
        pie_health2.transform.parent = canvasGO.transform;
        Transform pieTransform2 = pie_health2.GetComponent<Transform>();
        pieTransform2.localPosition = local_position;
        pieTransform2.localScale += new Vector3(9, 9, 0);

        GameObject tarte3 = Resources.Load("PieUI/Tarte3") as GameObject;
        GameObject pie_health3 = Instantiate(tarte3, new Vector3(0, 0, 0), Quaternion.identity);
        pie_health3.transform.parent = canvasGO.transform;
        Transform pieTransform3 = pie_health3.GetComponent<Transform>();
        pieTransform3.localPosition = local_position;
        pieTransform3.localScale += new Vector3(9, 9, 0);

        GameObject tarte4 = Resources.Load("PieUI/Tarte4") as GameObject;
        GameObject pie_health4 = Instantiate(tarte4, new Vector3(0, 0, 0), Quaternion.identity);
        pie_health4.transform.parent = canvasGO.transform;
        Transform pieTransform4 = pie_health4.GetComponent<Transform>();
        pieTransform4.localPosition = local_position;
        pieTransform4.localScale += new Vector3(9, 9, 0);

        GameObject tarte5 = Resources.Load("PieUI/tarte5") as GameObject;
        GameObject pie_health5 = Instantiate(tarte5, new Vector3(0, 0, 0), Quaternion.identity);
        pie_health5.transform.parent = canvasGO.transform;
        Transform pieTransform5 = pie_health5.GetComponent<Transform>();
        pieTransform5.localPosition = local_position;
        pieTransform5.localScale += new Vector3(9, 9, 0);

        GameObject tarte6 = Resources.Load("PieUI/tarte6") as GameObject;
        GameObject pie_health6 = Instantiate(tarte6, new Vector3(0, 0, 0), Quaternion.identity);
        pie_health6.transform.parent = canvasGO.transform;
        Transform pieTransform6 = pie_health6.GetComponent<Transform>();
        pieTransform6.localPosition = local_position;
        pieTransform6.localScale += new Vector3(9, 9, 0);

        GameObject tarte7 = Resources.Load("PieUI/tarte7") as GameObject;
        GameObject pie_health7 = Instantiate(tarte7, new Vector3(0, 0, 0), Quaternion.identity);
        pie_health7.transform.parent = canvasGO.transform;
        Transform pieTransform7 = pie_health7.GetComponent<Transform>();
        pieTransform7.localPosition = local_position;
        pieTransform7.localScale += new Vector3(9, 9, 0);

        GameObject tarte8 = Resources.Load("PieUI/tarte8") as GameObject;
        GameObject pie_health8 = Instantiate(tarte8, new Vector3(0, 0, 0), Quaternion.identity);
        pie_health8.transform.parent = canvasGO.transform;
        Transform pieTransform8 = pie_health8.GetComponent<Transform>();
        pieTransform8.localPosition = local_position;
        pieTransform8.localScale += new Vector3(9, 9, 0);

    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Co-ordinate with enemy AI script and decide how the script will know when the pie is being eaten
    }

    public void TakeDamage()
    {
        current_health--;
        if (current_health <= 0)
        {
            print("Pie has been eaten");    // TODO: What will happen when pie is eaten fully?
        }
    }
}
