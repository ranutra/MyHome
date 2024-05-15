using MyHome.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHome.Factory
{
    public class ProjectFactory
    {
        public static Project createProject(int id, string title, string description, string category, int deliveryTime, int revisions, string features, int price, string shortDesc, DateTime createdAt, string images, int creatorId)
        {
            Project project = new Project
            {
                Id = id,
                Title = title,
                Description = description,
                Category = category,
                DeliveryTime = deliveryTime,
                Revisions = revisions,
                Features = features,
                Price = price,
                ShortDesc = shortDesc,
                CreatedAt = createdAt,
                Images = images,
                CreatorId = creatorId
            };
            return project;
        }
    }
}