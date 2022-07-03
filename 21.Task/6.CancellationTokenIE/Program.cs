CancellationTokenSource tokenSource = new();

CancellationToken token = tokenSource.Token;

List<Tuple<string, string, long, DateTime>> files = new();

Task t = Task.Run(() =>
{
	string dir = "D:\test";
	
	object obj = new Object();

	if (Directory.Exists(dir))
	{
		Parallel.ForEach(Directory.GetFiles(dir),
			f =>
			{
				if (token.IsCancellationRequested)
					token.ThrowIfCancellationRequested();

				FileInfo fi = new(f);

				lock (obj)
				{
					files.Add(Tuple.Create(fi.Name, fi.DirectoryName, fi.Length, fi.LastWriteTimeUtc));
				}
			});
	}
}
, token);

await Task.Yield();

tokenSource.Cancel();

try
{
	await t;
	Console.WriteLine("Retrieved information for {0} files.", files.Count);
}
catch (AggregateException e)
{
	Console.WriteLine("Exception messages:");
	
	foreach (Exception ie in e.InnerExceptions)
		Console.WriteLine("   {0}: {1}", ie.GetType().Name, ie.Message);

	Console.WriteLine("\nTask status: {0}", t.Status);
}
finally
{
	foreach (var file in files)
	{
    Console.WriteLine(file);
  }
	
	tokenSource.Dispose();
}