using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Image hpGage;
    public Player player;
    float MaxHp;
    public Text gameoverText;//ゲームオーバーテキスト
    public Text gameclearText;//ゲームクリアテキスト
    public Text timeText;//残り秒数テキスト
    float time = 10;

    void Start()
    {
        MaxHp = player.hp;
    }
    void Update()
    {
        if (time <= 0 || IsOver())
        {
            StartCoroutine(LoadTitle());
        }else{
            time -= Time.deltaTime;
        }
        timeText.text = $"残り{time:F0}秒";
        if(time <= 0){//ゲームクリア
            gameclearText.gameObject.SetActive(true);
        }else if(IsOver()){//ゲームオーバー
            gameoverText.gameObject.SetActive(true);
        }
    }
    public void DecreaseHp(){
        player.hp--;
        hpGage.fillAmount = player.hp/MaxHp;
        Debug.Log(player.hp/MaxHp);
    }
    bool IsOver(){
        return player.hp <= 0;
    }
    IEnumerator LoadTitle(){
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Title");
    }
}
