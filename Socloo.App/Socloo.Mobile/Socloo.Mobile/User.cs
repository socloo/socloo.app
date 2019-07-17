﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SoclooAPI.Models
{
    public class User
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProfilePictureId { get; set; }
        public bool Deleted { get; set; } = false;

        [BsonRepresentation(BsonType.ObjectId)]
        public string CalendarId { get; set; }
    }
}
