using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rasgele : MonoBehaviour
{
    public float max = 2f;
    public float min = 0.5f;
    public Vector3 yeniPozisyon;
    public float speed = 5f;
    public float kaybolmaSuresi = 0.8f;
    // Start is called before the first frame update

    private void Awake()
    {
        kaybol();
        transform.position = yeniPozisyon;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,yeniPozisyon,Time.deltaTime*speed);
        kaybolmaSuresi -= Time.deltaTime;
        if(kaybolmaSuresi<0)
        {
            kaybol();
        }
    }

    public void kaybol()
    {
        yeniPozisyon = new Vector3(transform.position.x, min, transform.position.z);
    }

    public void goster()
    {
        yeniPozisyon = new Vector3(transform.position.x, max, transform.position.z);

        kaybolmaSuresi = 0.8f;
       
    }
    
}

