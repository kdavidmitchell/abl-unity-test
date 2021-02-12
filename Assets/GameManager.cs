using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WME;

public class GameManager : MonoBehaviour
{
    // The prefab associated with a bot.
    public GameObject botPrefab;
    // The gameobject associated with the player.
    public GameObject player;
    protected GameManager() {}
    // A reference to this manager.
    private static GameManager _instance = null;
    // Current position of the player.
    private Vector3 _playerPos = Vector3.zero;
    // Position of the chaser agent.
    private Vector3 _chaserPos = Vector3.zero;
    // A list of all active bots.
    private List<Bot> _bots = new List<Bot>();
    // Speed of all bots
    private static float _botSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the bot.
        _initBot();
    }

    // Update is called once per frame
    void Update()
    {
        // Update player position.
        _updatePlayerPos();
        // Update bot positions.
        _updateBotPos();
    }

    // Initializes the default bot.
    private void _initBot() {
        // Offset y by 1 to account for floor height, offset x by 2 to leave some space for player.
        Vector3 start = new Vector3(2, 1, 0);
        // Spawn a botPrefab that will be associated with this bot instance.
        GameObject bot = Instantiate(botPrefab, start, Quaternion.identity);
        // Set position in bot instance.
        Bot bot_instance = bot.GetComponent<Bot>();
        bot_instance.Position = start;
        // Add this new bot to the list of all bots.
        _bots.Add(bot_instance);
    }

    // Using reference to player, update player position.
    private void _updatePlayerPos() {
        PlayerPos = player.transform.position;
    }

    // Using list of bots, update the positions of bots.
    private void _updateBotPos() {
        foreach (Bot b in Bots) {
            b.Position = b.gameObject.transform.position;
        }
    }

    // Generate an ABL WME based upon request.
    private WMEResponse _generateWME(WMERequest req) {
        WMEResponse res = new WMEResponse();
        if (req.Type == 0) {
            WME.WME playerWME = new WME.WME {
                Type = WME.WME.Types.Type.Player,
                X = PlayerPos.x,
                Y = PlayerPos.y,
                Z = PlayerPos.z,
            };
            res.Wmes.Add(playerWME);
        } else {
            foreach (Bot b in Bots) {
                WME.WME botWME = new WME.WME {
                    Type = WME.WME.Types.Type.Bot,
                    X = b.Position.x,
                    Y = b.Position.y,
                    Z = b.Position.z,
                    Id = b.Id,
                };
                res.Wmes.Add(botWME);
            }
        }
        return res;
    }

    // Singleton implementation for this manager.
    public static GameManager Instance {
        get {
            if (GameManager._instance == null) {
                GameManager._instance = new GameManager();
            }  
            return GameManager._instance;
        }
    }

    public Vector3 PlayerPos {
        get { return this._playerPos; }
        set { this._playerPos = value; }
    }

    public Vector3 ChaserPos {
        get { return this._chaserPos; }
        set { this._chaserPos = value; }
    }

    public List<Bot> Bots {
        get { return this._bots; }
    } 
}
