namespace MB06.A11_1._4
{
    class Product
    {
        #region Fields
        private string name;
        private double purchasingPrice;
        private double retailPrice;
        #endregion

        private const string currency = "sFr.";

        #region Constructors
        public Product(string name, double purchasingPrice, double retailPrice)
        {
            Name = name;
            PurchasingPrice = purchasingPrice;
            RetailPrice = retailPrice;
        }
        #endregion

        #region Property-Methods
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    name = value;
                }
            }
        }
        public double PurchasingPrice
        {
            get { return purchasingPrice; }
            set
            {
                if (value > 0)
                {
                    purchasingPrice = value;
                }
            }
        }

        public double RetailPrice
        {
            get { return retailPrice; }

            set
            {
                if (value > 0)
                {
                    retailPrice = value;
                }
            }
        }
        #endregion

        public string ShowValue()
        {
            return Name + ", VP: " + PurchasingPrice + " " + currency +
                ", EP: " + RetailPrice + " " + currency;
        }
    }
}