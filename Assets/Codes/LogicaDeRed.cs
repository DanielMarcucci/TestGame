using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LogicaDeRed : MonoBehaviourPunCallbacks
{
    public static LogicaDeRed instancia;

    private void Awake()
    {
        instancia = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Felicidades estas conectado");
    }
}
