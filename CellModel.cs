namespace Tre_på_rad
{
    public class CellModel
    {
        private int _content;
        //private bool _isEmpty;
        //private bool _isPlayer1;

        public CellModel()
        {
            //_isEmpty = true;
        }

        public bool IsEmpty()
        {
            return _content == 0;
        }

        public bool IsPlayer1()
        {
            return _content == 1;
        }

        public void Mark(bool isPlayer1)
        {
            _content = isPlayer1 ? 1 : 2;
        }
    }
}
