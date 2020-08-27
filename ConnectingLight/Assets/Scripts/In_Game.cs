using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class In_Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //스테이지로 돌아가기
    public void btn_exit()
    {
        SceneManager.LoadScene("Select_Stage"); 
    }
}
