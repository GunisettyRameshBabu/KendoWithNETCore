using MediatR;
using SampleWebAPI.Queries.Responses;

namespace SampleWebAPI.Queries.Requests
{
    public class GetStudentRequestQuery : IRequest<IEnumerable<GetStudentResponse>>
    {
    }
}
