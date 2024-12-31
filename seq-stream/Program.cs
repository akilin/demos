using Newtonsoft.Json.Linq;
using Seq.Api;
using Serilog;
using System.Reactive.Linq;


var seqUrl = "http://localhost:5341";

Log.Logger = new LoggerConfiguration()
    .WriteTo.Seq(seqUrl)
    .WriteTo.Console()
    .CreateLogger();

var filter = "@Level = 'Error'";

while (true)
{
    var connection = new SeqConnection(seqUrl);
    await connection.EnsureConnectedAsync(TimeSpan.FromSeconds(15));
    
    var stream = await connection.Events.StreamAsync<JObject>(filter: filter);

    var subscription = stream.Subscribe(
        log => Log.Information("OnNext"),
        ex => Log.Information("OnError"),
        () => Log.Information("OnCompleted")
    );

    await Task.Delay(1000);
    Log.Error("logging fake error to test seq streaming");

    await stream;

    //uncomment this to make it work
    //await Task.Yield();

    subscription.Dispose();
    stream.Dispose();
    connection.Dispose();

    Log.Information("loop end");
}
