﻿using System.Threading.Tasks;
using Microsoft.Azure.ApplicationInsights;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;

namespace Data.ApplicationInsights.Tests.Metrics
{
    public class SummaryMetricsTests : MetricsTestBase
    {
        [Fact]
        public async Task GetSummaryMetric()
        {
            using (var ctx = MockContext.Start(GetType().FullName))
            {
                var metricId = "requests/duration";
                var timespan = new System.TimeSpan(12, 0, 0);
                var aggregation = new[] {"avg"};

                var client = GetClient(ctx);
                var metric = await client.GetMetricSummaryAsync(metricId, timespan, aggregation);

                AssertMetrics(metric, true, false, false, false, false);
            }
        }

        [Fact]
        public async Task GetSummaryMetric_AllAggregations()
        {
            using (var ctx = MockContext.Start(GetType().FullName))
            {
                var metricId = "requests/duration";
                var timespan = new System.TimeSpan(12, 0, 0);
                var aggregation = new[] { "avg", "count", "min", "max", "sum" };

                var client = GetClient(ctx);
                var metric = await client.GetMetricSummaryAsync(metricId, timespan, aggregation);

                AssertMetrics(metric, true, true, true, true, true);
            }
        }
    }
}
