using AfricaUrbanObservatory.Dtos.blogDto;
using AfricaUrbanObservatory.Common.Models;
using AfricaUrbanObservatory.Dtos.CommonDto;

namespace AfricaUrbanObservatory.IServices
{
    public interface IBlogService
    {
        Task<PaginationResponse<BlogResponseDto>> GetBlogs(PaginationRequest request);
        Task<ResultResponseDto<BlogResponseDto>> GetBlogByIdAsync(int id);
        Task<ResultResponseDto<bool>> AddUpdateBlog(AddUpdateBlogDto blog);
        Task<ResultResponseDto<bool>> DeleteBlog(int blogID);
        Task<PaginationResponse<BlogResponseDto>> GetPublicUsersBlogs(PaginationRequest request);
    }
    
}
