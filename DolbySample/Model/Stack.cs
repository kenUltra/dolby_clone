namespace DolbySample.Model;

public class Stack
{
    public required int id { get; set; }
    public required bool hasImage { get; set; }
    public required string title { get; set; }

    public string? subtitle { get; set; } = "";
    public string? notice { get; set; } = "";
    public string? pOne { get; set; } = "";
    public string? pSecond { get; set; } = "";
    public string? cover { get; set; } = "";
}
