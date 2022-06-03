using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Vector3 startPosition;
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("RandomRun");
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    IEnumerator RandomRun()
    {
        Vector3 startposition = transform.position;
        float timeelapsed = 0f;
        float totallerptime = 1f;
        
        while (timeelapsed < totallerptime)
        {
            transform.position = Vector3.Lerp(startposition, new Vector3(transform.position.x + Random.Range(0, 10), 2.2f, transform.position.z + Random.Range(0, 10)), (timeelapsed / totallerptime)*speed);
            timeelapsed += Time.deltaTime;
            yield return new WaitForSeconds(2f);
            startPosition = transform.position;
        }


    }
}





//float elapsedTime = 0;
//Debug.Log("Çalýþtý");
//yield return new WaitForSecondsRealtime(3f);
//while (elapsedTime < 4f)
//{

//    transform.position = Vector3.Lerp(startPosition, new Vector3(Random.Range(-30, 30), 1.2f, Random.Range(-30, 30)), speed * Time.deltaTime);
//    elapsedTime += Time.deltaTime;
//    yield return new WaitForSecondsRealtime(3f);
//}