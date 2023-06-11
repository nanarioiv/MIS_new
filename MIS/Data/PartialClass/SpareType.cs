
namespace MIS.Data
{
  public  partial class SpareType
    {
        public override string ToString()
        {
            if (SpareType_ID==0)
            {
                return "Все типы мед. изделий";
            }
            return $"{SpareTypeName}";
        }

       
        public override bool Equals(object obj)
        {
            if (obj is SpareType item)
            {
                return item.SpareType_ID == SpareType_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return SpareType_ID;
        }
    }
}
