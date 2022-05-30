using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Stix.Pages
{
    public class FilterModel : PageModel
    {
        public List<string> checkList { get; set; }  
        public void OnGet()
        {
        }

        public void onPost()
        {
            
        }
    }
}
