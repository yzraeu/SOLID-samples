using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.samples.SRP.Solution
{
    class ClientRepository
    {
        public bool Add(Client client)
        {
            // Persist Data
            using (var cn = new SqlConnection("cnString"))
            {
                var cmd = new SqlCommand("INSERT INTO clients(Name, Email, DateOfBirth) VALUES(@Name, @Email, @DateOfBirth)", cn);

                cmd.Parameters.AddWithValue("Name", client.Name);
                cmd.Parameters.AddWithValue("Email", client.Email);
                cmd.Parameters.AddWithValue("DateOfBirth", client.DateOfBirth);

                cmd.ExecuteNonQuery();
            }

            return true;
        }
    }
}
