using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TMP_Text _loadingValuetxt;

    private void Start()
    {
        _slider.value = 0;
        _loadingValuetxt.text = _slider.value.ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            StartCoroutine("LoadLevel");
    }

    IEnumerator LoadLevel()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("NextScene");
        while(!asyncOperation.isDone)
        {
            _slider.value = asyncOperation.progress;
            _loadingValuetxt.text = asyncOperation.progress.ToString();
            yield return null;
        }
    }
}
