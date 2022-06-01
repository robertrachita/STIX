using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Stix.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Stix.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<IncidentsModel> infos = new List<IncidentsModel>();

        [BindProperty (SupportsGet = true)]
        public string searchString { get; set; }

        public string query = "SELECT * FROM incidents";

        public string referenceNumber { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            this.getIncidents(query);
        }

        public void getIncidents(string query)
        {
            try
            {
                string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Chris\\Period 4\\Northwind.mdf';Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if(!string.IsNullOrEmpty(this.searchString))
                        {
                            command.Parameters.AddWithValue("@Name", '%' + this.searchString + '%');
                        }
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IncidentsModel info = new IncidentsModel();
                                info.Id = reader.GetInt32(0);
                                info.Name = reader.GetString(1);
                                info.Description = reader.GetString(2);
                                info.Reference_Number = reader.GetInt32(3);
                                info.Month = reader.GetInt32(4);
                                info.Year = reader.GetInt32(5);

                                infos.Add(info);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }



        /*public void OnGet()
        {
            //string search = Request.Form["search"];
            if (!string.IsNullOrEmpty(searchString))
            {
                this.query = "SELECT * FROM incidents WHERE title LIKE @NAME";
                this.getIncidents(query);
            }
        }*/

        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                this.query = "SELECT * FROM incidents WHERE title LIKE @NAME";
                this.getIncidents(query);
            }
        }

        public void OnPost() 
        { 
            
        }
    }
}