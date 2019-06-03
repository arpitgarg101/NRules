using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRules.Samples.RuleBuilder.RuleModels
{
    public class LoginalCondition : Condition
    {
        public string ParentEntity { get; set; }

        public string Operand { get; set; }

        public string Value { get; set; }

        public ValueDataType ValueType { get; set; }

        public PropertyValueComparisonOperator Operator { get; set; }
    }
}