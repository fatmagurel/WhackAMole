using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyun : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public Text sureText;
    public float sure;
    public Transform nesne;
    private rasgele[] oyuncaklar;
    public float gorunmeSuresi = 0.8f;
    public Puan cekic; 
    // Use this for initialization

    void Start()
    {
        
        sure = 60f;
        sureText.text = "" + (int)sure;
        oyuncaklar = nesne.GetComponentsInChildren<rasgele>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                if (hit.transform.GetComponent<rasgele>() != null)
                {
                    rasgele oyuncaklar = hit.transform.GetComponent<rasgele>();
                    oyuncaklar.goster();
                    cekic.Vur(oyuncaklar.transform.position);
                }
            }
        }
        sure -= Time.deltaTime;

        if (sure > 0f)
        {
            sureText.text = "" + (int)sure;
            gorunmeSuresi -= Time.deltaTime;

            if (gorunmeSuresi < 0f)
            {
                oyuncaklar[UnityEngine.Random.Range(0, oyuncaklar.Length)].goster();
                gorunmeSuresi = 0.8f;
            }

        }

        else
        {
            sureText.text = "Süre Bitti!";
            Sahne(2);
        }
    }

    void Sahne(int id)
    {
        
         SceneManager.LoadScene(2);
        
    }
}
