using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

/* Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
 * Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.
 */

class DownloadFile
{
    static void Main()
    {
        try
        {
            string uri = "http://www.devbg.org/img/";
            string fileName = "Logo-BASD.jpg";
            string WebResource = null;
            WebClient myWebClient = new WebClient();
            WebResource = uri + fileName;
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, WebResource);
            myWebClient.DownloadFile(WebResource, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, WebResource);
            Console.WriteLine("\nDownloaded file saved in the current file system(bin) folder");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid file");
        }
        catch (WebException)
        {
            Console.WriteLine("No network access");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Method is not supported");
        }
    }
}

