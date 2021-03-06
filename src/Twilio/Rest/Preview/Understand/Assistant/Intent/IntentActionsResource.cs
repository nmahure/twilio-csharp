/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// IntentActionsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Understand.Assistant.Intent 
{

    public class IntentActionsResource : Resource 
    {
        private static Request BuildFetchRequest(FetchIntentActionsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathAssistantSid + "/Intents/" + options.PathIntentSid + "/Actions",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch IntentActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IntentActions </returns> 
        public static IntentActionsResource Fetch(FetchIntentActionsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch IntentActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IntentActions </returns> 
        public static async System.Threading.Tasks.Task<IntentActionsResource> FetchAsync(FetchIntentActionsOptions options, 
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathIntentSid"> The intent_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IntentActions </returns> 
        public static IntentActionsResource Fetch(string pathAssistantSid, 
                                                  string pathIntentSid, 
                                                  ITwilioRestClient client = null)
        {
            var options = new FetchIntentActionsOptions(pathAssistantSid, pathIntentSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathIntentSid"> The intent_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IntentActions </returns> 
        public static async System.Threading.Tasks.Task<IntentActionsResource> FetchAsync(string pathAssistantSid, 
                                                                                          string pathIntentSid, 
                                                                                          ITwilioRestClient client = null)
        {
            var options = new FetchIntentActionsOptions(pathAssistantSid, pathIntentSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateIntentActionsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathAssistantSid + "/Intents/" + options.PathIntentSid + "/Actions",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update IntentActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IntentActions </returns> 
        public static IntentActionsResource Update(UpdateIntentActionsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update IntentActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IntentActions </returns> 
        public static async System.Threading.Tasks.Task<IntentActionsResource> UpdateAsync(UpdateIntentActionsOptions options, 
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathIntentSid"> The intent_sid </param>
        /// <param name="actions"> The actions </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IntentActions </returns> 
        public static IntentActionsResource Update(string pathAssistantSid, 
                                                   string pathIntentSid, 
                                                   object actions = null, 
                                                   ITwilioRestClient client = null)
        {
            var options = new UpdateIntentActionsOptions(pathAssistantSid, pathIntentSid){Actions = actions};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathIntentSid"> The intent_sid </param>
        /// <param name="actions"> The actions </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IntentActions </returns> 
        public static async System.Threading.Tasks.Task<IntentActionsResource> UpdateAsync(string pathAssistantSid, 
                                                                                           string pathIntentSid, 
                                                                                           object actions = null, 
                                                                                           ITwilioRestClient client = null)
        {
            var options = new UpdateIntentActionsOptions(pathAssistantSid, pathIntentSid){Actions = actions};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a IntentActionsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> IntentActionsResource object represented by the provided JSON </returns> 
        public static IntentActionsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<IntentActionsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The assistant_sid
        /// </summary>
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }
        /// <summary>
        /// The intent_sid
        /// </summary>
        [JsonProperty("intent_sid")]
        public string IntentSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The data
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; private set; }

        private IntentActionsResource()
        {

        }
    }

}