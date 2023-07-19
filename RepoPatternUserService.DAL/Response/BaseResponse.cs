﻿namespace RepoPatternUserService.DAL.Response;

public class BaseResponse<T> : IBaseResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T? Data { get; set; }

    public BaseResponse(bool success, string message, T? data)
    {
        Success = success;
        Message = message;
        Data = data;
    }
}