using CustomerForm.Core;
using CustomerForm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerForm.Pages.Customers
{
    public class ContactFormModel : PageModel
    {
        public readonly ICustommerData customerData;
        private readonly IHtmlHelper htmlHelper;

        

        [BindProperty]
        public Customer Customer { get; set; }

        public ContactFormModel(ICustommerData customerData, IHtmlHelper htmlHelper)
        {
            Console.WriteLine("Vleznah");
            this.customerData = customerData;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int? customerId)
        {
            if (customerId.HasValue)
            {
                Customer = customerData.GetById(customerId.Value);
            }
            else
            {
                Customer = new Customer();
            }

            if (Customer == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Customer.Id = customerData.GetCount() + 1;
            if (Customer.Country.Equals("0"))
            {
                Customer.Country = "Bulgaria";
            }else if (Customer.Country.Equals("1"))
            {
                Customer.Country = "Spain";
            }
            else
            {
                Customer.Country = "USA";
            }


            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {

                customerData.AddCustomer(Customer);

                customerData.Commit();
               TempData["Message"] = "Custommer saved!";
                return Redirect("https://localhost:7030/");
            }
        }
    }
}
