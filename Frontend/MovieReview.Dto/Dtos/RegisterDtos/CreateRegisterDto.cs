namespace MovieReview.Dto.Dtos.RegisterDtos
{
    public record CreateRegisterDto
    (
         string Name,
         string Surname,
         string Email,
         string Username,
         string Password
    );

}
