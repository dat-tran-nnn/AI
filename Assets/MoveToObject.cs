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

        if (Input.GetMouseButton(0))
        {
            MoveAgentToPoint(false);
        }
        if (Vector3.Distance(transform.position, FollowObject.transform.position) < 0.5f)
        {
            FollowObject = null;
        }

        if(FollowObject != null)
        {
            agent.destination = FollowObject.transform.position;
        }
        else
        {
            MoveAgentToPoint(true);
        }
    }

    void MoveAgentToPoint(bool IsFollowed)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        {
            if (IsFollowed)
            {
                agent.destination = hitInfo.point;
            }
            else
            {
                FollowObject = hitInfo.transform.gameObject;
            }
        }
    }
}
