using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class extrasMekan : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera bizimKamera;

    public gizmoSilici silici;
    public extras seciliEleman;
    private void Start()
    {
        seciliEleman = GameObject.FindObjectOfType<extras>();
        bizimKamera = GameObject.FindObjectOfType<Camera>();
        silici = GameObject.FindObjectOfType<gizmoSilici>();

    }

    private void Update()
    {
     
    }

    private void OnMouseDown()
    {
        Vector2 realPosition = fareDunya();

        

        if (extras.seciliEleman != null)
        {
            if (extras.seciliEleman.name == "yatay")
            {
                silici.yataySilen(realPosition);

            }
            else if (extras.seciliEleman.name == "dikey")
            {
                silici.dikeySilen(realPosition);

            }
            else if (extras.seciliEleman.name == "bomb")
            {
                silici.bombSilen(realPosition);

            }



            GameObject extrasx = Instantiate(extras.seciliEleman,realPosition, Quaternion.identity) as GameObject;
            extras.seciliEleman = null;

          

            Destroy(extrasx, 0.2f);          //ayar çekkkk
           
        }
    }

    public Vector2 fareDunya()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float kameraUzakligi = 15f;
        Vector3 mousePozisyonu = new Vector3(mouseX, mouseY, kameraUzakligi);
        Vector2 gercekDunya = bizimKamera.ScreenToWorldPoint(mousePozisyonu);
        return gercekDunya;

    }
}
