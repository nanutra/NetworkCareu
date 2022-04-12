using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/**/

public class CareuuBehavior : MonoBehaviour, ICar
{

    private Rigidbody m_rig;

    [SerializeField] private float m_curSpeed;

    [SerializeField] private float m_weight = 1000;

    [SerializeField] private float m_maxSpeed ;

    [SerializeField] private float m_Acceleration ;

    #region wheels

    [SerializeField] private WheelCollider fLeftWheel;
    [SerializeField] private WheelCollider fRightWheel;
    [SerializeField] private WheelCollider bLeftWheel;
    [SerializeField] private WheelCollider bRightWheel;

    #endregion


    #region interface
    public float CurrentSpeed => m_curSpeed;

    public float Weight => m_weight;

    public float MaxSpeed => m_maxSpeed;

    public float Acceleration => m_Acceleration;

    #endregion



    public void Stun()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        m_rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");
        
        
        m_rig.AddForce(transform.forward * m_curSpeed * x);
        transform.Rotate(new Vector3(0f, 1f * z , 0f));
        /**/

        if(Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f) ;
            m_rig.AddForce(Vector3.zero);
        }

    }

}
