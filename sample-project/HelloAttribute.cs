using System;
using System.ComponentModel.DataAnnotations;

namespace sample_project
{
    public class HelloAttribute : ValidationAttribute {
        public override bool IsValid(object value)
        {
            return true;
        }
    }
}