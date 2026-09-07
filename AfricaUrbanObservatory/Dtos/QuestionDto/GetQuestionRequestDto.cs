using AfricaUrbanObservatory.Dtos.CommonDto;

namespace AfricaUrbanObservatory.Dtos.QuestionDto
{
    public class GetQuestionRequestDto : PaginationRequest
    {
        public int? PillarID { get; set; }
    }
}
