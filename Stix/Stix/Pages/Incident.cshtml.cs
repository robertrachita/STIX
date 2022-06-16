using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aspose.Cells;
using Stix.Models;

namespace Stix.Pages
{
    public class IncidentModel : PageModel
    {
        [BindProperty]
        public Models.Incident Incident { get; set; }

        private readonly ILogger<IncidentModel> _logger;

        public IncidentModel(ILogger<IncidentModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", new CultureInfo("en-NL"));
            /* {TO DO}: Uncomment this when API is implemented */
            //ViewData["IncidentName"] = Incident.Name;
            //ViewData["IncidentDate"] = Incident.Date;
            //ViewData["IncidentAdded"] = Incident.AddedDate;
            //ViewData["IncidentSource"] = Incident.Source;
            ViewData["IncidentName"] = "Example Incident";
            ViewData["IncidentDate"] = dateTime;
            ViewData["IncidentAdded"] = dateTime;
            ViewData["IncidentSource"] = "https://www.definitely-a-valid-source.com/incident";
        }

        [BindProperty]
        public string FileFormatType { get; set; }

        [BindProperty]
        public string FileLocation { get; set; }

        public IActionResult OnPost()
        {
            ViewData["yes"] = FileLocation;
            // {TO DO} Add try-catch blocks

            // Store file format based on selected option
            var format = Request.Form["file-formats"];

            // Create spreadsheet
            // Insert incident information in spreadsheet
            // {TO DO} CHANGE THIS TO INSERT VARIABLES INSTEAD OF HARD CODED STRINGS
            Workbook addIncidentInfoToExcelSpreadSheet()
            {
                Workbook workBook = new Workbook();

                Worksheet workSheet = workBook.Worksheets[0];

                Cell incidentNameCell = workSheet.Cells["A1"];
                incidentNameCell.PutValue("Incident name");

                Cell incidentDateCell = workSheet.Cells["B1"];
                incidentDateCell.PutValue("Incident date " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", new CultureInfo("en-NL")));

                Cell incidentAddedDateCell = workSheet.Cells["C1"];
                incidentAddedDateCell.PutValue("Incident added date " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", new CultureInfo("en-NL")));

                Cell incidentSourceCell = workSheet.Cells["D1"];
                incidentSourceCell.PutValue("Incident source");

                return workBook;
            }

            // Save filled in file in the selected format
            void saveWorkBook(Workbook filledInFile)
            {
                filledInFile.Save("D:\\Incident" + "." + format);
            }

            // Check if format is not null (If post was successful)
            // {TO DO} CHANGE THIS TO ANOTHER CHECK LIKE IN LOGIN
            if (format != "")
            {
                saveWorkBook(addIncidentInfoToExcelSpreadSheet());

                return Page();
            }

            return Page();
        }
    }
}