using System;

namespace Eventures.Models
{
    public class CustomLog
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public int EventId { get; set; }

        public string LogLevel { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
