using Microsoft.AspNetCore.Mvc;

namespace _Lab_RazorSyntax.Models
{
    public class CommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            HttpClient client = new HttpClient();  
            ICollection<CommentViewModel>
                comments = client.GetFromJsonAsync<ICollection<CommentViewModel>>("https://jsonplaceholder.typicode.com/comments?postId=" + id).Result;
            return View("~/views/components/comment.cshtml", comments); 
        }
    }
}
