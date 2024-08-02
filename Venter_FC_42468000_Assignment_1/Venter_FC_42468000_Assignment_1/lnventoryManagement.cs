using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Globalization;

namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{

    // Class to contain orderDetails
    public class OrderDetails
    {
        public bool isDrink { get; set; }

        // UserID gets initialised once and stays the same over a session (i.e. all instances of this class);
        public static int userID { get; set; }

        public int productID { get; set; }
        public int quantity { get; set; }
        public decimal subTotal { get; set; }

        public decimal totalAmount { get; set; }
        public bool hasOrdered { get; set; }

        public int saleID { get; set; }

        public OrderDetails(int newuserID)
        {
            userID = newuserID;
            hasOrdered = false;
            totalAmount = 0;
        }

        public int getUserID()
        {
            return userID;
        }

        /*  Method to check if this is the first order the client places
            (Their first order can either be coffee, tea, pastries or sandwiches,
            but all these orders share the same SaleID. (Each individual one is linked
            to SaleItems)). 
            So here we ensure that once they place an order, a SaleID is created 
            (at ProcessOrder) and then that SaleID is continued to be used across all other orders
        */
        public void triggerOrder()
        {
            hasOrdered = true;
        }

        public void setSaleID(int saleID)
        {
            this.saleID = saleID;
        }

        // To be called before processing an order
        public void updateDetails(bool isDrink, int productID, int quantity, decimal subTotal)
        {
            this.isDrink = isDrink;
            this.productID = productID;
            this.quantity = quantity;

            totalAmount += subTotal;
            this.subTotal = subTotal;
        }

        public override string ToString()
        {
            return $"OrderDetails: UserID={userID}, ProductID={productID}, Quantity={quantity}, SubTotal={subTotal}, TotalAmount={totalAmount}, HasOrdered={hasOrdered}, SaleID={saleID}, IsDrink={isDrink}";
        }


    }

    // Container class to manage inventory 
    public static class InventoryManagement
    {
        // Key-Value Dictionary for the addons and their respective prices as they are not a table in the database
        public static Dictionary<string, decimal> Addons { get; } = new Dictionary<string, decimal>
        {
            { "Double", 15m },
            { "Cream", 5m },
            { "Syrup", 7m },
            { "Honey", 8m },
            { "Lemon", 5m },
            { "Milk", 2m },
            { "Cheese", 5m },
            { "Avocado", 8m },
            { "Bacon", 10m }
        };

        // Add 15% to price (rounded to newest integer)
        public static decimal calculateMediumPrice(decimal price)
        {
            return (decimal)((int)((0.15m * price) + price));
        }

        // Add 35% to price (rounded to newest integer)
        public static decimal calculateLargePrice(decimal price)
        {
            return (decimal)((int)((0.35m * price) + price));
        }

        public static int getItemQuantity(string item)
        {
            return Convert.ToInt32(SQL.readSingleValue($"SELECT ItemQuantity FROM Inventory WHERE (InventoryItemName = '{item}')"));
        }

        // Method to validate an addon and return its (individual) price if there is enough stock left 
        public static decimal manageAddon(CheckBox chk, int quantity)
        {
            string addon = chk.Text;

            int stockLeft = getItemQuantity(addon);

            if (stockLeft < quantity)
            {
                MessageBox.Show($"Sorry, but we only have {stockLeft} {addon} left!");
                return 0;
            }

            return Addons[addon];
        }

        public static bool ValidateOrderInput(ComboBox productComboBox, NumericUpDown quantityUpDown)
        {
            if (productComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return false;
            }

            string productType = productComboBox.Text;
            int quantity = (int)quantityUpDown.Value;
            int productsLeft = getItemQuantity(productType);

            if (productsLeft < quantity)
            {
                MessageBox.Show($"Sorry, but we only have {quantity} {productsLeft} left!");
                return false;
            }

            return true;
        }

        public static decimal CalculateAddonPrice(CheckBox addonCheckbox, int quantity)
        {
            if (addonCheckbox.Checked)
            {
                decimal addonPrice = manageAddon(addonCheckbox, quantity);
                if (addonPrice == 0)
                    throw new Exception("Addon price is zero.");

                return addonPrice * quantity;
            }

            return 0; // This will just get added to the total price, which is fine
        }

        public static decimal getDrinkPrice(string productType, string size)
        {

            try
            {
                decimal finalPrice = Convert.ToDecimal(SQL.readSingleValue($"SELECT DrinkPrice FROM Drinks WHERE (DrinkName = '{productType}')"));

                switch (size)
                {
                    case "Large":
                        return calculateLargePrice(finalPrice);
                    case "Medium":
                        return calculateMediumPrice(finalPrice);
                    default:
                        return finalPrice;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show("Error calculating drink price (getDrinkPrice): " + E.Message);
                return 0;
            }
        }


        public static decimal getFoodPrice(string productType)
        {
            try
            {
                return Convert.ToDecimal(SQL.readSingleValue($"SELECT FoodPrice FROM Food WHERE (FoodName = '{productType}')"));
            }
            catch (Exception E)
            {
                MessageBox.Show("Error calculating food price (GetFoodPrice): " + E.Message);
                return 0;
            }
        }

        public static int getDrinkID(string productType)
        {
            return Convert.ToInt32(SQL.readSingleValue($"SELECT DrinkID FROM Drinks WHERE (DrinkName = '{productType}')"));
        }

        public static int getFoodID(string productType)
        {
            return Convert.ToInt32(SQL.readSingleValue($"SELECT FoodID FROM Food WHERE (FoodName = '{productType}')"));
        }

        public static void processItem(string item, int quantity)
        {
            SQL.updateRecord($"UPDATE Inventory SET ItemQuantity = ItemQuantity - {quantity} WHERE InventoryItemName = '{item}'");
        }

        public static void processOrder(OrderDetails currentOrder)
        {
            DateTime date = DateTime.Now;

            // Get static user ID
            int userID = currentOrder.getUserID();

            int productID = currentOrder.productID;
            int quantity = currentOrder.quantity;
            decimal subTotal = currentOrder.subTotal;

            // If this is their first order, create new SaleID
            if (!currentOrder.hasOrdered)
            {
                SQL.insertRecord($"INSERT INTO Sales (UserID, TotalAmount, SaleDate) VALUES  ('{userID}', '{subTotal.ToString(CultureInfo.InvariantCulture)}', '{date}')");
                currentOrder.setSaleID(Convert.ToInt32(SQL.readSingleValue($"SELECT TOP 1 SaleID FROM Sales ORDER BY SaleID DESC")));
            }

            // Set hasOrdered flag to true
            currentOrder.triggerOrder();

            int saleID = currentOrder.saleID;

            // Assign product type
            string idType = currentOrder.isDrink ? "DrinkID" : "FoodID";

            SQL.insertRecord($"INSERT INTO SaleItems (SaleID, {idType}, Quantity, Subtotal) VALUES ({saleID}, {productID}, {quantity}, {subTotal.ToString(CultureInfo.InvariantCulture)})");

        }

        public static void finaliseOrder(OrderDetails currentOrder)
        {
            try
            {
                int saleID = currentOrder.saleID;
                decimal totalAmount = currentOrder.totalAmount;
            
                // Ensure that they have placed at least one order
                if (totalAmount > 0)
                    SQL.updateRecord($"UPDATE SALES SET TotalAmount = {totalAmount.ToString(CultureInfo.InvariantCulture)} WHERE (SaleID = {saleID})");
            }
            catch (Exception E)
            {
                MessageBox.Show("Error: " + E.Message);
            }
        }


    }
}
