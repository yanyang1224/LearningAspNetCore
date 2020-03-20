using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Invengo.Library.MIS.MIS
{
    public class MediaInfoAppService :
        CrudAppService<
            MediaInfo,
            MediaInfoDto, // Used to show
            Guid, // Primary key
            PagedAndSortedResultRequestDto, // Used for paging/sorting on getting a list of attachment
            CreateUpdateMediaInfoDto, // Used to create
            CreateUpdateMediaInfoDto> // Used to update
        , IMediaInfoAppService
    {
        private IRepository<MediaInfo, Guid> _mediaInfoRepository;

        public MediaInfoAppService(
            IRepository<MediaInfo, Guid> mediaInfoRepository)
            : base(mediaInfoRepository)
        {
            _mediaInfoRepository = mediaInfoRepository;
        }


        public async Task<List<MediaInfoDto>> GetAllReleaseAsync(MediaType? mediaType)
        {
            var query = _mediaInfoRepository
                .WhereIf(mediaType != null, a => a.MediaType == mediaType)
                .Where(a => a.Status == Status.Release)
                .Select(a => ObjectMapper.Map<MediaInfo, MediaInfoDto>(a));

            return await AsyncQueryableExecuter.ToListAsync(query);
        }
    }
}
