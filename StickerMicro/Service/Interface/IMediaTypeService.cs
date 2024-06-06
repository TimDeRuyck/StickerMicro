using StickerMicro.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerMicro.Service.Interface
{
    public interface IMediaTypeService
    {
        Task<MediaType> AddMediaTypeAsync(MediaType mediaType);
        Task<MediaType> UpdateMediaTypeAsync(MediaType mediaType);
        Task DeleteMediaTypeAsync(int mediaTypeId);
    }
}
