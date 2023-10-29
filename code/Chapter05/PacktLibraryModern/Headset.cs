namespace Packt.Shared;

public class Headset(string manufacturer, string productName)
{
  public string Manufacturer { get; set; } = manufacturer;
  public string ProductName { get; set; } = productName;

  // Default parameterless constructor calls the primary constructor.
  public Headset() : this("Microsoft", "HoloLens") { }
}


public class ImmutableHeadset(string manufacturer, string productName)
{
  public string Manufacturer { get; init; } = manufacturer;
  public string ProductName { get; init; } = productName;

  // Default parameterless constructor calls the primary constructor.
  public ImmutableHeadset() : this("Microsoft", "HoloLens") { }
}