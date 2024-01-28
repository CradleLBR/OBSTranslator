using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OBSTranslator
{
    internal class ObsSocket
    {
        private Uri _uri;
        private ClientWebSocket _clientWebSocket;
        private StringBuilder _response = new StringBuilder();
        private byte[] _responseBuffer = new byte[1024];
        Logger logger = LogManager.GetCurrentClassLogger();

        public ObsSocket(string obsWebSocketUri)
        {
            try
            {
                _uri = new Uri("ws://" + obsWebSocketUri);
                logger.Info($"Server Uri: {_uri}");
            }
            catch { throw; }
        }

        public async Task ConnectAsync()
        {
            try
            {
                _clientWebSocket = new ClientWebSocket();
                await _clientWebSocket.ConnectAsync(_uri, CancellationToken.None);

                while (_clientWebSocket.State == WebSocketState.Open)
                {
                    var result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(_responseBuffer), CancellationToken.None);
                    _response.Append(Encoding.UTF8.GetString(_responseBuffer, 0, result.Count));

                    if (result.EndOfMessage) break;
                }

                logger.ConditionalDebug($"Response: {_response.ToString()}.");
                //string helloMessage = _response.ToString();

                await IdentifyAsync();
            }
            catch { throw; }
        }

        public async Task WriteText(string inputName ,string text)
        {
            string id = Guid.NewGuid().ToString();
            string updateTextRequest = $"{{\"op\": 6, \"d\": {{\"requestType\": \"SetInputSettings\", \"requestId\": \"{id}\",\"requestData\": {{\"inputName\": \"{inputName}\"," +
                $"\"inputSettings\": {{\"text\":\"{text}\"}} }} }}}}";
            await SendMessageAsync(updateTextRequest);
            _response.Clear();
            while (_clientWebSocket.State == WebSocketState.Open)
            {
                var result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(_responseBuffer), CancellationToken.None);
                _response.Append(Encoding.UTF8.GetString(_responseBuffer, 0, result.Count));

                if (result.EndOfMessage) break;
            }

            // Logger.Info();
            var writeTextResponse = _response.ToString();
        }

        public async Task CreateInput(string sceneName, string inputName, InputSettings settings)
        {
            try
            {
                string id = Guid.NewGuid().ToString();
                string inputKind = "text_gdiplus_v2";
                string createSourceRequest = $"{{\"op\": 6, \"d\": {{\"requestType\": \"CreateInput\", \"requestId\": \"{id}\"," +
                    $" \"requestData\": {{ \"sceneName\": \"{sceneName}\", \"inputName\": \"{inputName}\", \"inputKind\": \"{inputKind}\" }} }} }}";
                await SendMessageAsync(createSourceRequest);
                _response.Clear();
                while (_clientWebSocket.State == WebSocketState.Open)
                {
                    var result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(_responseBuffer), CancellationToken.None);
                    _response.Append(Encoding.UTF8.GetString(_responseBuffer, 0, result.Count));

                    if (result.EndOfMessage) break;
                }

                var requestResponse = _response.ToString();
                logger.ConditionalDebug($"Response: {requestResponse}.");

                JsonDocument jsonDocument = JsonDocument.Parse(requestResponse);
                JsonElement root = jsonDocument.RootElement;
                int sceneItemId = root.GetProperty("d").GetProperty("responseData").GetProperty("sceneItemId").GetInt32();

                await SetInputSettings(inputName, settings);
                await SetSceneItemTransform(sceneName, sceneItemId, settings);
            }
            catch { throw; }
        }

        private async Task SetInputSettings(string inputName, InputSettings settings)
        {
            try
            {
                string id = Guid.NewGuid().ToString();
                string setSettingsRequest = $"{{\"op\": 6, \"d\": {{\"requestType\": \"SetInputSettings\", \"requestId\": \"{id}\",\"requestData\": {{\"inputName\": \"{inputName}\"," +
                    $" \"inputSettings\": {{ \"font\": {{ \"face\": \"{settings.FontFace}\", \"size\": {settings.FontSize}, \"style\": \"{settings.FontStyle}\" }}," +
                    $" \"align\": \"{settings.HorizontalAlign}\", \"valign\": \"{settings.VerticalAlign}\", \"opacity\": {settings.Opacity}," +
                    $" \"color\": {settings.Color}, \"extents\": {settings.Extents}, \"extents_cx\": {settings.ExtentsCX}, \"extents_cy\": {settings.ExtentsCY}," +
                    $" \"extents_wrap\": {settings.ExtentsWrap}, \"text\": \"{settings.Text}\" }} }} }} }}";
                await SendMessageAsync(setSettingsRequest);
                _response.Clear();
                while (_clientWebSocket.State == WebSocketState.Open)
                {
                    var result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(_responseBuffer), CancellationToken.None);
                    _response.Append(Encoding.UTF8.GetString(_responseBuffer, 0, result.Count));

                    if (result.EndOfMessage) break;
                }

                logger.ConditionalDebug($"Response: {_response.ToString()}.");
                //var requestResponse = _response.ToString();
            }
            catch
            {
                logger.Error("Input settings error.");
                throw;
            }

        }

        private async Task SetSceneItemTransform(string sceneName, int sceneItemId, InputSettings settings)
        {
            try
            {
                string id = Guid.NewGuid().ToString();
                string setTransformRequest = $"{{\"op\": 6, \"d\": {{\"requestType\": \"SetSceneItemTransform\", \"requestId\": \"{id}\",\"requestData\": {{\"sceneName\": \"{sceneName}\"," +
                    $" \"sceneItemId\": {sceneItemId}, \"sceneItemTransform\": {{ \"positionX\": {settings.PositionX}, \"positionY\": {settings.PositionY} }} }} }} }}";
                await SendMessageAsync(setTransformRequest);
                _response.Clear();
                while (_clientWebSocket.State == WebSocketState.Open)
                {
                    var result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(_responseBuffer), CancellationToken.None);
                    _response.Append(Encoding.UTF8.GetString(_responseBuffer, 0, result.Count));

                    if (result.EndOfMessage) break;
                }

                logger.ConditionalDebug($"Response: {_response.ToString()}.");
                var requestResponse = _response.ToString();
            }
            catch
            {
                logger.Error("Scene item transform error.");
                throw;
            }
        }

        private async Task IdentifyAsync()
        {
            try
            {
                if (_clientWebSocket.State == WebSocketState.Open)
                {
                    string identificationMessage = $"{{\"op\": 1, \"d\": {{\"rpcVersion\": 1}} }}";
                    await SendMessageAsync(identificationMessage);
                    _response.Clear();
                    while (_clientWebSocket.State == WebSocketState.Open)
                    {
                        var result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(_responseBuffer), CancellationToken.None);
                        _response.Append(Encoding.UTF8.GetString(_responseBuffer, 0, result.Count));

                        if (result.EndOfMessage) break;
                    }

                    logger.ConditionalDebug($"Response: {_response.ToString()}.");
                    //string identifiedResponse = _response.ToString();
                }
            }
            catch
            {
                logger.Error("Connection Identify error.");
                throw;
            }
        }

        private async Task CreateSourceFilter(string sourceName, double speed)
        {
            string id = Guid.NewGuid().ToString();
            string filterName = "ScrollFilter";
            string filterKind = "scroll_filter";
            string createFilterRequest = $"{{\"op\": 6, \"d\": {{\"requestType\": \"CreateSourceFilter\", \"requestId\": \"{id}\",\"requestData\": {{\"sourceName\": \"{sourceName}\"," +
                $"\"filterName\": \"{filterName}\", \"filterKind\": \"{filterKind}\", \"filterSettings\":{{\"speed_x\": {speed.ToString("0.0", CultureInfo.InvariantCulture)} }} }} }}}}";
            await SendMessageAsync(createFilterRequest);
            _response.Clear();
            while (_clientWebSocket.State == WebSocketState.Open)
            {
                var result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(_responseBuffer), CancellationToken.None);
                _response.Append(Encoding.UTF8.GetString(_responseBuffer, 0, result.Count));

                if (result.EndOfMessage) break;
            }

            // Logger.Info();
            var requestResponse = _response.ToString();
        }

        private async Task SendMessageAsync(string message)
        {
            byte[] bufferBytes = Encoding.UTF8.GetBytes(message);
            await _clientWebSocket.SendAsync(new ArraySegment<byte>(bufferBytes), WebSocketMessageType.Text, true, CancellationToken.None);
        }
    }
}
