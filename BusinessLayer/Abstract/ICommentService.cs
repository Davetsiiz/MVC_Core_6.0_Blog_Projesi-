using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentInsert(Comment comment);
        void CommentDelete(Comment comment);
        void CommentyUpdate(Comment comment);
        List<Comment> CommentListAll(int id);
        Comment CommentGetById(int id);
        List<Comment> GetCommentWithBlog();
    }
}
