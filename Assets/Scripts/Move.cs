using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed; //���ʳt��
    public static Move Instance;
    public string alphabet;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.5f, 15f); //�H�����ʪ��t��
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
       
        transform.Translate(Vector3.left * Time.deltaTime * speed);  //�ѹ������覡�M�t��(�w��2D)
        /*
          float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
          transform.Translate(new Vector3(moveX,0f,0f));
          if (Input.GetMouseButtonDown(0))  //�u�O�ƹ����U���఻����m����
        {
            Destroy(this.gameObject);  //�R���ѹ�
            GameManager.Instance.AddScore();//�W�[����
        }
            if (Input.GetKeyDown(alphabet))
        {
            Destroy(this.gameObject);
            GameManager.Instance.AddScore();//�W�[����
        
        }
        if (Input.GetMouseButtonDown(0))  
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if(Physics.Raycast(ray, out hit))
                    {
                        if(hit.collider.gameObject==gameObject)
                        {
                            Destroy(this.gameObject);  //�R���ѹ�
                            GameManager.Instance.AddScore();//�W�[����
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
