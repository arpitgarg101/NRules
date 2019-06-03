using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRules.Samples.RuleBuilder.RuleModels
{
    public class RuleObject
    {
        public string Id { get; set; }

        public int OrganiztionId { get; set; }

        public string RuleName { get; set; }

        public string RuleDescription { get; set; }

        public string BaseEntity { get; set; }

        public int Priority { get; set; }

        public Condition RootCondition { get; set; }

        public Action RuleAction { get; set; }

        public static RuleObject FromJSON(string jsonString)
        {
            RuleObject rule = JsonConvert.DeserializeObject<RuleObject>(jsonString, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            return rule;
        }

        public string ToJSON()
        {
            string jsonString = JsonConvert.SerializeObject(this, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            return jsonString;
        }
    }
}