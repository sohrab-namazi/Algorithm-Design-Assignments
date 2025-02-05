﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCommon;

namespace A1.Tests
{
    [DeploymentItem("TestData")]
    [TestClass()]
    public class GradedTests
    {
        [TestMethod(), Timeout(500)]
        public void SolveTest_Q1MazeExit()
        {
            RunTest(new Q1MazeExit("TD1"));
        }

        [TestMethod(), Timeout(4000)]
        public void SolveTest_Q2AddExitToMaze()
        {
            RunTest(new Q2AddExitToMaze("TD2"));
        }

        [TestMethod(), Timeout(300)]
        public void SolveTest_Q3Acyclic()
        {
            RunTest(new Q3Acyclic("TD3"));
        }

        [TestMethod(), Timeout(12000)]
        public void SolveTest_Q4OrderOfCourse()
        {
            RunTest(new Q4OrderOfCourse("TD4"));
        }

        [TestMethod(), Timeout(500)]
        public void SolveTest_Q5StronglyConnected()
        {
            RunTest(new Q5StronglyConnected("TD5"));
        }

        public static void RunTest(Processor p)
        {
            TestTools.RunLocalTest("A1", p.Process, p.TestDataName, p.Verifier, VerifyResultWithoutOrder: p.VerifyResultWithoutOrder,
                excludedTestCases: p.ExcludedTestCases);
        }
    }
}