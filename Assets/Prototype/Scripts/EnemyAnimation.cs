using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private enum AnimationState
    {
        GoingDown,
        MidAir,
        GoingUp
    };

    [SerializeField]
    private Transform trampoline;

    private AnimationState state;

    private void Start()
    {
        state = AnimationState.GoingDown;
    }

    void Update()
    {
        if(state == AnimationState.GoingDown)
        {
            GetComponent<Animator>().SetBool("GoingDown", true);
            GetComponent<Animator>().SetBool("GoingUp", false);

            if (Vector3.Distance(transform.position, trampoline.position) <= 2.0f)
            {
                state = AnimationState.GoingUp;
            }
        }
        else if(state == AnimationState.GoingUp)
        {
            GetComponent<Animator>().SetBool("GoingUp", true);
            GetComponent<Animator>().SetBool("GoingDown", false);

            if (GetComponent<Rigidbody>().velocity.y <= 0.5f)
            {
                state = AnimationState.GoingDown;
            }
        }
    }
}
