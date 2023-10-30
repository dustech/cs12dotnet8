using CovarianteEControvariante;
using System.ComponentModel.DataAnnotations;

namespace CovarianteEControvarianteTests;

public class AnimalTests
{
  [Fact(DisplayName = "AnimalMassShouldBeNotNegative")]
  public void AnimalMassShouldBeNotNegative()
  {
    // Arrange:
    // Dog joy = new("Joy", 13);
    // Act:
    // var context = new ValidationContext(joy);
    // var validationResults = new List<ValidationResult>();
    // var res = Validator.TryValidateObject(joy, context, validationResults, true);


    // Assert:
    Assert.Throws<ArgumentOutOfRangeException>(() => new Dog("Joy", -5));
  }
}
