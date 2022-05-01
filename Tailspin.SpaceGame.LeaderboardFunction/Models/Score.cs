using System.Text.Json.Serialization;

namespace TailSpin.SpaceGame.LeaderboardFunction
{
    public class Score : Model
    {
        // The ID of the player profile associated with this score.
        [JsonPropertyName("ProfileId")]
        public string ProfileId { get; set; }

        // The score value.
        [JsonPropertyName("Score")]
        public int HighScore { get; set; }

        // The game mode the score is associated with.
        [JsonPropertyName("GameMode")]
        public string GameMode { get; set; }

        // The game region (map) the score is associated with.
        [JsonPropertyName("GameRegion")]
        public string GameRegion { get; set; }
    }
}
