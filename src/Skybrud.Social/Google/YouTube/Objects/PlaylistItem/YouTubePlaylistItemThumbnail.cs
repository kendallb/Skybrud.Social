using System;
using Skybrud.Social.Json;

namespace Skybrud.Social.Google.YouTube.Objects.PlaylistItem
{
    public class YouTubePlaylistItemThumbnail : GoogleApiObject
    {

        #region Properties

        public string Url { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        #endregion

        #region Constructors

        private YouTubePlaylistItemThumbnail(JsonObject obj)
            : base(obj)
        {
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Loads an instance of <var>YouTubePlaylistItemThumbnail</var> from the JSON file at the
        /// specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static YouTubePlaylistItemThumbnail LoadJson(string path)
        {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>YouTubePlaylistItemThumbnail</var> from the specified JSON
        /// string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static YouTubePlaylistItemThumbnail ParseJson(string json)
        {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>YouTubePlaylistItemSnippet</var> from the specified
        /// <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static YouTubePlaylistItemThumbnail Parse(JsonObject obj)
        {
            // Check whether "obj" is NULL
            if (obj == null)
                return null;

            // Initialize the snippet object
            var thumbnail = new YouTubePlaylistItemThumbnail(obj) {
                Url = obj.GetString("url"),
                Width = obj.GetInt32("width"),
                Height = obj.GetInt32("height")
            };
            return thumbnail;
        }

        #endregion
    }
}