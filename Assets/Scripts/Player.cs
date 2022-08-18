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
    public bool combatMode;
    private bool Kick1;
    private bool Kick2;
    private bool punch1;
    private bool punch2;
    private bool slide;
    private bool crouch;
    private bool doge;
    public static float Health = 100f;
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
            combatMode = true;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            combatMode = false;
        }


        if (combatMode == true)
        {
            anim.SetBool("Mcombat", true);
        }
        else
        {
            anim.SetBool("Mcombat", false);
        }

        if (Input.GetKeyDown(KeyCode.E) && combatMode == true)
        {
            Kick1 = true;
        }
        else
        {
            Kick1 = false;
        }

        if (Kick1 == true)
        {
            anim.SetBool("Kick1", true);
        }
        else
        {
            anim.SetBool("Kick1", false);
        }

        if (Input.GetKeyDown(KeyCode.R) && combatMode == true)
        {
            Kick2 = true;
        }
        else
        {
            Kick2 = false;
        }

        if (Kick2 == true)
        {
            anim.SetBool("Kick2", true);
        }
        else
        {
            anim.SetBool("Kick2", false);
        }



        if (Input.GetKeyDown(KeyCode.Q) && combatMode == true)
        {
            punch1 = true;
        }
        else
        {
            punch1 = false;
        }

        if (punch1 == true)
        {
            anim.SetBool("punch1", true);
        }
        else
        {
            anim.SetBool("punch1", false);
        }

        if (Input.GetKeyDown(KeyCode.F) && combatMode == true)
        {
            punch2 = true;
        }

        if (punch2 == true)
        {
            anim.SetBool("punch2", true);
        }
        else
        {
            anim.SetBool("punch2", false);
        }

    }

  
    void Death()
    {
        if (Health <= 0) Destroy(gameObject);
    }



}