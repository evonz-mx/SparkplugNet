namespace SparkplugNet.Core
{
    using System;

    /// <summary>
    /// A class that contains the sparkplug connect options.
    /// </summary>
    public abstract class SparkplugBaseOptions
    {
        /// <summary>
        /// The default broker
        /// </summary>
        public const string DefaultBroker = "localhost";
        /// <summary>
        /// The default port
        /// </summary>
        public const int DefaultPort = 1883;
        /// <summary>
        /// The default client identifier
        /// </summary>
        public const string DefaultClientId = "SparkplugNet";
        /// <summary>
        /// The default user name
        /// </summary>
        public const string DefaultUserName = "";
        /// <summary>
        /// The default password
        /// </summary>
        public const string DefaultPassword = "";
        /// <summary>
        /// The default use TLS
        /// </summary>
        public const bool DefaultUseTls = false;
        /// <summary>
        /// The default scada host identifier
        /// </summary>
        public const string DefaultScadaHostIdentifier = "SparkplugNet";
        /// <summary>
        /// The default reconnect interval
        /// </summary>
        public static readonly TimeSpan DefaultReconnectInterval = TimeSpan.FromSeconds(30);
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SparkplugBaseOptions"/> class.
        /// </summary>
        /// <param name="reconnectInterval">The reconnect interval.</param>
        /// <param name="brokerAddress">The broker address.</param>
        /// <param name="port">The port.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <param name="useTls">if set to <c>true</c> [use TLS].</param>
        /// <param name="scadaHostIdentifier">The scada host identifier.</param>
        /// <param name="tlsParameters">The TLS parameters.</param>
        /// <param name="webSocketParameters">The web socket parameters.</param>
        /// <param name="proxyOptions">The proxy options.</param>
        public SparkplugBaseOptions(
        string brokerAddress,
        int port,
        string clientId,
        string userName,
        string password,
        bool useTls,
        string scadaHostIdentifier,
        TimeSpan reconnectInterval,
        MqttClientOptionsBuilderTlsParameters? tlsParameters = null,
        MqttClientOptionsBuilderWebSocketParameters? webSocketParameters = null,
        MqttClientWebSocketProxyOptions? proxyOptions = null)
        {
            this.BrokerAddress = brokerAddress;
            this.Port = port;
            this.ClientId = clientId;
            this.UserName = userName;
            this.Password = password;
            this.UseTls = useTls;
            this.ScadaHostIdentifier = scadaHostIdentifier;
            this.ReconnectInterval = reconnectInterval;
            this.WebSocketParameters = webSocketParameters;
            this.ProxyOptions = proxyOptions;
            this.TlsParameters = tlsParameters;
        }

        /// <summary>
        /// Gets or sets the broker address.
        /// </summary>
        [DefaultValue(DefaultBroker)]
        public string BrokerAddress { get; set; } = DefaultBroker;

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        [DefaultValue(DefaultPort)]
        public int Port { get; set; } = DefaultPort;

        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        [DefaultValue(DefaultClientId)]
        public string ClientId { get; set; } = DefaultClientId;

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        [DefaultValue(DefaultUserName)]
        public string UserName { get; set; } = DefaultUserName;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [DefaultValue(DefaultPassword)]
        public string Password { get; set; } = DefaultPassword;

        /// <summary>
        /// Gets or sets a value indicating whether TLS should be used or not.
        /// </summary>
        [DefaultValue(DefaultUseTls)]
        public bool UseTls { get; set; } = DefaultUseTls;

        /// <summary>
        /// Gets or sets the SCADA host identifier.
        /// </summary>
        [DefaultValue(DefaultScadaHostIdentifier)]
        public string ScadaHostIdentifier { get; set; } = DefaultScadaHostIdentifier;

        /// <summary>
        /// Gets or sets the reconnect interval.
        /// </summary>
        public TimeSpan ReconnectInterval { get; set; } = DefaultReconnectInterval;

        /// <summary>
        /// Gets or sets the WebSocket parameters.
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DefaultValue(null)]
        public MqttClientOptionsBuilderWebSocketParameters? WebSocketParameters { get; set; }

        /// <summary>
        /// Gets or sets the proxy options.
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DefaultValue(null)]
        public MqttClientWebSocketProxyOptions? ProxyOptions { get; set; }

        /// <summary>
        /// Gets or sets the TLS parameters.
        /// </summary>
        /// <value>
        /// The TLS parameters.
        /// </value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DefaultValue(null)]
        public MqttClientOptionsBuilderTlsParameters? TlsParameters { get; set; }
    }
}
