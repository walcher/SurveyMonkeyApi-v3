using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyMonkey.RequestSettings
{
    public class ApiHeaders
    {
      
        /// <summary>
        /// Which scopes are available to the user using an app
        /// </summary>
        public string OAuthScopesAvailable { get; set; }
        /// <summary>
        /// Which scopes the user has granted permission to, to the app
        /// </summary>
        public string OAuthScopesGranted { get; set; }
        /// <summary>
        /// Per day request limit the app has
        /// </summary>
        public int RatelimitAppGlobalDayLimit { get; set; }
        /// <summary>
        /// Number of remaining requests app has before hitting daily limit
        /// </summary>
        public int RatelimitAppGlobalDayRemaining { get; set; }
        /// <summary>
        /// Number of seconds until the rate limit remaining resets
        /// </summary>
        public int RatelimitAppGlobalDayReset { get; set; }
        /// <summary>
        /// Per minute request limit the app has
        /// </summary>
        public int RatelimitAppGlobalMinuteLimit { get; set; }
        /// <summary>
        /// Number of remaining requests app has before hitting per minute limit
        /// </summary>
        public int RatelimitAppGlobalMinuteRemaining { get; set; }
        /// <summary>
        /// Number of seconds until the rate limit remaining resets
        /// </summary>
        public int RatelimitAppGlobalMinuteReset { get; set; }
    }
}
