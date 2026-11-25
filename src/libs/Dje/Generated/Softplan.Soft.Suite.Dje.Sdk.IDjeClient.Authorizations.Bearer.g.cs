
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IDjeClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}