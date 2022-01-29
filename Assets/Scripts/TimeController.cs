using UnityEngine;

[System.Serializable]
public class TimeController
{
    [SerializeField] DebugUIOperation _DebugUIOpe;
    [SerializeField] GameObject _lightObj;
    [SerializeField] float _timeRate = 30.0f;
    [SerializeField] float _timespeed;
    [SerializeField] float _scrollRate = 10.0f;
    private float _scroll = 0f;
    float _totalTime;
    float _convert_Time_to_Day = 360.0f;
    public void Start()
    {
        _lightObj = GameObject.Find("Directional Light");//ƒ‰ƒCƒg‚Ì“ü‚ê–Y‚ê–hŽ~
    }

    public void Update()
    {
        float click_time_flo = 0.0f;
        if (Input.GetMouseButtonDown(0)) { click_time_flo = _timeRate; }
        _scroll = Mathf.Sqrt(Input.mouseScrollDelta.y * Input.mouseScrollDelta.y) * _scrollRate;
        float time_now_frame = _timespeed * Time.deltaTime + _scroll + click_time_flo;
        _totalTime += time_now_frame;
        _lightObj.transform.Rotate(new Vector3(time_now_frame, 0, 0));

        _DebugUIOpe.View_flo(_totalTime * (1.0f / _convert_Time_to_Day));
    }
}