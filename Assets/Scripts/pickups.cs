using UnityEngine;

public class pickups : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject objeto1;
    public GameObject objeto2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("health"))
        {
            objeto1.SetActive(true);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("coin"))
        {
            objeto1.SetActive(false);
            objeto2.SetActive(true);
            collision.gameObject.SetActive(false);

        }
        if (collision.gameObject.CompareTag("color"))
        {
            objeto1.SetActive(false);

            SpriteRenderer playerRenderer = GetComponent<SpriteRenderer>();

            playerRenderer.color = Color.red;
        }
    }

}
