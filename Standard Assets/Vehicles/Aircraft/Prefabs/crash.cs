using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crash : MonoBehaviour

       // public bool explosion = false;
{
  public GameObject Explosion ;
  public GameObject maincam ;
  public bool explosion = false;

  void OnCollisionEnter(Collision collision)
	{

        if (explosion == false)
        {
            
            StartCoroutine(RESET());
        }
        //SceneManager.LoadScene(1);



    }

    IEnumerator RESET()
    {
        explosion = true;
        //maincam.transform.position += transform.forward *50 ;
        //maincam.transform.position += transform.right * 50;
        //maincam.transform.rotation = transform.  ;
        
        Instantiate(Explosion, this.transform.position, this.transform.rotation);
       
        //Destroy(Jet);
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(1);
        explosion = false;
    }

    








    
}
