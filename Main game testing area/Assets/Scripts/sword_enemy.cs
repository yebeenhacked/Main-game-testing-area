using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sword_enemy : MonoBehaviour
{
    public GameObject myPrefab;
    private bool isQuitting = false;
    private float mSize = 0f;
    private Renderer render;
    private MouseLook a;
    public float health;
    public float maxHealth = 100;
    public Slider slider;
    public GameObject healthBar;
    Camera camera;
    private GameObject player;
    public Transform target;
    public float speed = 4f;
    Rigidbody rig;




    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
        camera = Camera.main;
        healthBar.SetActive(false);
        slider.value = calculateHealth();
        render = GetComponent<Renderer>();
        a = GameObject.Find("Player").GetComponent<MouseLook>();
        target = GameObject.Find("Player").transform;
        rig = GetComponent<Rigidbody>();


    }
 
    void OnApplicationQuit()
    {
        isQuitting = true;
        
    }


    private void FixedUpdate()
    {
        //make enemy moce to player
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
    }
    private void Update()
    {
        healthBar.transform.LookAt(transform.position + camera.transform.rotation * Vector3.back, camera.transform.rotation * Vector3.up);
        slider.value = calculateHealth();

        if (health < maxHealth)
        {
            healthBar.SetActive(true);
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (render.isVisible)
            {

                Destroy(this.gameObject);

            }
        }

        
    }

    private void OnDestroy()
    {

        if (!isQuitting) {
            
            Vector3 a = transform.position;
            var randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.8f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.8f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.8f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.8f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.8f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);
        }
    }

    private float calculateHealth()
    {
        return health / maxHealth;
    }
}
