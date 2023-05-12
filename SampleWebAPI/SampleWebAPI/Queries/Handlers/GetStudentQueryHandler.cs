using MediatR;
using Microsoft.EntityFrameworkCore;
using SampleWebAPI.Database;
using SampleWebAPI.Queries.Requests;
using SampleWebAPI.Queries.Responses;

namespace SampleWebAPI.Queries.Handlers
{
    public class GetStudentQueryHandler : IRequestHandler<GetStudentRequestQuery, IEnumerable<GetStudentResponse>>
    {
        private readonly ApiDbContext _context;

        public GetStudentQueryHandler(ApiDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<GetStudentResponse>> Handle(GetStudentRequestQuery request, CancellationToken cancellationToken)
        {
            // currently hard coding the response

            return new List<GetStudentResponse>()
            {
                new GetStudentResponse()
                {
                    Name = "Alice",
                    Age = 20,
                    Hobbies = new List<string>() { "reading", "swimming", "coding" }
                },
                new GetStudentResponse()
                {
                    Name = "Bob",
                    Age = 22,
                    Hobbies = new List<string>() { "painting", "dancing", "singing" }
                }
            };

            // use below code in case if you using enity framework

            //return await (from s in _context.Students
            //        select new GetStudentResponse()
            //        {
            //            Age = s.Age,
            //            Name = s.Name,
            //            Hobbies = _context.StudentHobbies.Where(x => x.StudentId == s.Id).Select(x => x.Hobbie).ToList()
            //        }).ToListAsync();
                  
        }
    }
}
