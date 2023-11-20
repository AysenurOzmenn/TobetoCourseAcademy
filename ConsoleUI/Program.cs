using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //CourseTest();
        //CategoryTest();
        //InstructorTest();

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        Category  category= new Category { Name = "Veri Analiz" };
        var result = categoryManager.Add(category);
        //Category category = categoryManager.GetById(3).Data;
        //var result = categoryManager.Delete(category);
        if (result.Success == true)
        {
            Console.WriteLine(result.Message);
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }

    private static void InstructorTest()
    {
        InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());
        var result = instructorManager.GetAll();
        if (result.Success == true)
        {
            foreach (var instructor in result.Data)
            {
                Console.WriteLine(instructor.Name);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        var result = categoryManager.GetAll();
        if (result.Success == true)
        {
            foreach (var category in result.Data)
            {
                Console.WriteLine(category.Name);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }

    private static void CourseTest()
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());
        var result = courseManager.GetCourseDetails();
        foreach (var course in result.Data)
        {
            Console.WriteLine(course.CourseName);
        }
       
    }
}