using CleanCode.FullRefactoring;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI.WebControls;

namespace Project.UserControls
{
    public class PostControl : System.Web.UI.UserControl
    {
        private readonly PostRepository _postRepository;

        public PostControl(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                SaveEntity();                
            }
            else
            {
                SetEntityDisplayed();
            }
        }

        public Label PostBody { get; set; }

        public Label PostTitle { get; set; }

        public int? PostId { get; set; }

        public ValidationResult Results { get; set; }

        void SaveEntity()
        {
            Post entity = GetEntity();            

            if (IsEntityValid(entity))
            {
                // Save to the database and continue to the next page
                _postRepository.SavePost(entity);
            }
            else
            {
                // Display errors to the user
                ShowErrors();
            }
        }

        private Post GetEntity()
        {            
            Post entity = new Post()
            {
                // Map form fields to entity properties
                Id = Convert.ToInt32(PostId.Value),
                Title = PostTitle.Text.Trim(),
                Body = PostBody.Text.Trim()
            };
            return entity;
        }

        private void ShowErrors()
        {
            BulletedList summary = (BulletedList)FindControl("ErrorSummary");
            foreach (var failure in Results.Errors)
            {
                Label errorMessage = FindControl(failure.PropertyName + "Error") as Label;

                if (errorMessage == null)
                {
                    summary.Items.Add(new ListItem(failure.ErrorMessage));
                }
                else
                {
                    errorMessage.Text = failure.ErrorMessage;
                }
            }
        }

        private void SetEntityDisplayed()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            // Display form
            Post entity = _postRepository.GetPost(id);
            PostBody.Text = entity.Body;
            PostTitle.Text = entity.Title;
        }

        bool IsEntityValid(Post entity)
        {
            bool result = false;
            
            PostValidator validator = new PostValidator();
            Results = validator.Validate(entity);
            if (Results.IsValid) result = true;
            return result;
        }
    }

    #region helpers

    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public IEnumerable<ValidationError> Errors { get; set; }
    }

    public class ValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class PostValidator
    {
        public ValidationResult Validate(Post entity)
        {
            throw new NotImplementedException();
        }
    }

    public class DbSet<T> : IQueryable<T>
    {
        public void Add(T entity)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class PostDbContext
    {
        public DbSet<Post> Posts { get; set; }

        public void SaveChanges()
        {
        }
    }
    #endregion

}