
using AccountProductTask.Controllers;

AccountController accountController = new AccountController();



accountController.GetProductByLogin();




//public void Login()
//{
//    var users = _accountService.GetAll();
//    int option;


//Email: Console.WriteLine("Add your email");
//    string email = Console.ReadLine();

//    Console.WriteLine("Add your password");
//    string password = Console.ReadLine();

//    if (_accountService.Login(email, password))
//    {
//    Choose: Console.WriteLine("You have 2 options: 1 for All products 2 for search");
//    Option: bool isOption = int.TryParse(Console.ReadLine(), out option);
//        if (isOption && option == 1 || option == 2)
//        {
//            if (option == 1)
//            {
//                var products = _productService.GetAll();
//                foreach (var product in products)
//                {
//                    Console.WriteLine(product.Name + ", " + product.Price + ", " + product.Count);
//                }
//                goto Choose;
//            }

//            else if (option == 2)
//            {
//            SearchText: Console.WriteLine("Enter search text");
//                string searchText = Console.ReadLine();

//                if (searchText == string.Empty)
//                {
//                    Console.WriteLine("You must write something");
//                    goto SearchText;
//                }

//                var searchProducts = SearchByText(searchText);

//                if (SearchByText(searchText) != null)
//                {
//                    foreach (var product in searchProducts)
//                    {
//                        Console.WriteLine(product.Name + ", " + product.Price + ", " + product.Count);
//                    }
//                }

//                else
//                {
//                    Console.WriteLine("Product not found");
//                }

//            }
//        }
//        else
//        {
//            Console.WriteLine("choose correct option");
//            goto Option;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Email or password is wrong");
//        goto Email;
//    }


//}
