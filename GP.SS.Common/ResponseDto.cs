namespace GP.SS.Common
{
    public class ResponseDto<T> where T : class
    {
        public bool Success { get; set; }
        public string ErrorDescription { get; set; }
        public T ResultObject { get; set; }

        public ResponseDto(bool success, T resultObject = null)
        {
            Success = success;
            ResultObject = resultObject;
        }

        public ResponseDto(bool success, string errorDescription)
        {
            Success = success;
            ErrorDescription = errorDescription;
        }
    }
}
