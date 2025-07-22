using BTCPayServer.Abstractions.Contracts;
using BTCPayServer.Abstractions.Models;
using BTCPayServer;
using Microsoft.Extensions.DependencyInjection;

namespace LegacyInvoiceExport;

public class LegacyInvoiceExportPlugin : BaseBTCPayServerPlugin
{
    public override IBTCPayServerPlugin.PluginDependency[] Dependencies { get; } =
    {
        new IBTCPayServerPlugin.PluginDependency { Identifier = nameof(BTCPayServer), Condition = ">=2.1.7" }
    };

    public override void Execute(IServiceCollection services)
    {
        services.AddReportProvider<LegacyInvoiceExportReportProvider>();
    }
}
