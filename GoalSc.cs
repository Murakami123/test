using UnityEngine;
using System.Collections;

public class GoalSc : MonoBehaviour {

    public string Syousya;

    // Use this for initialization
    void Start () {
        Syousya = "";
        Debug.Log("スタートしました！");
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Player" && Syousya == "") {
            Syousya = col.gameObject.name;
            Debug.Log("優勝は" + Syousya + "ちゃんです！");
        }
    }
}
