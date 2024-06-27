using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class floatingTarget : MonoBehaviour
{
    public string label;

    static Vector3 center = new Vector3(0, 0, 15);
    static int radius = 10;
    private float startTime;
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float journeyLength;

    private float speed = 1f;

    private Vector3 rotateOffset;

    public ParticleSystem bulletParticle;
    public AudioSource BombAudio;
    private Shooting_Mngr shooting_Mngr;

    // Start is called before the first frame update
    void Start()
    {
        shooting_Mngr = GameObject.Find("Canvas").GetComponent<Shooting_Mngr>();
        gameObject.GetComponent<Transform>().position = center;
        startTime = Time.time;
        startPosition = center;
        Vector3 Offset = Random.insideUnitSphere;
        Offset.z = Offset.z / 2;
        targetPosition = center + Offset * radius;
        journeyLength = Vector3.Distance(startPosition, targetPosition);
        rotateOffset = Random.insideUnitSphere * 20;
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distCovered / journeyLength;

        if (fractionOfJourney > 1)
        {
            fractionOfJourney = 1;
        }

        transform.position = Vector3.Lerp(startPosition, targetPosition, fractionOfJourney);

        if (transform.position == targetPosition)
        {
            startTime = Time.time;
            startPosition = transform.position;
            Vector3 Offset = Random.insideUnitSphere;
            Offset.z = Offset.z / 2;
            targetPosition = center + Offset * radius;
            journeyLength = Vector3.Distance(transform.position, targetPosition);
        }

        transform.rotation *= Quaternion.Euler(rotateOffset.x * Time.deltaTime, rotateOffset.y * Time.deltaTime, rotateOffset.z * Time.deltaTime); ;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Debug.Log("Bullet Label:" + other.gameObject.GetComponent<Bullet_Mngr>().GetLabel() + "Obj Label:" + label);
            if (other.gameObject.GetComponent<Bullet_Mngr>().GetLabel() == label)
            {
                //Destroy(gameObject);
                enumerator(label);
            }

            // Destroy(other.gameObject);
        }
    }

    async void  enumerator(string label)
    {
        switch (label)
        {
            case "apple":
                shooting_Mngr.ScoreNum += 10;
                break;
            case "book":
                shooting_Mngr.ScoreNum += 11;
                break;
            case "bottle":
                shooting_Mngr.ScoreNum += 9;
                break;
            case "cell phone":
                shooting_Mngr.ScoreNum += 7;
                break;
            case "chair":
                shooting_Mngr.ScoreNum += 8;
                break;
            case "keyboard":
                shooting_Mngr.ScoreNum += 2;
                break;
            case "laptop":
                shooting_Mngr.ScoreNum += 3;
                break;
            case "tv monitor":
                shooting_Mngr.ScoreNum += 1;
                break;
            case "mouse":
                shooting_Mngr.ScoreNum += 4;
                break;
        }
        GameObject obj = Instantiate(GameObject.Find("EffectObj"));
        gameObject.SetActive(false);
        obj.transform.GetChild(0).gameObject.SetActive(true);
        obj.transform.position = transform.position;
        obj.GetComponentInChildren<AudioSource>().Play();
        //特效播放
        //bulletParticle.Play();
        //击中声音播放
        await Task.Delay(1000);
        obj.SetActive(false);
        Destroy(obj);
        Destroy(gameObject);
    }
}
