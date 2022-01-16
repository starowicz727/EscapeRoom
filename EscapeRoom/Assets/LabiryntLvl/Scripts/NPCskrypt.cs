using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class NPCskrypt : MonoBehaviour
{
    // jeśli bez losowania to wystarcza 2 cele
    public Transform cel1;
    public Transform cel2;
    public Transform cel3;
    public Transform cel4;
    public Transform NPC;
    public Transform Gracz;
    Transform cel;
    NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        cel = cel2;
        agent.SetDestination(cel.position);
    }

    private void Update()
    {
        // wersja bez losowania
        //if (NPC.position.x == cel.position.x) 
        //{
        //    if(cel == cel2)
        //    {
        //        cel = cel1;
        //    }
        //    else
        //    {
        //        cel = cel2;
        //    }
        //    agent = this.GetComponent<NavMeshAgent>();
        //    agent.SetDestination(cel.position);
            
        //}

        //wersja z losowaniem
        if (NPC.position.x == cel.position.x)
        {
            agent = this.GetComponent<NavMeshAgent>();
            celLosowanie();
            agent.SetDestination(cel.position);
        }
    }

    void celLosowanie()
    {
        int wynik = Random.Range(1, 5);
        if (wynik == 1)
        {
            cel = cel1;
        }
        else if (wynik == 2)
        {
            cel = cel2;
        }
        else if (wynik == 3)
        {
            cel = cel3;
        }
        else if (wynik == 4)
        {
            cel = cel4;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cel = Gracz;
            agent.SetDestination(cel.position);
        }
    } 
    private void OnCollisionEnter(Collision collision){
            //private void OnCollisionEnter(Collider other){
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene("Menu");
        }    
    }  
    private void OnTriggerExit(Collider other)
    {
        celLosowanie();
        agent.SetDestination(cel.position);
    }
}