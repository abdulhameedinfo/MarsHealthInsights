﻿using MarsHealthInsights.DTOs;

namespace MarsHealthInsights.Repository
{
    public interface IDataRepository
    {
        public Task<IEnumerable<CDCDataDTO>> FetchData(string url);
        public Task<IEnumerable<CDCDataDTO>> GetCDCDataDTOList(string data);
    }
}
