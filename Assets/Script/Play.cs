using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Play : MonoBehaviour
{
    [SerializeField] private Transform a;
    [SerializeField] private TMP_InputField inputSpeed;
    [SerializeField] private TMP_InputField inputWay;
    [SerializeField] private TMP_InputField inputTime;
    static public float speed;
    static public float way;
    [SerializeField] private float time;
    private float timeActive = 0;
    [SerializeField] private GameObject cube;
    [SerializeField] private bool InsActive; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeActive -= Time.deltaTime;
        if(InsActive == true && timeActive < 0)
        {
            Instantiate(cube,a.position,transform.rotation);
            timeActive = time;
        }
    }
    public void Speed(){
        way = float.Parse(inputWay.text);
        speed = float.Parse(inputSpeed.text);
        time = float.Parse(inputTime.text);
        InsActive = true;
    }
}
