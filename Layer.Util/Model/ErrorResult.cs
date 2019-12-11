namespace Layer.Util
{
    public class ErrorResult : AjaxResult
    {
        public ErrorResult(string msg = null)
        {
            Msg = msg;
            Success = false;
        }
    }
}