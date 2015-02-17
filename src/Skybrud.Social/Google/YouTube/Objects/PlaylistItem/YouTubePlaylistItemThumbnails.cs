using System;
using Skybrud.Social.Json;

namespace Skybrud.Social.Google.YouTube.Objects.PlaylistItem
{
    public class YouTubePlaylistItemThumbnails : GoogleApiObject
    {
        #region Properties

        public YouTubePlaylistItemThumbnail Default { get; private set; }
        public YouTubePlaylistItemThumbnail Medium { get; private set; }
        public YouTubePlaylistItemThumbnail High { get; private set; }
        public YouTubePlaylistItemThumbnail Standard { get; private set; }
        public YouTubePlaylistItemThumbnail MaxRes { get; private set; }

        #endregion

        #region Constructors

        private YouTubePlaylistItemThumbnails(JsonObject obj)
            : base(obj)
        {
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Loads an instance of <var>YouTubePlaylistItemThumbnails</var> from the JSON file at the
        /// specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static YouTubePlaylistItemThumbnails LoadJson(string path)
        {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>YouTubePlaylistItemThumbnails</var> from the specified JSON
        /// string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static YouTubePlaylistItemThumbnails ParseJson(string json)
        {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>YouTubePlaylistItemThumbnails</var> from the specified
        /// <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static YouTubePlaylistItemThumbnails Parse(JsonObject obj)
        {

            // Check whether "obj" is NULL
            if (obj == null)
                return null;

            // Initialize the snippet object
            var thumbnails = new YouTubePlaylistItemThumbnails(obj) {
                Default = obj.GetObject("default", YouTubePlaylistItemThumbnail.Parse),
                Medium = obj.GetObject("medium", YouTubePlaylistItemThumbnail.Parse),
                High = obj.GetObject("high", YouTubePlaylistItemThumbnail.Parse),
                Standard = obj.GetObject("standard", YouTubePlaylistItemThumbnail.Parse),
                MaxRes = obj.GetObject("maxres", YouTubePlaylistItemThumbnail.Parse)
            };
            return thumbnails;
        }

        #endregion
    }
}