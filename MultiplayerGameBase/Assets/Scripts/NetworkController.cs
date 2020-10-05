using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class NetworkController : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();       
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("Connected to " + PhotonNetwork.ServerAddress + " in region " + PhotonNetwork.CloudRegion + "server!");
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        SceneManager.LoadSceneAsync("MainGame", LoadSceneMode.Single);
    }
}
