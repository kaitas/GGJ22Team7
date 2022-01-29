using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// �@�T�E���h�}�l�[�W���[�N���X
/// ���֌W�̏����p�A�V���O���g���ŊǗ�
/// version1.0(2021-10-24)
/// author TanoueKazuya
/// 
/// </summary>
public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
    [SerializeField, Range(0, 1), Tooltip("�}�X�^����")] float volume = 1;     //�����ʂ̐��l�A�p�[�Z���e�[�W�ŊǗ�
    [SerializeField, Range(0, 1), Tooltip("BGM�̉���")] float bgmVolume = 1;  //BGM���ʂ̐��l�A�p�[�Z���e�[�W�ŊǗ�
    [SerializeField, Range(0, 1), Tooltip("SE�̉���")] float seVolume = 1;   //SE�̐��l�A�p�[�Z���e�[�W�ŊǗ�

    AudioClip[] bgm;    //�SBGM�̊Ǘ��p�z��
    AudioClip[] se;     //�SSE�̊Ǘ��p�z��
    AudioClip Posebgm;


    Dictionary<string, int> bgmIndex = new Dictionary<string, int>();   //BGM��string�Ŏ擾���邽�߂̕ϐ�
    Dictionary<string, int> seIndex = new Dictionary<string, int>();    //SE��string�Ŏ擾���邽�߂̕ϐ�

    AudioSource bgmAudioSource; //BGM���Đ�����p�̕ϐ�
    AudioSource seAudioSource;  //SE���Đ�����p�̕ϐ�

    int BGMint = -1;//BGM���V�[���J�ڂŌp��������p�̕ϐ�


    /// <summary>
    /// 
    /// �@�����ʂ̎擾�֐�
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
    /// �@BGM���ʂ̎擾�֐�
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
    /// �@SE���ʂ̎擾�֐�
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
    /// �@�N�����Ɏ��s�����֐�
    /// 
    /// </summary>
    public void Awake()
    {
        //�V���O���g���p�̏���
        if (this != Instance)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        //AudioSource���擾
        bgmAudioSource = gameObject.AddComponent<AudioSource>();
        seAudioSource = gameObject.AddComponent<AudioSource>();

        //Audio�t�@�C�����ɂ���BGM�ASE�����t�@�C�����擾
        bgm = Resources.LoadAll<AudioClip>("Audio/BGM");
        se = Resources.LoadAll<AudioClip>("Audio/SE");

        //bgmIndex�AseIndex�ɉ����t�@�C������
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
    /// �@bgmIndex���ɂ���BGM�����t�@�C���̎擾
    /// 
    /// </summary>
    /// <param name="name">BGM��</param>
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
    /// �@SEIndex���ɂ���SE�����t�@�C���̎擾
    /// 
    /// </summary>
    /// <param name="name">SE��</param>
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
    /// �@BGM���Đ�������֐�
    /// 
    /// </summary>
    /// <param name="index">BGM�t�@�C���̑I��</param>
    /// <param name="isloop">BGM�����[�v�����邩�̕ϐ�</param>
    public void PlayBgm(int index, bool isloop = true)
    {
        //���ʂ���
        index = Mathf.Clamp(index, 0, bgm.Length);

        //AudioSource�̐ݒ�
        bgmAudioSource.clip = bgm[index];
        bgmAudioSource.loop = isloop;
        bgmAudioSource.volume = BgmVolume * Volume;

        //�J�ڎ��ɓr�؂ꂳ���Ȃ��p�̏���
        if (BGMint != index)
        {
            BGMint = index;
            bgmAudioSource.Play();
        }
    }

    /// <summary>
    /// 
    /// �@BGM���Đ�������֐�
    /// ��L�̊֐���String�ŃA�N�Z�X����
    /// 
    /// </summary>
    /// <param name="name">BGM�t�@�C����String�ϐ�</param>
    /// <param name="isloop">BGM�����[�v�����邩�̕ϐ�</param>
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
    /// �@BGM�̒�~�֐�
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
    /// �@SE���Đ�������֐�
    /// 
    /// </summary>
    /// <param name="index">SE�t�@�C���̑I��</param>
    public void PlaySe(int index)
    {
        index = Mathf.Clamp(index, 0, se.Length);

        seAudioSource.PlayOneShot(se[index], SeVolume * Volume);
    }

    /// <summary>
    /// 
    /// �@SE���Đ�������֐�
    /// ��L�̊֐���String�ŃA�N�Z�X����
    /// 
    /// </summary>
    /// <param name="name">SE�t�@�C����String�ϐ�</param>
    public void PlaySeByName(string name)
    {

        PlaySe(GetSeIndex(name));
    }

    /// <summary>
    /// 
    /// �@SE�̒�~�֐�
    /// 
    /// </summary>
    public void StopSe()
    {
        seAudioSource.Stop();
        seAudioSource.clip = null;
    }
}