using LinkedListStack.LinkedListFile;
namespace MStestLL
{
    [TestClass]
    public class UnitTest1
    {
        LinkedList linkedList = new LinkedList();
        [TestMethod]
        public void GivenSearchFirstIndex_WhenAnalysed_ShouldReturnSerachFirstIndex()
        {
            int result = linkedList.MsTestSearch(70);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void GivenSearchSecondIndex_WhenAnalysed_ShouldReturnSerachSecondIndex()
        {
            int result = linkedList.MsTestSearch(30);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void GivenSearchThirdIndex_WhenAnalysed_ShouldReturnSerachThirdIndex()
        {
            int result = linkedList.MsTestSearch(56);
            Assert.AreEqual(0, result);
        }
    }
}