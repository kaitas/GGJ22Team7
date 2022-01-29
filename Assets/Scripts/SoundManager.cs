using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// 　サウンドマネージャークラス
/// 音関係の処理用、シングルトンで管理
/// version1.0(2021-10-24)
/// author TanoueKazuya
/// 
/// </summary>
public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
    [SerializeField, Range(0, 1), Tooltip("マスタ音量")] float volume = 1;     //総音量の数値、パーセンテージで管理
    [SerializeField, Range(0, 1), Tooltip("BGMの音量")] float bgmVolume = 1;  //BGM音量の数値、パーセンテージで管理
    [SerializeField, Range(0, 1), Tooltip("SEの音量")] float seVolume = 1;   //SEの数値、パーセンテージで管理

    AudioClip[] bgm;    //全BGMの管理用配列
    AudioClip[] se;     //全SEの管理用配列
    AudioClip Posebgm;


    Dictionary<string, int> bgmIndex = new Dictionary<string, int>();   //BGMをstringで取得するための変数
    Dictionary<string, int> seIndex = new Dictionary<string, int>();    //SEをstringで取得するための変数

    AudioSource bgmAudioSource; //BGMを再生する用の変数
    AudioSource seAudioSource;  //SEを再生する用の変数

    int BGMint = -1;//BGMをシーン遷移で継続させる用の変数


    /// <summary>
    /// 
    /// 　総音量の取得関数
    /// 
    /// </summary>
    public float Volume
    {
        set
        {
            volume = Mathf.Clamp01(value);
            bgmAudioSource.volume = bgmVolume * volume;
            seAudioSource.volume = seVolume * volume;
        }
        get
        {
            return volume;
        }
    }

    /// <summary>
    /// 
    /// 　BGM音量の取得関数
    /// 
    /// </summary>
    public float BgmVolume
    {
        set
        {
            bgmVolume = Mathf.Clamp01(value);
            bgmAudioSource.volume = bgmVolume * volume;
        }
        get
        {
            return bgmVolume;
        }
    }

    /// <summary>
    /// 
    /// 　SE音量の取得関数
    /// 
    /// </summary>
    public float SeVolume
    {
        set
        {
            seVolume = Mathf.Clamp01(value);
            seAudioSource.volume = seVolume * volume;
        }
        get
        {
            return seVolume;
        }
    }

    /// <summary>
    /// 
    /// 　起動時に実行される関数
    /// 
    /// </summary>
    public void Awake()
    {
        //シングルトン用の処理
        if (this != Instance)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        //AudioSourceを取得
        bgmAudioSource = gameObject.AddComponent<AudioSource>();
        seAudioSource = gameObject.AddComponent<AudioSource>();

        //Audioファイル内にあるBGM、SE音声ファイルを取得
        bgm = Resources.LoadAll<AudioClip>("Audio/BGM");
        se = Resources.LoadAll<AudioClip>("Audio/SE");

        //bgmIndex、seIndexに音声ファイルを代入
        for (int i = 0; i < bgm.Length; i++)
        {
            bgmIndex.Add(bgm[i].name, i);
        }
        for (int i = 0; i < se.Length; i++)
        {
            seIndex.Add(se[i].name, i);
        }
    }

    /// <summary>
    /// 
    /// 　bgmIndex内にあるBGM音声ファイルの取得
    /// 
    /// </summary>
    /// <param name="name">BGM名</param>
    /// <returns></returns>
    public int GetBgmIndex(string name)
    {
        if (bgmIndex.ContainsKey(name))
        {
            return bgmIndex[name];
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// 
    /// 　SEIndex内にあるSE音声ファイルの取得
    /// 
    /// </summary>
    /// <param name="name">SE名</param>
    /// <returns></returns>
    public int GetSeIndex(string name)
    {
        if (seIndex.ContainsKey(name))
        {
            return seIndex[name];
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// 
    /// 　BGMを再生させる関数
    /// 
    /// </summary>
    /// <param name="index">BGMファイルの選択</param>
    /// <param name="isloop">BGMをループさせるかの変数</param>
    public void PlayBgm(int index, bool isloop = true)
    {
        //音量を代入
        index = Mathf.Clamp(index, 0, bgm.Length);

        //AudioSourceの設定
        bgmAudioSource.clip = bgm[index];
        bgmAudioSource.loop = isloop;
        bgmAudioSource.volume = BgmVolume * Volume;

        //遷移時に途切れさせない用の処理
        if (BGMint != index)
        {
            BGMint = index;
            bgmAudioSource.Play();
        }
    }

    /// <summary>
    /// 
    /// 　BGMを再生させる関数
    /// 上記の関数をStringでアクセスする
    /// 
    /// </summary>
    /// <param name="name">BGMファイルのString変数</param>
    /// <param name="isloop">BGMをループさせるかの変数</param>
    public void PlayBgmByName(string name, bool isloop = true)
    {
        if (name == "Pose")
        {
            bgmAudioSource.clip = Posebgm;
            bgmAudioSource.loop = isloop;
            bgmAudioSource.volume = BgmVolume * Volume;
            bgmAudioSource.Play();
        }
        else
        {
            PlayBgm(GetBgmIndex(name), isloop);
        }

    }

    /// <summary>
    /// 
    /// 　BGMの停止関数
    /// 
    /// </summary>
    public void StopBgm()
    {
        bgmAudioSource.Stop();
        Posebgm = bgmAudioSource.clip;

        bgmAudioSource.clip = null;
    }

    /// <summary>
    /// 
    /// 　SEを再生させる関数
    /// 
    /// </summary>
    /// <param name="index">SEファイルの選択</param>
    public void PlaySe(int index)
    {
        index = Mathf.Clamp(index, 0, se.Length);

        seAudioSource.PlayOneShot(se[index], SeVolume * Volume);
    }

    /// <summary>
    /// 
    /// 　SEを再生させる関数
    /// 上記の関数をStringでアクセスする
    /// 
    /// </summary>
    /// <param name="name">SEファイルのString変数</param>
    public void PlaySeByName(string name)
    {

        PlaySe(GetSeIndex(name));
    }

    /// <summary>
    /// 
    /// 　SEの停止関数
    /// 
    /// </summary>
    public void StopSe()
    {
        seAudioSource.Stop();
        seAudioSource.clip = null;
    }
}