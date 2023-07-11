namespace Pokemon.Api.Application.ViewModel.Responses
{
    public class PokemonServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "";
    }
}