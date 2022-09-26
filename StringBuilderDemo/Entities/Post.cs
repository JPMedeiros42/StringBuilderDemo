using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo.Entities
{
    class Post
    {   
        public string  Title { get; set; }
        public int Likes { get; set; }
        public DateTime Moment { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(string title, int likes, DateTime moment, string content)
        {
            Title = title;
            Likes = likes;
            Moment = moment;
            Content = content;
        }

        public void AddComment(Comment comments)
        {
            Comments.Add(comments);
        }
        public void RemoveComment(Comment comments)
        {
            Comments.Remove(comments);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
