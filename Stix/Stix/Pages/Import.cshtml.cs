using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aspose.Cells;

namespace Stix.Pages
{
    public class ImportModel : PageModel
    {
        [BindProperty]
        public IFormFile ExcelFile { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ExcelFile != null)
            {
                var fileName = Path.GetFileName(ExcelFile.FileName);
                var workBook = new Workbook("input.xlsx");
                workBook.Save("Output.json");
                return RedirectToPage("Index");

            }

            return Page();
        }
    }
}
