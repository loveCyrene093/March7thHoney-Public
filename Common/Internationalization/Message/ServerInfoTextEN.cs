namespace March7thHoney.Internationalization.Message;

public class ServerInfoTextEN
{
	public string Shutdown => "Shutting down...";

	public string CancelKeyPressed => "Cancel key (Ctrl + C) pressed. The server will shut down shortly...";

	public string StartingServer => "Starting March7thHoney...";

	public string CurrentVersion => "Current server-supported version: {0}";

	public string LoadingItem => "Loading {0}...";

	public string GeneratingItem => "Generating {0}...";

	public string WaitingItem => "Waiting for process {0} to complete...";

	public string RegisterItem => "Registered {0} {1}.";

	public string FailedToLoadItem => "Failed to load {0}.";

	public string NewClientSecretKey => "Client secret key does not exist. Generating a new client secret key.";

	public string FailedToInitializeItem => "Failed to initialize {0}.";

	public string FailedToReadItem => "Failed to read {0}. File {1}";

	public string GeneratedItem => "Generated {0}.";

	public string UpdatedItem => "Updated {0}.";

	public string LoadedItem => "Loaded {0}.";

	public string LoadedItems => "Loaded {0} {1}.";

	public string ServerRunning => "{0} server is listening on {1}";

	public string ServerStarted => "Startup complete! Took {0}s, Type 'help' for command help.";

	public string MissionEnabled => "Mission system enabled. This feature is still under development and may not work as expected. If you encounter any bugs, please report them to the developers.";

	public string CacheLoadSkip => "Cache loading skipped.";

	public string ConfigMissing => "{0} is missing. Please check your resource folder: {1}. {2} may not be available.";

	public string PartialConfigMissing => "{0} is partially missing. Missing count: {1}. Sample paths: {2}";

	public string UnloadedItems => "Unloaded all {0}.";

	public string SaveDatabase => "Saved database. Took {0}s";

	public string WaitForAllDone => "Cannot enter the game yet. Please wait until all items are loaded before trying again.";

	public string UnhandledException => "An unhandled exception occurred: {0}";

	public string LicenseFileNotFound => "License file not found: {0}";

	public string LicenseInvalid => "License invalid. Please get authorization from {0}";

	public string LicenseParseFailed => "License parse failed.";

	public string LicenseExpired => "License expired.";

	public string LicenseHwidMismatch => "License HWID mismatch.";

	public string LicenseCurrentHwid => "Current machine HWID: {0}";

	public string LicenseVerified => "License verified for {0}. Expires at: {1}";

	public string LicenseValidateFailed => "Failed to validate License.";

	public string PublicModeTrialActive => "Trial mode is active. {0} days remain in the trial period.";

	public string PublicModeBuildTimeUnavailable => "Trial mode cannot be used.";

	public string PublicModeEnabled => "Server is in public mode. Enabling additional security measures.";

	public string PublicModeValidationFailed => "License validation failed, program loading has been stopped.";
}
