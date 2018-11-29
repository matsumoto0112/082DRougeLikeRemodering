using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoText : MonoBehaviour
{
    [SerializeField]
    private Text text;

    public bool isAppear
    {
        get; private set;
    }
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Disappear(5.0f));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Disapper()
    {
        text.enabled = false;
        isAppear = false;
    }

    private IEnumerator Disappear(float time)
    {
        yield return new WaitForSeconds(time);
        text.enabled = false;
        isAppear = false;
    }

    public void Appear()
    {
        text.enabled = true;
        isAppear = true;        
    }
}
