using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UIElements;

public class mov1 : MonoBehaviour
{
    public float speed = 5f;
    public float rotate = 2f;
    public float limitx = 9;
    public float limity = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        /*        transform.Rotate(0, 0, rotate * Time.deltaTime);*/
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

        if (Input.GetButton("Fire1"))
        //or if (Input.GetKey(KeyCode.P))    ORIZW OPOIO KOUMPI THELW
        {
            transform.Rotate(0, 0, rotate * Time.deltaTime);
            //mono ena kare
            Debug.Log("Fire!");// afto mas voithaei na vlepoume ti sinveni sto log otan kanoume kati

        }

        if (Input.GetKey(KeyCode.P)) 
        { 
            transform.position = new Vector3(0, 0, 0); //AFTO METAKINI TO OBJECT
        }

        if (Input.GetKey(KeyCode.O))
        { 
            Vector3 v = transform.position; v.x = 0; transform.position = v; //AFTO METAKINI TO OBJ SE ENA AKSONA
        }


        //ORIA GIA TON ORIZONTIO AKSONA


        if (transform.position.x > limitx)
        {
            Vector3 v = transform.position;
            v.x = limitx;
            transform.position = v;
        }

        if (transform.position.x < -limitx)
        {
            Vector3 v = transform.position;
            v.x = -limitx;
            transform.position = v;

        }
        ////////////////////////


        //ORIA GIA TON ORIZONTIO AKSONA

        if (transform.position.y > limity)
        {
            Vector3 v = transform.position;
            v.y = limity;
            transform.position = v;
        }

        if (transform.position.y < -limity)
        {
            Vector3 v = transform.position;
            v.y = -limity;
            transform.position = v;

        }

        ////////////////////////







    }
}
