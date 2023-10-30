using CovarianteEControvariante;

namespace CovarianteEControvarianteTests;

public class DogTests
{
  [Fact(DisplayName = "ShouldBark5Times")]
  public void ShouldBark5Times()
  {
    // Arrange:
    Dog joy = new("Joy", 13);
    string barks = "wof wof wof wof wof";
    // Act:
    var joyBarks = joy.Bark(5);

    // Assert:
    Assert.Equal(barks, joyBarks);
  }

  [Fact(DisplayName = "ShouldNotBark")]
  public void ShouldNotBark()
  {
    // Arrange:
    Dog joy = new("Joy", 13);
    string barks = String.Empty;
    // Act:
    var joyBarks = joy.Bark(0);

    // Assert:
    Assert.Equal(barks, joyBarks);
  }

  [Fact(DisplayName = "ShouldNotBarkNegative")]
  public void ShouldNotBarkNegative()
  {
    // Arrange:
    Dog joy = new("Joy", 13);
    string barks = String.Empty;
    // Act:
    var joyBarks = joy.Bark(-1);

    // Assert:
    Assert.Equal(barks, joyBarks);
  }

  [Fact(DisplayName = "JoyIsJoy")]
  public void JoyIsJoy()
  {
    // Arrange:
    Dog joy = new("Joy", 13);
    Dog joy2 = new("Joy", 13);
    // Act:


    // Assert:
    Assert.Equal(joy, joy2);
  }

  [Fact(DisplayName = "JoyIsAxelIfChangeName")]
  public void JoyIsAxelIfChangeName()
  {
    // Arrange:
    Dog joy = new("Joy", 13);

    Dog axel = joy with { Name = "Axel" };
    // Act:


    // Assert:
    Assert.Equal("Axel", axel.Name);
  }

}
