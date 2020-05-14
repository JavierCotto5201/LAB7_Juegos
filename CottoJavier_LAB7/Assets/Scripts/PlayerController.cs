using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    //Rigidbody rb;

    private NavMeshAgent agent;
    void Start()
    {

        //rb = GetComponent<Rigidbody>();

        agent = GetComponent<NavMeshAgent>();

    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;


            if (Physics.Raycast(myRay, out hitInfo))
            {

                agent.SetDestination(hitInfo.point);

            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.CompareTag("Destruccion"))
            Destroy(gameObject);
                    
    }
}
