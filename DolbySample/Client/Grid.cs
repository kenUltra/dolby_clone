using DolbySample.Model;

namespace DolbySample.Client;

public class Grid
{
    private readonly List<GridModel> dolbyList = new() {
        new() { 
            title = "Halo Infinite", 
            urlImage = "/Assets/cover/01_halo.jpg",
            nameStack = "halo-box"
        },
        new() {
            title = "What is Dolby Atmos?",
            urlImage = "/Assets/cover/02_atmos.jpg",
            nameStack = "atmos-box"
        },
        new() {
            title = "Dune: Part II  in Dolby Vision and Dolby Atmos",
            urlImage = "/Assets/cover/04_dune.jpg",
            nameStack = "dune-box"
        },
        new() { 
             title =  "Anyma in Dolby Atmos", 
             urlImage = "/Assets/cover/03_anyma.jpg",
             nameStack = "anyma-box"
         },
        new() {
             title = "TVs and Soundbars with Dolby",
             urlImage = "/Assets/cover/06_devices.jpg",
             nameStack = "sound-box"
         },
        new() {
             title =  "What is Dolby Vision?", 
             urlImage = "/Assets/cover/dolbyvision.jpg",
             nameStack = "vision-box"
         },
         new()  {
             title = "Jennifer Lopez in Dolby Atmos", 
             urlImage = "/Assets/cover/07_jlo.webp",
             nameStack = "jennifer-lopez-box"
         },
        new() {
             title = "Ed Sheeran in Dolby Atmos", 
             urlImage = "/Assets/cover/08_ed.jpg",
             nameStack = "ed-sheeran-box"
         },
        new() {
             title =  "Experince Dolby Cinema", 
             urlImage = "Assets/cover/09_cinema.webp",
             nameStack = "cinema-box"
        }
    };
    public GridModel[] getGridList() => [.. dolbyList]; 
}
