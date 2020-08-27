using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Page : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Setting창으로 화면 전환
    public void btn_Setting()
    {
        SceneManager.LoadScene("Setting_Page");
    }


    //Stage 선택 화면 전환
    public void btn_Stage()
    {
        SceneManager.LoadScene("Select_Stage");
    }

    //Exit 선택 어플리케이션 종료
    public void btn_Exit()
    {
        Application.Quit();
    }
}
