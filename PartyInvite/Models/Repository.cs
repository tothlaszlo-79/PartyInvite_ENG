namespace PartyInvite.Models
{
    public static class Repository
    {
        private static List<GuestResponse> _response = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses 
        { get 
            {
                return _response; 
            } 
        }
        
        public static void AddResponse (GuestResponse response)
        {
            _response.Add(response);

        }
    }
}
