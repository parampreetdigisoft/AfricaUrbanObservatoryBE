using AfricaUrbanObservatory.Dtos.CommonDto;

namespace AfricaUrbanObservatory.Dtos.AssessmentDto
{
    public class GetAssessmentQuestoinRequestDto : PaginationRequest
    {
        public int AssessmentID { get; set; } 
        public int? PillarID { get; set; }
    }
}
