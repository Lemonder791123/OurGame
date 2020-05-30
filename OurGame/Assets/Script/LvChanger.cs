using UnityEngine;
using UnityEngine.SceneManagement;

public class LvChanger : MonoBehaviour
{

    public Animator animator;

    private int LvToLoad;




    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            FadeToNextLv();
        }

    }

    public void FadeToNextLv()
    {
        FadeToLv(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void FadeToLv(int LvIndex) 
    {
        LvToLoad = LvIndex;
        animator.SetTrigger("Fade_Out");
    
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(LvToLoad);
    }
}
