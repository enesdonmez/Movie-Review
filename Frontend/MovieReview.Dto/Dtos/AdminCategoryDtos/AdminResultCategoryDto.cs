namespace MovieReview.Dto.Dtos.AdminCategoryDtos;

public class AdminResultCategoryDto
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public int MovieCount { get; set; }
    public int ReviewCount { get; set; }
    public double AvgRating { get; set; }
    public bool IsActive { get; set; }
}
