﻿using System.Collections;
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
    public void Setting_btn()
    {
        SceneManager.LoadScene("Setting_Page");
    }


    //Stage 선택 화면 전환
    public void Stage_btn()
    {
        SceneManager.LoadScene("Select_Stage");
    }
}
