﻿namespace RepoPatternUserService.DAL.Response;

public interface IBaseResponse<T>
{
    bool Success { get; set; }
    string Message { get; set; }
    T? Data { get; set; }
}