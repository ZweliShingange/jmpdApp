namespace JmpdAppApi.Common
{
    public class Result<T>
    {
        internal Result(bool succeeded, string error)
        {
            this.Succeeded = succeeded;
            this.Errors = new List<object>
            {
                error
            };
        }

        internal Result(bool succeeded, List<object> errors)
        {
            this.Succeeded = succeeded;
            this.Errors = errors;
        }

        internal Result(bool succeeded, T data, List<object> errors)
        {
            this.Succeeded = succeeded;
            this.Errors = errors;
            this.Data = data;
        }

        public bool Succeeded { get; set; }

        public T Data { get; set; }

        public List<object> Errors { get; set; }

        public static Result<T> Success(T data) => new Result<T>(true, data, new List<object> { });

        public static Result<T> Failure(string error) => new Result<T>(false, error);

        public static Result<T> Failure(List<object> errors) => new Result<T>(false, errors);
    }
}