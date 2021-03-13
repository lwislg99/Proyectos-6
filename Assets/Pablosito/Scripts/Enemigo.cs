using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Enemigo : MonoBehaviour
{
    GameObject player;

    public EnemyState currState = EnemyState.Wander;

    public float range;
    public float speed;

    private bool chooseDir = false;
    private bool dead = false;
    private Vector3 randomDir;

    

    float dist;

    public float daño;

    public float dmgCoolDown;

    public float vidae = 10;

    float direccion;
    float tiempo;
    public float timer1;
    public float timer2;
    public float timer3;
    public float timer4;
    public Player playeri;
    public Animator anim;

    public float coldownDaño = 1;
    // Start is called before the first frame update
    void Start()
    {
        playeri = FindObjectOfType<Player>();
        dmgCoolDown = 0;
        direccion = 1;
        tiempo = 0;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (coldownDaño >= 0)
        {
            coldownDaño -= Time.deltaTime;

        }


        dmgCoolDown = dmgCoolDown + Time.deltaTime;
        float dist = Vector3.Distance(this.transform.position, playeri.transform.position);

        switch (currState)
        {
            case (EnemyState.Wander):
                Wander();
                break;
            case (EnemyState.Follow):
                Follow();
                break;
            case (EnemyState.Die):

                break;

        }
        if (IsPlayerInRange(range) && currState != EnemyState.Die)
        {
            currState = EnemyState.Follow;

        }
        else if (!IsPlayerInRange(range) && currState != EnemyState.Die)
        {
            currState = EnemyState.Wander;
        }

        if (vidae <= 0)
        {
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
    private bool IsPlayerInRange(float range)
    {
        return Vector3.Distance(transform.position, playeri.transform.position) <= range;
    }

    void Wander()
    {
        if (direccion == 1)
        {
            timer1 = Random.Range(1, 3);
            tiempo = tiempo + Time.deltaTime;
            transform.position += new Vector3(1f * speed * Time.deltaTime, 0, 0);
            if (tiempo >= timer1)
            {
                direccion = 2;
                tiempo = 0;
            }

        }
        if (direccion == 2)
        {
            timer2 = Random.Range(1, 3);
            tiempo = tiempo + Time.deltaTime;
            transform.position += new Vector3(0, 1f * speed * Time.deltaTime, 0);
            if (tiempo >= timer2)
            {
                direccion = 3;
                tiempo = 0;
            }

        }
        if (direccion == 3)
        {
            timer3 = Random.Range(1, 3);
            tiempo = tiempo + Time.deltaTime;
            transform.position += new Vector3(-1f * speed * Time.deltaTime, 0, 0);
            if (tiempo >= timer3)
            {
                direccion = 4;
                tiempo = 0;
            }
        }
        if (direccion == 4)
        {
            timer4 = Random.Range(1, 3);
            tiempo = tiempo + Time.deltaTime;
            transform.position += new Vector3(0, -1f * speed * Time.deltaTime, 0);
            if (tiempo >= timer4)
            {
                direccion = 1;
                tiempo = 0;
            }
        }

    }
    void Follow()
    {
        transform.position = Vector2.MoveTowards(transform.position, playeri.transform.position, speed * Time.deltaTime);

    }
    void Dmg()
    {
        if (dist <= 1 && dmgCoolDown >= 2)
        {
           playeri.vida = playeri.vida - daño;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
//other.gameObject.CompareTag("areaDaño")
        if (other.tag == "areaDaño" && coldownDaño <= 0)
        {
           
            vidae -= playeri.dano;
            coldownDaño = 1;

            if (playeri.balaDanoFuego == true)
            {
                vidae -= (Time.deltaTime / 2);
            }
           
        }
        if(other.tag == "Player" && dmgCoolDown >= 0)
        {
            anim.SetBool("atack", true);
            playeri.vida -= daño;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            anim.SetBool("atack", false);
        }
    }
}
