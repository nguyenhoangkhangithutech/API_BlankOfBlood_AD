namespace API_BloodBank_v1.Prototypes
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public object Data { get; set; }
    }
}
