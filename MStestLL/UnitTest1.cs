using LinkedListStack.LinkedListFile;
namespace MStestLL
{
    [TestClass]
    public class UnitTest1
    {
        LinkedList linkedList = new LinkedList();
        [TestMethod]
        public void GivenSearchDeleteIndex_WhenAnalysed_ShouldReturnSerachDeleteIndex()
        {
            int result = linkedList.MsTestSearchDelete(30);
            Assert.AreEqual(-1, result);
        }
    }
}