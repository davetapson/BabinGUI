using System.Globalization;

namespace BabinGUI.BL.utils
{
    public static class Utils
    {
        public static string FormatStringToCurrency(string netLiquidation)
        {
            decimal value;
            bool result = decimal.TryParse(netLiquidation, NumberStyles.Any, CultureInfo.InvariantCulture, out value);

            return string.Format("{0:N2}", value);
        }
    }
}
