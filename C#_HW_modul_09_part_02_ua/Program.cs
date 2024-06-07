namespace C__HW_modul_09_part_02_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var getColorRGB = delegate (string color)
                    {
                        switch (color.ToLower())
                        {
                            case "red":
                                Console.WriteLine("RGB for red: (255, 0, 0)");
                                break;
                            case "orange":
                                Console.WriteLine("RGB for orange: (255, 165, 0)");
                                break;
                            case "yellow":
                                Console.WriteLine("RGB for yellow: (255, 255, 0)");
                                break;
                            case "green":
                                Console.WriteLine("RGB for green: (0, 128, 0)");
                                break;
                            case "blue":
                                Console.WriteLine("RGB for blue: (0, 0, 255)");
                                break;
                            case "indigo":
                                Console.WriteLine("RGB for indigo: (75, 0, 130)");
                                break;
                            case "violet":
                                Console.WriteLine("RGB for violet: (238, 130, 238)");
                                break;
                            default:
                                Console.WriteLine($"Color {color} not found in the rainbow.");
                                break;
                        }
                    };


                    getColorRGB("red");
                    getColorRGB("blue");
                    getColorRGB("black");
                    break;
                case 2:
                    var myBackpack = new Backpack
                    {
                        Color = "Black",
                        Brand = "North Face",
                        Material = "Polyester",
                        Weight = 2.5,
                        Volume = 30.0
                    };


                    myBackpack.ItemAdded += delegate (object sender, ItemEventArgs e)
                    {
                        Console.WriteLine($"Added item: {e.Item.Name}, Volume: {e.Item.Volume}");
                    };


                    try
                    {
                        myBackpack.AddItem(new Item { Name = "Laptop", Volume = 5.0 });
                        myBackpack.AddItem(new Item { Name = "Water Bottle", Volume = 1.0 });
                        myBackpack.AddItem(new Item { Name = "Books", Volume = 10.0 });

                        myBackpack.AddItem(new Item { Name = "Shoes", Volume = 7.0 });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                case 3:
                    int[] numbers = { 7, 14, 21, 22, 28, 35, 36, 42 };

                    var countMultiplesOfSeven = (int[] arr) => arr.Count(num => num % 7 == 0);

                    int count = countMultiplesOfSeven(numbers);
                    Console.WriteLine($"Number of multiples of seven: {count}");
                    break;
                case 4:
                    int[] numbers1 = { 7, 14, 21, 22, 28, 35, 36, 42 };

                    var countPositiveNumbers = (int[] arr) => arr.Count(num => num > 0);

                    count = countPositiveNumbers(numbers1);
                    Console.WriteLine($"Number of positive numbers: {count}");
                    break;
                case 5:
                    int[] numbers2 = { -1, -7, -7, 14, -21, 22, -28, -35, 36, -42, -42 };

                    var uniqueNegativeNumbers = (int[] arr) => arr.Where(num => num < 0).Distinct().ToArray();

                    int[] uniqueNegatives = uniqueNegativeNumbers(numbers2);
                    Console.WriteLine("Unique negative numbers: " + string.Join(", ", uniqueNegatives));
                    break;
                case 6:
                    string text = "The quick brown fox jumps over the lazy dog.";
                    string checkWord = "fox";

                    var checkForWord = (string input, string word) => input.Contains(word);

                    bool containsWord = checkForWord(text, checkWord);
                    Console.WriteLine($"Text contains the word '{checkWord}': {containsWord}");
                    break;
            }
        }
    }
}
