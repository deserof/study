namespace lab8.Utils
{
    public static class Validation
    {
        public static bool IsEmptyOrDefaultString(params TextBox[] values)
        {
            foreach (var value in values)
            {
                if (value.ReadOnly)
                {
                    continue;
                }

                if (value.Text == string.Empty)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsNotNumber(params TextBox[] values)
        {
            foreach (var value in values)
            {
                if (value.ReadOnly)
                {
                    continue;
                }

                if (!int.TryParse(value.Text, out _))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsNegativeNumber(params TextBox[] values)
        {
            foreach (var value in values)
            {
                if (value.ReadOnly)
                {
                    continue;
                }

                if (int.TryParse(value.Text, out var number))
                {
                    if (number < 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool IsBetween(TextBox value, int first, int second)
        {
            

            return false;
        }
    }
}
