using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    private NavMeshAgent enemy;

    public GameObject waypoint;
    public List<GameObject> listWp;
    void Start()
    {

        enemy = GetComponent<NavMeshAgent>();

        foreach (Transform child in waypoint.transform)
        {
            listWp.Add(child.gameObject);
        }

        enemy.SetDestination(listWp[Random.Range(0, listWp.Count - 1)].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.remainingDistance<0.2f)
            enemy.SetDestination(listWp[Random.Range(0, listWp.Count - 1)].transform.position);

    }
}
