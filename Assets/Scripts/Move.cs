using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed; //簿笆硉
    public static Move Instance;
    public string alphabet;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.5f, 15f); //繦诀簿笆硉
        if(speed<=15f && speed>=10f)
        {
            GameManager.Instance.max = 10;
        }
        if (speed < 10f && speed >= 5f)
        {
            GameManager.Instance.max = 5;
        }
        if (speed < 5f && speed >= 0.5f)
        {
            GameManager.Instance.max = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector3.left * Time.deltaTime * speed);  //ρ公奔辅よΑ㎝硉(皐癸2D)
        /*
          float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
          transform.Translate(new Vector3(moveX,0f,0f));
          if (Input.GetMouseButtonDown(0))  //琌菲公ぃ盎代竚ア
        {
            Destroy(this.gameObject);  //篟反ρ公
            GameManager.Instance.AddScore();//糤だ计
        }
            if (Input.GetKeyDown(alphabet))
        {
            Destroy(this.gameObject);
            GameManager.Instance.AddScore();//糤だ计
        
        }
        if (Input.GetMouseButtonDown(0))  
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if(Physics.Raycast(ray, out hit))
                    {
                        if(hit.collider.gameObject==gameObject)
                        {
                            Destroy(this.gameObject);  //篟反ρ公
                            GameManager.Instance.AddScore();//糤だ计
                        }
                    }
            
                }
        */



        if (transform.position.x >10 || transform.position.x<-10 )
            {
                Destroy(this.gameObject);
            }
    }
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        GameManager.Instance.AddScore();
    }
}
