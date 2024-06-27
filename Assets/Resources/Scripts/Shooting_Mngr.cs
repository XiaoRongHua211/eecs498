using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shooting_Mngr : MonoBehaviour
{
    public GameObject bullet_prefab;
    public AudioSource Shootaudio;
    public Text ScoreTxt;
    public int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text= $"ÀÛ¼Æ·ÖÊý£º{ScoreNum}";
    }

    public void OnShooting()
    {
        GameObject obj = GameObject.Instantiate(bullet_prefab);

        Shootaudio.Play();

        Debug.Log(Camera.main.transform.position);

        Vector3 forwardVector = Camera.main.transform.forward;

        string inputWord = GameObject.Find("InputWord").GetComponent<InputField>().text;

        Debug.Log("inputword: " + inputWord);

        obj.GetComponent<Bullet_Mngr>().SetLabel(LanguageDictionary.TranslateToEnglish(inputWord));

        obj.GetComponent<Transform>().position = Camera.main.transform.position;

        obj.GetComponent<Rigidbody>().velocity = forwardVector * 20.0f;

        Debug.Log(LanguageDictionary.TranslateToEnglish(inputWord));


        GameObject.Destroy(obj, 10f);
    }
}
