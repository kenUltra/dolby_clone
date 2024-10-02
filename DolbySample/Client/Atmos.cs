using DolbySample.Model;

namespace DolbySample.Client;

public class Atmos
{
    private IntroModel atomsDef = new(){
        title = "Dive into sound reimagined with Dolby Atmos",
        subtitle = "Revealing depth, clarity, and details like never before, Dolby Atmos is a sound experience you can feel all around you.",
        urlBackground = "/Assets/Atmos/visualizer-cornerText.webm",
        isVideo = true
    };
    private Stack atmosDetail = new (){
        id = 1,
        title = "What is Dolby Atmos?",
        notice = "Dolby Innovations",
        pOne = "Dolby Atmos has reinvented how entertainment is created and experienced, allowing creatives everywhere to place each sound exactly where they want it to go, for a more realistic and immersive audio experience.",
        pSecond = "Whether you’re gaming, watching your favorite movie or show, or listening to that new track on repeat, Dolby Atmos transports you into a spatial sound experience that draws you in deeper, so you hear more and feel more.",
        cover = "/Assets/Atmos/ambientvideo_naturesfury_v02.webm",
        hasImage = false
    };
    public IntroModel getMain(){
        return atomsDef;
    }
    public Stack getDetailAtmos(){
        return atmosDetail;
    }
}
