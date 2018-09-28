
namespace Tre_på_rad
{
    class RuteInnhold
    {
        public int _tom;

        public RuteInnhold()
        {
            _tom = 0;
        }

        public bool IsItEmpty()
        {
            return _tom == 0;
        }

        public bool IsPlayer1()
        {
            return _tom == 1;
        }

        public void SetThingAkaXorO(bool player1)
        {
            if (!IsItEmpty()) return;
            _tom = player1 ? 1 : 2;
        }

    }
}
