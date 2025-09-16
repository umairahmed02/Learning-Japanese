namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GeneratorWithinRange()
        {
            //Arrange
            Random random = new Random();
            int difficulty = 13;
            int lowerLimit = 36;
            int higherLimit = 41;
            List<int> results = new List<int>();

            //Act
            for(int i = 0; i < difficulty; i++)
            {
                results.Add(random.Next(6 + ((difficulty - 1) / 2) * 5, 6 + ((difficulty + 1) / 2) * 5));
            }

            //Assert
            for(int i = 0; i < results.Count; i++)
            {
                Assert.IsTrue(results[i] >= lowerLimit && results[i] <= higherLimit, "Character generated out of range");
            }
        }
    }
} 