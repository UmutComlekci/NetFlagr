using System;
using System.Net.Http;
using System.Reflection;
using Microsoft.Extensions.Options;
using Pathoschild.Http.Client;

namespace NetFlagr
{
    public class NetFlagrHttpClient
    {
        private readonly FluentClient _client;
        private readonly NetFlagrConfiguration _configuration;

        public NetFlagrHttpClient(HttpClient httpClient, IOptions<NetFlagrConfiguration> configuration)
        {
            if (configuration.Value == null)
            {
                configuration = Options.Create<NetFlagrConfiguration>(new NetFlagrConfiguration());
            }

            _configuration = configuration.Value;
            if (string.IsNullOrEmpty(_configuration.BasePath))
            {
                throw new ArgumentException("basePath cannot be empty");
            }

            httpClient.Timeout = TimeSpan.FromMilliseconds(_configuration.Timeout);
            _client = new FluentClient(new Uri(_configuration.BasePath), httpClient);
            _client.Filters.Clear();
            if (!string.IsNullOrEmpty(_configuration.UserAgent))
            {
                _client.SetUserAgent(_configuration.UserAgent);
            }
            else
            {
                Version version = typeof(NetFlagrApiClient).GetTypeInfo().Assembly.GetName().Version;
                _client.SetUserAgent($"NetFlagrHttpClient/{version} (+http://github.com/checkr/NetFlagrHttpClient)");
            }
        }

        private IRequest SetRequestDefaults(IRequest request)
        {
            if (_configuration.DefaultHeader != null && _configuration.DefaultHeader.Count > 0)
            {
                foreach (var item in _configuration.DefaultHeader)
                {
                    request = request.WithHeader(item.Key, item.Value);
                }
            }

            if (!string.IsNullOrWhiteSpace(_configuration.Username) && !string.IsNullOrWhiteSpace(_configuration.Password))
            {
                request = request.WithBasicAuthentication(_configuration.Username, _configuration.Password);
            }

            return request;
        }

        public IRequest GetAsync(string resource)
        {
            var request = _client.GetAsync(resource);
            return SetRequestDefaults(request);
        }

        public IRequest PostAsync(string resource)
        {
            var request = _client.PostAsync(resource);
            return SetRequestDefaults(request);
        }

        public IRequest PutAsync(string resource)
        {
            var request = _client.PutAsync(resource);
            return SetRequestDefaults(request);
        }

        public IRequest DeleteAsync(string resource)
        {
            var request = _client.DeleteAsync(resource);
            return SetRequestDefaults(request);
        }

        public IRequest PatchAsync(string resource)
        {
            var request = _client.PatchAsync(resource);
            return SetRequestDefaults(request);
        }
    }
}