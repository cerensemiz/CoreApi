namespace EntityLayer.ResultModels
{
    public class Result:IResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public Result()
        {

        }
        public Result(bool success)
        {
            IsSuccess = success;
        }

        public Result(bool success, string message) : this(success)
        {
            Message = message;
            // IsSuccess = success;
        }
    }
}
