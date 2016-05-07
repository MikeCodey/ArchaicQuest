﻿namespace MIMEngine.Core.Events
{
    using System.Text;

    using PlayerSetup;

    class Score
    {

        public static void ReturnScore(PlayerSetup playerData)
        {
            string scoreTest = "Score:\r\n Name: " + playerData.Name + " Race: " + playerData.Race;



           HubProxy.MimHubServer.Invoke("SendToClient", scoreTest);

        }
    }
}
