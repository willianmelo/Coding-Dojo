using System;
using System.Reflection;
using Xunit.Sdk;

namespace AtmChallenge.Tests;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class AtmBeforeAfter : BeforeAfterTestAttribute
{
    public override void Before(MethodInfo methodUnderTest)
    {
        
    }

    public override void After(MethodInfo methodUnderTest)
    {
        
    }
}
