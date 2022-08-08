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
    private bool pu�o1;
    private bool pu�o2;
    private bool slide;
    private bool crouch;
    private bool doge;
    public static float Health = 100f;
    private int da�o = 20;
    public Rigidbody rb;
    private float vidaRestante;






    void Start()
    {

    }


    void Update()
    {
        PlayerMoveMentRE();
        CombatMode();
        Death();
    }

    void PlayerMoveMentRE()
    {
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, ver) * speed * Time.deltaTime);

        float hor = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, hor, 0) * rotateSpeed * Time.deltaTime);

        Vector3 inputPlayer = new Vector3(hor, 0, ver);

        rb.AddForce(inputPlayer * speed * Time.deltaTime);

        if (inputPlayer == Vector3.zero)
        {
            anim.SetBool("Walk", false);
        }
        else
        {
            anim.SetBool("Walk", true);
        }

    }

    void CombatMode()
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
            pu�o1 = true;
        }
        else
        {
            pu�o1 = false;
        }

        if (pu�o1 == true)
        {
            anim.SetBool("Pu�o1", true);
        }
        else
        {
            anim.SetBool("Pu�o1", false);
        }

        if (Input.GetKeyDown(KeyCode.F) && modoCombate == true)
        {
            pu�o2 = true;
        }

        if (pu�o2 == true)
        {
            anim.SetBool("Pu�o2", true);
        }
        else
        {
            anim.SetBool("Pu�o2", false);
        }

    }

  
    void Death()
    {
        if (Health <= 0) Destroy(gameObject);
    }



}