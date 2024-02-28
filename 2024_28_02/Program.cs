


using _2024_28_02;
using _2024_28_02.Data;
using _2024_28_02.Models;

Product_Data pd = new Product_Data();
Brand_Data bd = new Brand_Data();


string opt;
do
{

    Console.WriteLine("\n---- Main Menu ----\n");
    Console.WriteLine("a. Brand Menu");
    Console.WriteLine("b. Product Menu");
    Console.WriteLine("c. Exit");

    Console.WriteLine("Select Operation");
    opt = Console.ReadLine();

    

    switch (opt)
    {
        case "a":
            string opt_a;
            do
            {
                Console.WriteLine("---- Brand Menu ----");
                Console.WriteLine("1. Add Brand");
                Console.WriteLine("2. Get Brand By Id");
                Console.WriteLine("3. Get All Brands");
                Console.WriteLine("4. Delete Brand");
                Console.WriteLine("5. Update Brand By Id");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Select Option:");
                opt_a = Console.ReadLine();

                switch (opt_a)
                {
                    case "1":
                        string name;
                        do
                        {
                            Console.WriteLine("Name:");
                            name = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(name));
                        Brand brand = new Brand
                        {
                            Name = name
                        };
                        bd.InsertBrand(brand);
                        break;
                    case "2":
                        string idStr;
                        int id;
                        do
                        {
                            Console.WriteLine("Id: ");
                            idStr = Console.ReadLine();
                        } while (!int.TryParse(idStr, out id) || id<0);

                        if (bd.GetBrandById(id)!=null)
                        {
                            Console.WriteLine(bd.GetBrandById(id));
                        }
                        else
                        {
                            Console.WriteLine("Id Not Found!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("All Brands: \n");
                        foreach (var item in bd.GetAllBrands())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Id: ");
                            idStr = Console.ReadLine();
                        } while (!int.TryParse(idStr, out id) || id < 0);
                        bd.DeleteBrand(id);
                        break;
                    case "5":
                        do
                        {
                            Console.WriteLine("Id: ");
                            idStr = Console.ReadLine();
                        } while (!int.TryParse(idStr, out id) || id < 0);
                        bd.UpdateBrand(id);
                        break;
                    case "0":
                        Console.WriteLine("Brand Menu -> Finished");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (opt_a != "0");
            break;
        case "b":
            string opt_b;
            do
            {
                Console.WriteLine("---- Product Menu ----");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Get Product By Id");
                Console.WriteLine("3. Get All Products");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Update Product By Id");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Select Option:");
                opt_b = Console.ReadLine();

                switch (opt_b)
                {
                    case "1":
                        string name;
                        do
                        {
                            Console.WriteLine("Name:");
                            name = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(name));

                        string priceStr;
                        decimal price;
                        do
                        {
                            Console.WriteLine("Price: ");
                            priceStr = Console.ReadLine();
                        } while (!decimal.TryParse(priceStr, out price) || price<0);

                        string brandIdStr;
                        int brandId;
                        do
                        {
                            Console.WriteLine("BrandId: ");
                            brandIdStr = Console.ReadLine();
                        } while (!int.TryParse(brandIdStr, out brandId) || brandId<0);

                        Product product = new Product
                        {
                            Name = name,
                            Price = price,
                            BrandId = brandId
                        };
                        pd.InsertProduct(product);
                        break;
                    case "2":
                        string idStr;
                        int id;
                        do
                        {
                            Console.WriteLine("Id: ");
                            idStr = Console.ReadLine();
                        } while (!int.TryParse(idStr, out id) || id < 0);
                        pd.GetProductById(id);
                        break;
                    case "3":
                        Console.WriteLine("All Products: \n");
                        foreach (var item in pd.GetAllProducts())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "0":
                        Console.WriteLine("Product Menu -> Finished");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (opt_b != "0");
            break;
        case "c":
            Console.WriteLine("Finished!");
            break;
        default:
            Console.WriteLine("Invalid Choice!");
            break;
    }

    
} while (opt!="c");