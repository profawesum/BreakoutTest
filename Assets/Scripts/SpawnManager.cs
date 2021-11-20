using UnityEngine;

namespace Mirror
{

    [AddComponentMenu("")]
    public class SpawnManager : NetworkManager
    {
        public Transform leftPlayerSpawn;
        public Transform rightPlayerSpawn;
        GameObject p1Ball;
        GameObject p2Ball;

        public override void OnServerAddPlayer(NetworkConnection conn)
        {
            // add player at correct spawn position
            Transform start = numPlayers == 0 ? leftPlayerSpawn : rightPlayerSpawn;
            GameObject player = Instantiate(playerPrefab, start.position, start.rotation);
            NetworkServer.AddPlayerForConnection(conn, player);

            // spawn ball if two players
            if (numPlayers == 1)
            {
                player.name = "PlayerOne";
                p1Ball = Instantiate(spawnPrefabs.Find(prefab => prefab.name == "Ball"));
                NetworkServer.Spawn(p1Ball);
                p1Ball.name = "p1Ball";
            }
            else {

                
                player.name = "PlayerTwo";
                p2Ball = Instantiate(spawnPrefabs.Find(prefab => prefab.name == "Ball"));
                NetworkServer.Spawn(p2Ball);
                p2Ball.name = "p2Ball";
            }
        }

        public override void OnServerDisconnect(NetworkConnection conn)
        {
            // destroy ball
            if (p1Ball != null)
                NetworkServer.Destroy(p1Ball);
            if (p2Ball != null)
                NetworkServer.Destroy(p2Ball);

            // call base functionality (actually destroys the player)
            base.OnServerDisconnect(conn);
        }
    }
}
