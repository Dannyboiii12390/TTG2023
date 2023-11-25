using Microsoft.Xna.Framework;
using TTG.Classes;

namespace Unit_Tests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void boardGetCellTest1()
        {
            Board board = new Board();
            Vector2 expected = new Vector2(320,320);
            Cell cell = board.GetCell(expected);

            Assert.IsNotNull(cell);
            Assert.AreEqual(expected, cell.Square.position);

        }
        [TestMethod]
        public void boardGetCellTest2()
        {
            Board board = new Board();
            Vector2 expected = new Vector2(320, 320);
            Vector2 target = new Vector2(330,330);
            Cell cell = board.GetCell(target);

            Assert.IsNotNull(cell);
            Assert.AreEqual(expected, cell.Square.position);

        }
    }
}