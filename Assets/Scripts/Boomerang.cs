using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Boomerang : MonoBehaviour
{
    public float cycleLength = 1f;
    [SerializeField] Transform gunLocation;
    [SerializeField] GameObject cam;
    Transform x;
    EnemyControl spawner;
    public bool canShoot = true;
    Rigidbody rb;
    Vector3 locationOfPlayer;
   
    private void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        spawner = GameManager.Instance.GetComponentInChildren<EnemyControl>();
        locationOfPlayer = new Vector3(gunLocation.position.x, gunLocation.position.y + 1, gunLocation.position.z) + gunLocation.transform.forward * 10f;
    }
    private void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            //StartCoroutine(Boom());
            //StartCoroutine(BoomerangCoroutine());
        }
        //if (go)
        //{
        //    // transform.position = Vector3.MoveTowards(transform.position, locationOfPlayer, Time.deltaTime * 40f);
        //    rb.velocity = transform.forward * 20f;
        //}
        //if (!go)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, new Vector3(gunLocation.transform.position.x - transform.position.x, gunLocation.transform.position.y - transform.position.y+2, gunLocation.transform.position.z - transform.position.z), 100f * Time.deltaTime);
        //    //transform.position = Vector3.MoveTowards(transform.position, new Vector3(gunLocation.position.x, gunLocation.position.y, gunLocation.position.z), Time.deltaTime * 40);
        //}
    }

    public void BoomerangAction()
    {
        if (Input.GetKeyDown("space")&& canShoot)
        {




            //    transform.DOLocalMoveZ(10f, 1f);

            //   // transform.parent = null;


            //}
            //if(transform.parent != null)
            //{
            //    canShoot = true;
            //}

            //if (Input.GetKeyDown(KeyCode.X))
            //{
            //    transform.position = Vector3.MoveTowards(transform.position, gunLocation.position, 100f);
            //    transform.SetParent(gunLocation);
        }
       
    }
    IEnumerator Ornek()
    {
        while (true)
        {
            Debug.Log("Çalýþtým.");
            yield return new WaitForSeconds(3f);
            Debug.Log("Çalýþtým.");
        }

    }
    IEnumerator BoomerangCoroutine()
    {
        Debug.Log("Çalýþtým");



        rb.velocity = transform.forward * 20f;
        transform.parent = null;
        yield return new WaitForSeconds(3f);
        
        yield return new WaitForSeconds(1f);
        //transform.position = Vector3.MoveTowards(transform.position, (gunLocation.transform.position-transform.position),100f*Time.deltaTime);

        yield return new WaitForSeconds(3f);
        //rb.transform.SetParent(gunLocation.transform);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            
            Debug.Log("Çarptým");
            spawner.enemiesKilled++;
            Destroy(other.gameObject);
            GameManager.Instance.gameTime = GameManager.Instance.gameTime - 2;
        }
    }
    bool go;
    IEnumerator Boom()
    {
        go = true;
        yield return new WaitForSeconds(1.5f);
        go = false;
    }
}
