using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_BARCINAS_MARCDENIZE.Models;

namespace IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_BARCINAS_MARCDENIZE.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<Question>
            {
                new Question
                {
                    Id = 1,
                    QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Choices = new List<string> { "It makes C# code shorter", "It prevents the application from restarting", "It allows data to persist after the application stops", "It removes the need for MVC" },
                    CorrectIndex = 2
                },
                new Question
                {
                    Id = 2,
                    QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Choices = new List<string> { "Code-First", "Database-First", "Model-First", "Controller-First" },
                    CorrectIndex = 1
                },
                new Question
                {
                    Id = 3,
                    QuestionText = "What is the primary purpose of Entity Framework Core?",
                    Choices = new List<string> { "To create HTML pages automatically", "To replace the MVC Controller", "To map objects in code to relational database data", "To replace the C# compiler" },
                    CorrectIndex = 2
                },
                new Question
                {
                    Id = 4,
                    QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                    Choices = new List<string> { "DbContext", "DbSetView", "ControllerContext", "RazorContext" },
                    CorrectIndex = 0
                },
                new Question
                {
                    Id = 5,
                    QuestionText = "What does the following command primarily do?\n\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Choices = new List<string> { "Deletes the database", "Creates a new MVC project", "Generates EF Core models and a DbContext from an existing database", "Starts the MVC application" },
                    CorrectIndex = 2
                },
                new Question
                {
                    Id = 6,
                    QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Choices = new List<string> { "Program.cs only", "appsettings.json", "Index.cshtml", "Student.cs" },
                    CorrectIndex = 1
                },
                new Question
                {
                    Id = 7,
                    QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Choices = new List<string> { "One-to-One", "One-to-Many", "Many-to-Many", "Many-to-One only" },
                    CorrectIndex = 1
                },
                new Question
                {
                    Id = 8,
                    QuestionText = "In the following example, what is SectionId?\n\npublic int SectionId { get; set; }\npublic Section Section { get; set; }",
                    Choices = new List<string> { "Primary key of Student", "Foreign key referencing Section", "Navigation property", "Database connection string" },
                    CorrectIndex = 1
                },
                new Question
                {
                    Id = 9,
                    QuestionText = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Choices = new List<string> { "It stores the database password", "It represents a relationship to another entity", "It creates a new database", "It validates the student's name" },
                    CorrectIndex = 1
                },
                new Question
                {
                    Id = 10,
                    QuestionText = "What does .Include() generally allow EF Core to do?",
                    Choices = new List<string> { "Delete the Section table", "Load related Section data together with Students", "Create a new Student", "Validate Student input" },
                    CorrectIndex = 1
                },
                new Question
                {
                    Id = 11,
                    QuestionText = "Why might a ViewModel be used when displaying Student and Section information?",
                    Choices = new List<string> { "To replace the database", "To combine or shape the data specifically needed by the view", "To automatically create database tables", "To prevent controllers from using LINQ" },
                    CorrectIndex = 1
                },
                new Question
                {
                    Id = 12,
                    QuestionText = "Consider this query:\n\nvar students = _context.Students.Include(s => s.Section).ToList();\n\nWhat is the main benefit of Include(s => s.Section)?",
                    Choices = new List<string> { "It loads the related Section navigation property", "It creates a Section object manually", "It removes the foreign key", "It prevents the query from accessing the database" },
                    CorrectIndex = 0
                },
                new Question
                {
                    Id = 13,
                    QuestionText = "Which type of validation occurs in the browser before a request is sent to the server?",
                    Choices = new List<string> { "Database-level validation", "Client-side validation", "Server-side validation", "EF Core migration validation" },
                    CorrectIndex = 1
                },
                new Question
                {
                    Id = 14,
                    QuestionText = "Why is server-side validation still necessary if client-side validation exists?",
                    Choices = new List<string> { "Client-side validation can be bypassed", "Client-side validation automatically modifies the database", "Server-side validation only works with SQLite", "Client-side validation cannot display messages" },
                    CorrectIndex = 0
                },
                new Question
                {
                    Id = 15,
                    QuestionText = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                    Choices = new List<string> { "Student Number should always be nullable", "Student Number should be unique", "Student Number should always be the same", "Student Number should contain only spaces" },
                    CorrectIndex = 1
                },
                new Question
                {
                    Id = 16,
                    QuestionText = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                    Choices = new List<string> { "It protects data integrity even if application-level validation is bypassed", "It makes Razor Views render faster", "It removes the need for a Controller", "It automatically creates a ViewModel" },
                    CorrectIndex = -1
                },
                new Question
                {
                    Id = 17,
                    QuestionText = "What is the purpose of a try...catch block in a controller?",
                    Choices = new List<string> { "To create navigation properties", "To catch and handle exceptions that may occur during execution", "To generate database tables", "To perform client-side validation" },
                    CorrectIndex = -1
                },
                new Question
                {
                    Id = 18,
                    QuestionText = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                    Choices = new List<string> { "UseDatabase()", "UseExceptionHandler()", "UseValidationHandler()", "UseMvcDatabase()" },
                    CorrectIndex = -1
                },
                new Question
                {
                    Id = 19,
                    QuestionText = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                    Choices = new List<string> { "Display the student's information anyway", "Display a Not Found (404) response/page", "Delete Student 999", "Create Student 999 automatically" },
                    CorrectIndex = -1
                },
                new Question
                {
                    Id = 20,
                    QuestionText = "A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?",
                    Choices = new List<string> { "Data integrity", "HTML formatting", "CSS inheritance", "Razor syntax" },
                    CorrectIndex = -1
                }
            };

            return View(questions);
        }
    }
}