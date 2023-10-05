using FacadeLibrary.Model;

namespace FacadeLibrary
{
    public class HotelReception
    {
        public void GetIndianMenu()
        {
            IHotel indHotel= new IndianHotel();
            IMenu menu=indHotel.GetMenu();
            menu.DisplayMenu();
        }
        public void GetItalianMenu()
        {
            IHotel itaHotel = new ItalianHotel();
            IMenu menu = itaHotel.GetMenu();
            menu.DisplayMenu();
        }
        public void GetChineseMenu()
        {
            IHotel chinHotel = new ChineseHotel();
            IMenu menu = chinHotel.GetMenu();
            menu.DisplayMenu();
        }
    }
}