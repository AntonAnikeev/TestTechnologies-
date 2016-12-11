using System.Collections.Generic;
using ApprovalsTestProject;
using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;
using Xunit.Sdk;

namespace Tests
{
    [UseReporter(typeof(DiffReporter))]
    [UseApprovalSubdirectory("Approvals")]
    public class Test
    {
        public HellLogic HellLogic { get; set; }

        [Fact]
        public void Should()
        {
            //Do
            HellLogic = new HellLogic();
            var executeHellLogic = HellLogic.ExecuteHellLogic();
            //Verify
            var serializeObject = JsonConvert.SerializeObject(executeHellLogic);
            Approvals.VerifyJson(serializeObject);
        }
    }
}
