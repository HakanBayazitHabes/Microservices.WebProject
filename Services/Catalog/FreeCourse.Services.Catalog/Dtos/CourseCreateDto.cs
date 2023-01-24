using FreeCourse.Services.Catalog.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Services.Catalog.Dtos
{
    internal class CourseCreateDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string UserId { get; set; }

        public string Picture { get; set; }

        public FeatureDto Feature { get; set; }

        public string CategoryId { get; set; }

    }
}
