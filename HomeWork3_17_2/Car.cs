using System.Drawing;

namespace HomeWork3_17_2;

public class Car {
    public long Id { get; set; } // meant to be unique identifier
    public string Brand { get; set; }
    public string Model { get; set; }
    public int ProductionYear { get; set; }
    public Color Color { get; set; }
}
