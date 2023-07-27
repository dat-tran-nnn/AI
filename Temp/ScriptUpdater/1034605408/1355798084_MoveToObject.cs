using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    public GameObject FollowObject;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
