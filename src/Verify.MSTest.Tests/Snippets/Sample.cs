#region SampleTestMSTest

[TestClass]
public partial class Sample
{
    [TestMethod]
    public Task Test()
    {
        var person = ClassBeingTested.FindPerson();
        return Verify(person);
    }
}

#endregion