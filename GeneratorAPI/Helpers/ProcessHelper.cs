using System.Diagnostics;

namespace GeneratorAPI.Helpers;

public class ProcessHelper
{
    public static async Task<bool> ExecuteInCmd(string[] cmd)
    {
        try
        {
            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + string.Join("&&",cmd),
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = new Process { StartInfo = psi };
            process.Start();
            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();
            process.WaitForExit();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
