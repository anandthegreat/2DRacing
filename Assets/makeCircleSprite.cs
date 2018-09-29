using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCircleSprite : MonoBehaviour {

    public Sprite Circle;
    public int max_coverage = 100;
    float timer = 1f;
    public float delay = 1f;
    public float width = 1f;
    public float height = 1f;
    public Vector3 position = new Vector3(0, 0, 0);

    void Awake()
    {
        // set the scaling
        
    }
    private void Start()
    {
        this.gameObject.GetComponent<SpriteMask>().sprite = Circle;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer<=0) 
        {
            
            print("in the timer");
                
                
                Vector3 scale = new Vector3(width, height, 1f);
                width = width + 0.1f;
                height = height + 0.1f;
                transform.localScale = scale;
                // set the position
                transform.position = position;
                timer = delay;
            if (width > max_coverage)
            {
                width = 1;
                height = 1;
            }
        }
    }
}
