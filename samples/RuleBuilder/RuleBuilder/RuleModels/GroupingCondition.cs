using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRules.Samples.RuleBuilder.RuleModels
{
    public class GroupingCondition : Condition
    {
        public Condition LeftNode;

        public Condition RightNode;
    }
}