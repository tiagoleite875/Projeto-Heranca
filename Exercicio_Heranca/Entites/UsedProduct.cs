using System.Globalization;

namespace Exercicio_Heranca.Entites
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price,DateTime manufatureDate)
            :base(name,price)
        {
            ManufactureDate = manufatureDate;
        }
        public override string PriceTag()
        {
            return Name
                + "(Used) $ "
                + Price.ToString("f2",CultureInfo.InvariantCulture)
                + "( Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + " ) ";
        }
    }
}
