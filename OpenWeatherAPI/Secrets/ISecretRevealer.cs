using System.Collections.Generic;

namespace OpenWeatherAPI.Secrets
{
    public interface ISecretRevealer
    {
        public KeyValuePair<string, string> Reveal();
    }
}