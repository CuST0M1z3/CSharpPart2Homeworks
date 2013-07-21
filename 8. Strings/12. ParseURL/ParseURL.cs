using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that parses an URL address given in the format:
    [protocol]://[server]/[resource]
		and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
 */

class ParseURL
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";

        int protocolIndex = url.IndexOf("://", 0);
        int serverIndex = url.IndexOf("/", protocolIndex + 3);
        string protocol = url.Substring(0, protocolIndex);
        string server = url.Substring(protocolIndex + 3, serverIndex - protocolIndex - 3);
        string resourse = url.Substring(serverIndex, url.Length - serverIndex);

        Console.WriteLine("Protocol is: " + protocol);
        Console.WriteLine("Server is: " + server);
        Console.WriteLine("Resourse is: " + resourse);
    }
}

