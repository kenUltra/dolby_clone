using DolbySample.Model;

namespace DolbySample.Client;

public class Dolby
{
    private readonly string[] allTitle = [
        "Music comes alive in Dolby", 
        "Immersive experience in Dolby", 
        "Love gaming more in Dolby"
    ];

    private readonly List<LoopVideo> getVideoStack = [
        new() { 
            VideoLink = "/Assets/download/anyma_ambient_music.mp4", 
            VideoTitle = "Music",
            typeVideo = "video/mp4"
        },
        new() {
            VideoLink = "/Assets/download/halo_ambient_landscape.webm",
            VideoTitle = "Gaming",
            typeVideo = "video/webm"
        },
        new() {
            VideoLink = "/Assets/download/dune_homepage_ambient.webm",
            VideoTitle = "Movie & Tv",
            typeVideo = "video/webm"
        }
    ];

    public string SelectedValue(string value) {
        string res = value switch {
            "Gaming" => allTitle[1],
            "Movie & Tv" => allTitle[2],
            _ => allTitle[0]
        };
        return res;
    }
    public string GetCover(string value) {
        string main = value switch {
            "Gaming" => getVideoStack[1].VideoLink,
            "Movie & Tv" => getVideoStack[2].VideoLink,
            _ => getVideoStack[0].VideoLink
        };

        return main;
    }
   
    public LoopVideo[] getVideos() => [.. getVideoStack];
}
