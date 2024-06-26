using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear_pic_Generate : MonoBehaviour
{
    //各ステージがパーフェクトであるかを判定する変数を呼び出すための宣言
    //public GameManager gameManager;
    public PlayerController playerController;
    public PlayerCollision playerCollision;

    //メダルのプレハブオブジェクトを入れるための変数
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //ゲーミング誉め言葉のプレハブオブジェクトを入れるための変数
    public GameObject Congratulations;
    public GameObject Excellent;
    public GameObject Great;
    public GameObject Good;

    //オブジェクトの場所調整用
    public Transform OBJ_T;
    private float pos_ad = 150.0f;

    //花火を入れる変数
    public GameObject Hanabi_Yellow;
    public GameObject Hanabi_Green;
    public GameObject Hanabi_Blue;
    public GameObject Hanabi_Red;

    //花火の間隔
    int interval = -25;
    int random_collar = 0;

    //親を指定
    public Transform Parent;

    //呼び出したスコアを格納する変数
    private int MyScore;

    //各ステージのMAXScore設定
    private int Stage1_MAX = 11500;
    private int Stage2_MAX = 20000;
    private int Stage3_MAX = 30000;

    //一回だけ処理をするための変数
    private bool once_clear;

    // Start is called before the first frame update
    void Start()
    {
        once_clear = true;
        Stage1_MAX = playerCollision.stage1MAXscore;
        Stage2_MAX = playerCollision.stage2MAXscore;
        Stage3_MAX = playerCollision.stage3MAXscore;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClearDisplay()//ゲームをクリアしたら呼び出す
    {
        //ゲームクリアしたら
        if (playerController.isClear == true && once_clear == true)
        {
            //ステージ１
            //マイスコアにスコアを格納
            if (GameManager.stage_num == 1)//ステージ１だったら
            {
                MyScore = PlayerPrefs.GetInt("STAGE1SCORE", -1);

                if (playerController.playerHP==100&&Stage1_MAX==MyScore)//ステージ１がパーフェクト
                {
                    Instantiate(Perfect, OBJ_T.transform.position, Quaternion.identity, Parent);//メダル
                    Instantiate(Congratulations, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 10 5
                    for (int i = 0; i < 10; i++, interval += 5)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - 3000)//金
                {
                    Instantiate(Gold, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 6 8
                    for (int i = 0; i < 6; i++, interval += 8)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar){
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage1_MAX - 3000 && MyScore >= Stage1_MAX - 8000)//銀
                {
                    Instantiate(Silver, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 4 14
                    for (int i = 0; i < 4; i++, interval += 14)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage1_MAX - 8000 && MyScore >= 0)//銅
                {
                    Instantiate(Bronze, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 3 20
                    for (int i = 0; i < 3; i++, interval += 20)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
            }
            //ステージ２
            //マイスコアにスコアを格納
            else if (GameManager.stage_num == 2)//ステージ２だったら
            {
                MyScore = PlayerPrefs.GetInt("STAGE2SCORE", -1);

                if (playerController.playerHP == 100 && Stage2_MAX == MyScore)//ステージ２がパーフェクト
                {
                    Instantiate(Perfect, OBJ_T.transform.position, Quaternion.identity, Parent);//メダル
                    Instantiate(Congratulations, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 10 5
                    for (int i = 0; i < 10; i++, interval += 5)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage2_MAX && MyScore >= Stage2_MAX - 3000)//金
                {
                    Instantiate(Gold, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 6 8
                    for (int i = 0; i < 6; i++, interval += 8)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage2_MAX - 3000 && MyScore >= Stage2_MAX - 8000)//銀
                {
                    Instantiate(Silver, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 4 14
                    for (int i = 0; i < 4; i++, interval += 14)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage2_MAX - 8000 && MyScore >= 0)//銅
                {
                    Instantiate(Bronze, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 3 20
                    for (int i = 0; i < 3; i++, interval += 20)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
            }
            //ステージ３
            //マイスコアにスコアを格納
            else if (GameManager.stage_num == 3)//ステージ３だったら
            {
                MyScore = PlayerPrefs.GetInt("STAGE3SCORE", -1);

                if (playerController.playerHP == 100 && Stage3_MAX == MyScore)//ステージ３がパーフェクト
                {
                    Instantiate(Perfect, OBJ_T.transform.position, Quaternion.identity, Parent);//メダル
                    Instantiate(Congratulations, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 10 5
                    for (int i = 0; i < 10; i++, interval += 5)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage3_MAX && MyScore >= Stage3_MAX - 3000)//金
                {
                    Instantiate(Gold,OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 6 8
                    for (int i = 0; i < 6; i++, interval += 8)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage3_MAX - 3000 && MyScore >= Stage3_MAX - 8000)//銀
                {
                    Instantiate(Silver, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 4 14
                    for (int i = 0; i < 4; i++, interval += 14)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage3_MAX - 8000 && MyScore >= 0)//銅
                {
                    Instantiate(Bronze,OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + pos_ad, OBJ_T.transform.position.z), Quaternion.identity, Parent);//ゲーミング誉め言葉

                    //花火 3 20
                    for (int i = 0; i < 3; i++, interval += 20)
                    {
                        random_collar = Random.Range(1, 5);//1〜4でランダム
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
            }

            //一回だけ呼び出す変数をfalseにする
            once_clear = false;
        }

    }
}

