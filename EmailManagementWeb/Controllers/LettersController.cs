using System.Data.SqlClient;
using System.Web.Http;
using EmailManagementWeb.Models;

namespace EmailManagementWeb.Controllers
{
    public class LettersController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostLetter(Letter letter)
        {
            using (var db = new LettersDbContext())
            {
                var commandText = "INSERT INTO Letters (Title, Date, SenderId, RecipientId, Content) " +
                                  "VALUES (@Title, @Date, @SenderId, @RecipientId, @Content)";
                          
                var title = new SqlParameter("@Title", letter.Title);
                var date = new SqlParameter("@Date", letter.DateTime);
                var senderId = new SqlParameter("@SenderId", letter.SenderID);
                var recipientId = new SqlParameter("@RecipientId", letter.ReceiverID);
                var content = new SqlParameter("@Content", letter.Text);

                db.Database.ExecuteSqlCommand(commandText, title, date, senderId, recipientId, content);

                db.SaveChanges();
            }

            return Created("", letter);
        }
    }
}