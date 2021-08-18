using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudMgtAPI.Dtos
{
    public class ResponseDto<T>
    {
        public List<T> Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public ResponseDto(List<T> data, string message, bool isSuccess)
        {
            Data = data;
            message = Message;
            IsSuccess = isSuccess;
        }
        public ResponseDto(List<T> data, bool isSuccess)
        {
            Data = data;
            Message = "Success";
            IsSuccess = true;
        }


    }
}

