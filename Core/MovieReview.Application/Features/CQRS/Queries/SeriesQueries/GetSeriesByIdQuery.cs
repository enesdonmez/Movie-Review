namespace MovieReview.Application.Features.CQRS.Queries.SeriesQueries
{
    public class GetSeriesByIdQuery
    {
        public int SeriesId { get; set; }

        public GetSeriesByIdQuery(int seriesId)
        {
            SeriesId = seriesId;
        }
    }
}
