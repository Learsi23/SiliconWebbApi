
using Infrastructure.Entities;
using Infrastructure.Model;


namespace Infrastructure.Factories;

public class CourseFactory
{
    public static CourseModel Create(CoursesEntity entity)
    {
        try
        {
            return new CourseModel
            {
                Id = entity.Id,
                Title = entity.Title,
                Author = entity.Author,
                Price = entity.Price,
                Discount = entity.Discount,
                Hours = entity.Hours,
                ImageName = entity.ImageName,
                IsBestSeller = entity.IsBestSeller,
                IsDigital = entity.IsDigital,
                LikesNumbers = entity.LikesNumbers,
                LikesProcent = entity.LikesProcent,
                BigImageUrl = entity.BigImageUrl,
                Category = entity.Category!.CategoryName 


            };

        }
        catch { }
        return null!;
    }

    public static IEnumerable<CourseModel> Create(List<CoursesEntity> entities)
    {
        List<CourseModel> courses = [];

        try
        {
            foreach (var entity in entities)
            {
                courses.Add(Create(entity));
            }
        }
        catch { }
        return courses;
    }
}
