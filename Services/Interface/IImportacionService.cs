﻿namespace importacionmasiva.api.net.Services.Interface
{
    public interface IImportacionService
    {
        Task ImportFromExcel(IFormFile dataset, string registryName, string tableName);
    }
}
