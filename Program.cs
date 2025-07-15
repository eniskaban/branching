using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Display welcome message
                Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

                // Get and validate package weight
                Console.WriteLine("Please enter the package weight:");
                string weightInput = Console.ReadLine();
                if (!float.TryParse(weightInput, out float weight))
                {
                    Console.WriteLine("Invalid weight input. Please enter a valid number.");
                    return;
                }

                // Check if package is too heavy
                if (weight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    return;
                }

                // Get and validate package dimensions
                float width, height, length;

                Console.WriteLine("Please enter the package width:");
                if (!float.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Invalid width input. Please enter a valid number.");
                    return;
                }

                Console.WriteLine("Please enter the package height:");
                if (!float.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Invalid height input. Please enter a valid number.");
                    return;
                }

                Console.WriteLine("Please enter the package length:");
                if (!float.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Invalid length input. Please enter a valid number.");
                    return;
                }

                // Validate dimensions are positive
                if (width <= 0 || height <= 0 || length <= 0)
                {
                    Console.WriteLine("All dimensions must be positive numbers.");
                    return;
                }

                // Check if package dimensions are too big
                float totalDimensions = width + height + length;
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    return;
                }

                // Calculate shipping quote
                float quote = (height * width * length * weight) / 100;

                // Display quote to user with proper currency formatting
                Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
                Console.WriteLine("Thank you!");
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                Console.WriteLine("An error occurred while processing your request.");
                Console.WriteLine($"Error details: {ex.Message}");
            }
        }
    }
}