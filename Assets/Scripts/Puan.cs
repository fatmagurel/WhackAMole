using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{
    private Vector3 konum;
    public Text scoreText;
    public int score = 0;
    public float speed = 1f;
    public Vector3 yeniPozisyon;
    AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        konum = transform.position;
    }

    private void Awake()
    {
        transform.position = yeniPozisyon;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, yeniPozisyon, Time.deltaTime * speed);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                konum = hit.point;
                transform.position = konum;

                if(hit.transform.tag=="kostebek")
                {
                    audioSource.Play();
                    score = score + 5;
                    scoreText.text = score.ToString();
                }

                if (hit.transform.tag == "fire")
                {
                    audioSource.Play();
                    score = score - 5;
                    scoreText.text = score.ToString();
                }
            }
        }
        yeniPozisyon = new Vector3(15, 0, 0);

    }

    public void Vur(Vector3 oyuncak)
    {
        transform.position = oyuncak;
    }
       
}
