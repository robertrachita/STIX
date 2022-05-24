using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aspose.Cells;

namespace Stix.Pages
{
    public class ImportModel : PageModel
    {
        [BindProperty]
        public IFormFile? ExcelFile { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Check if file upload was successful
            if(ExcelFile != null)
            {
                try
                {
                    // Get and store the name with and without the extension of the imported file
                    var fileNameWithExtension = Path.GetFileName(ExcelFile.FileName);
                    var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(ExcelFile.FileName);

                    // Create a Workbook object based on the imported file of type EXCEL(.xlsx)
                    // Display successful conversion and save message with the file name in console
                    /* {TO DO}: MAKE IMPORT GLOBAL(NOT LOCAL DIRECTORY) */
                    var workBook = new Workbook(fileNameWithoutExtension + ".xlsx");
                    workBook.Save("Output.json");
                    ViewData["ConvertedToJson"] = string.Format("Successfuly converted {0} and saved file to a JSON file", fileNameWithExtension);

                    // Release resources
                    // Reset file variable value
                    workBook.Dispose();
                    ExcelFile = null;
                }
                catch (FileNotFoundException e)
                {
                    // Display FileNotFoundException message in alert box
                    // Display FileNotFoundException error in console
                    // Reload current page
                    ViewData["Message"] = string.Format("Could not find file or wrong file format. Please try again!");
                    ViewData["Error"] = string.Format("Could not find file {0}", e);
                    return Page();
                }

                // Display message of succeeding in alert box
                // Reload current page
                ViewData["Message"] = string.Format("Successfuly submmitted for review!");
                return Page();
            }

            // Display message if file upload was unsuccessful in alert box
            // Reload current page
            ViewData["Message"] = string.Format("Something went wrong, please try again!");
            return Page();
        }
    }
}
