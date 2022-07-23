using UnityEngine;

public class Player : MonoBehaviour
{
    public float hor;
    public float ver;
    public float speed;
    public GameObject camUno;
    public GameObject camDos;
    public float rotateSpeed;
    public Animator anim;
    public bool modoCombate;
    private bool patada1;
    private bool patada2;
    private bool puño1;
    private bool puño2;
    private bool slide;
    private bool crouch;
    private bool doge;
    public int Health = 100;
    private int daño = 20;






    void Start()
    {

    }


    void Update()
    {
        PlayerMoveMentRE();
        ModoCombate();
        RecibirDaño();
        Death();
    }

    void PlayerMoveMentRE()
    {
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, ver) * speed * Time.deltaTime);

        float hor = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, hor, 0) * rotateSpeed * Time.deltaTime);

        Vector3 inputPlayer = new Vector3(hor, 0, ver);

        transform.Translate(inputPlayer * speed * Time.deltaTime);

        if (inputPlayer == Vector3.zero)
        {
            anim.SetBool("Walk", false);
        }
        else
        {
            anim.SetBool("Walk", true);
        }

    }

    void ModoCombate()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            modoCombate = true;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            modoCombate = false;
        }


        if (modoCombate == true)
        {
            anim.SetBool("Mcombat", true);
        }
        else
        {
            anim.SetBool("Mcombat", false);
        }

        if (Input.GetKeyDown(KeyCode.E) && modoCombate == true)
        {
            patada1 = true;
        }
        else
        {
            patada1 = false;
        }

        if (patada1 == true)
        {
            anim.SetBool("Patada1", true);
        }
        else
        {
            anim.SetBool("Patada1", false);
        }

        if (Input.GetKeyDown(KeyCode.R) && modoCombate == true)
        {
            patada2 = true;
        }
        else
        {
            patada2 = false;
        }

        if (patada2 == true)
        {
            anim.SetBool("Patada2", true);
        }
        else
        {
            anim.SetBool("Patada2", false);
        }



        if (Input.GetKeyDown(KeyCode.Q) && modoCombate == true)
        {
            puño1 = true;
        }
        else
        {
            puño1 = false;
        }

        if (puño1 == true)
        {
            anim.SetBool("Puño1", true);
        }
        else
        {
            anim.SetBool("Puño1", false);
        }

        if (Input.GetKeyDown(KeyCode.F) && modoCombate == true)
        {
            puño2 = true;
        }

        if (puño2 == true)
        {
            anim.SetBool("Puño2", true);
        }
        else
        {
            anim.SetBool("Puño2", false);
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.gameObject.name == "Enemy")
        {
            Debug.Log("Has sido golpeado");

            if (Health <= 100)
            {
                RecibirDaño();
            }
        }
    }

    void RecibirDaño()
    {
        if (Health <= 100)
        {
            daño = Health - 20;
        }
    }

    void Death()
    {
        if (Health <= 0) Destroy(gameObject);
    }



}