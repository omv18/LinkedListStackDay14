using LinkedListStack.LinkedListFile;
namespace MStestLL
{
    [TestClass]
    public class UnitTest1
    {
        LinkedList linkedList = new LinkedList();
        [TestMethod]
        public void GivenSearchAddIndex_WhenAnalysed_ShouldReturnSerachAddIndex()
        {
            bool result = linkedList.MsTestSearchAdd(30, 45);
            Assert.AreEqual(true, result);
        }
    }
}