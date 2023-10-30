using CovarianteEControvariante;

namespace CovarianteEControvarianteTests;
public class MurrinoTransformerTests
{
    [Fact]
    public void MurrinoShouldHaveTheSameNameOfTransformee()
    {
        // Arrange:
        Dog joy = new("Joy",13);
        MurrinoTransformer murrinoTransformer = new();

        // Act:
        var murrino = murrinoTransformer.Transform(joy);

        // Assert:
        Assert.Equal(murrino.Name, joy.Name);
    }

    [Fact]
    public void MurrinoShouldBeAMurrino()
    {
        // Arrange:
        Dog joy = new("Joy",13);
        MurrinoTransformer murrinoTransformer = new();

        // Act:
        var murrino = murrinoTransformer.Transform(joy);

        // Assert:
        Assert.IsAssignableFrom<Animal>(murrino);
    }


}