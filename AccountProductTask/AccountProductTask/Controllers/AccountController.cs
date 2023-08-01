using AccountProductTask.Models;
using AccountProductTask.Services;
using AccountProductTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProductTask.Controllers
{
    public class AccountController
    {
        private readonly IAccountService _accountService;
        private readonly IProductService _productService;
        public AccountController()
        {
            _accountService = new AccountService();
            _productService = new ProductService();
        }

      

        public void GetProductByLogin()
        {
            var users = _accountService.GetAll();
            int option;


           Email: Console.WriteLine("Add your email");
            string email = Console.ReadLine();

            Console.WriteLine("Add your password");
            string password = Console.ReadLine();

            if (Login(email,password))
            {
               Choose: Console.WriteLine("You have 2 options: 1 for All products 2 for search");
            Option: bool isOption = int.TryParse(Console.ReadLine(), out option);
                if (isOption && option ==1 || option ==2)
                {
                    if (option == 1)
                    {
                        var products = _productService.GetAll();
                        foreach (var product in products)
                        {
                            Console.WriteLine(product.Name + ", " + product.Price + ", " + product.Count);
                        }
                        goto Choose;
                    }

                    else if (option == 2)
                    {
                        SearchText:  Console.WriteLine("Enter search text");
                        string searchText = Console.ReadLine();

                        if (searchText == string.Empty)
                        {
                            Console.WriteLine("You must write something");
                            goto SearchText;
                        }
                        
                        var searchProducts = SearchByText(searchText);

                        if (SearchByText(searchText)!=null)
                        {
                            foreach (var product in searchProducts)
                            {
                                Console.WriteLine(product.Name + ", " + product.Price + ", " + product.Count);
                            }
                        }

                        else
                        {
                            Console.WriteLine("Product not found");
                        }
                      
                    }
                }
                else
                {
                    Console.WriteLine("choose correct option");
                    goto Option;
                }
            }
            else
            {
                Console.WriteLine("Email or password is wrong");
                goto Email;
            }



            


        }


        public bool Login(string email, string password)
        {
            var users = _accountService.GetAll();

            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Product> SearchByText(string searchText)
        {
            var products = _productService.GetAll();

            foreach (var product in products)
            {
                if (product.Name.Trim().ToLower().Contains(searchText.Trim().ToLower()))
                {
                    return products.FindAll(m=>m.Name.Contains(searchText));
                }
            }

            return null ;
        }
    }
}
