using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    private Vector3 randomPosition;

    public Vector3 RandomPosition
    {
        get { return randomPosition; }
        set { randomPosition = value; }
    }


    public AudioSource myMusic1;
    public AudioSource myMusic2;
    public GameObject box;
    public GameObject sphere;
    public Camera mainCamera;
    public GameObject bullet;
    public GameObject bulletFire;
    public Transform gun;
    private GameObject Stone;

    IEnumerator InstantiateBoxAndSphere()
    {
        Stone = GameObject.FindGameObjectWithTag("Mark");
        for (int xx = Data.Number; xx > 0; xx--)
        {
            int change = Random.Range(1, 3);
            yield return new WaitForSeconds(2f);
            //位置
            float x = Random.Range(-5, 5);
            float y = 16;
            float z = Random.Range(-5, 5);
            RandomPosition = new Vector3(x, y, z);
            if (change == 1)
            {
                Instantiate(box, RandomPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(sphere, RandomPosition, Quaternion.identity);
            }
        }
        StopCoroutine(InstantiateBoxAndSphere());
    }

    private IEnumerator InstantiateBullet()
    {
        GameObject b = Instantiate(bullet, gun.transform.position, gun.transform.rotation) as GameObject;
        GameObject a = Instantiate(bulletFire, gun.transform.position, gun.transform.rotation) as GameObject;
        Vector3 fwd = gun.transform.TransformDirection(Vector3.forward);
        b.GetComponent<Rigidbody>().AddForce(fwd * 100);
        yield return new WaitForSeconds(1f);
        Destroy(b);//1s后消失
        StopCoroutine(InstantiateBullet());
    }


    private void Start()
    {
        StartCoroutine(InstantiateBoxAndSphere());
    }

    private void Shoot()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetMouseButtonDown(0) == true)
        {
            Data.ShootNumber += 1;
            myMusic1.Play();
            StartCoroutine(InstantiateBullet());
        }
    }
    void Update()
    {
        Shoot();
    }
}