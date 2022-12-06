// Filename:  HttpServer.cs        
// Author:    Benjamin N. Summerton <define-private-public>        
// License:   Unlicense (http://unlicense.org/)
using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System;
using System.Linq;



using System;
using System.Text.Json;

namespace O_simple_http_server
{
    class O_http_server
    {
        private static BloggingContext o_blogging_context; 
        public static HttpListener listener;
        public static string url = "http://localhost:8000/";
        public static int pageViews = 0;
        public static int requestCount = 0;
        public static string pageData = 
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>HttpListener Example</title>" +
            "  </head>" +
            "  <body>" +
            "    <p>Page Views: {0}</p>" +
            "    <form method=\"post\" action=\"shutdown\">" +
            "      <input type=\"submit\" value=\"Shutdown\" {1}>" +
            "    </form>" +
            "  </body>" +
            "</html>";


        public static async Task HandleIncomingConnections()
        {
            bool runServer = true;

            // While a user hasn't visited the `shutdown` url, keep on handling requests
            while (runServer)
            {
                BloggingContext db = new BloggingContext();

                // Will wait here until we hear from a connection
                HttpListenerContext ctx = await listener.GetContextAsync();

                // Peel out the requests and response objects
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                // Print out some info about the request
                Console.WriteLine("Request #: {0}", ++requestCount);
                Console.WriteLine(req.Url.ToString());
                Console.WriteLine(req.HttpMethod);
                Console.WriteLine(req.UserHostName);
                Console.WriteLine(req.UserAgent);
                Console.WriteLine();

                // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
                if ((req.HttpMethod == "POST") && (req.Url.AbsolutePath == "/shutdown"))
                {
                    Console.WriteLine("Shutdown requested");
                    runServer = false;
                }
                if(req.Url.AbsolutePath == "/read"){

                    // Console.WriteLine("Querying for a blog");
                    // var blog = db.Blogs
                    //     .OrderBy(b => b.BlogId)
                    //     .First();

                }
                if(req.Url.AbsolutePath == "/create"){

                    Console.WriteLine("Inserting a new blog");
                    db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                    db.SaveChanges();

                }
                if(
                    req.Url.AbsolutePath == "/create" ||
                    req.Url.AbsolutePath == "/read" ||
                    req.Url.AbsolutePath == "/update" ||
                    req.Url.AbsolutePath == "/delete" 
                ){

                    var o_crud_operation_response = new global::O_crud_operation_response("test", "test");
                    string s_json__o_crud_operation_response = JsonSerializer.Serialize<O_crud_operation_response>(o_crud_operation_response);
                    string s_test = "hello you there;";
                    //string s_json = "{\"this\":2, \"is\":{\"a\":true}}";
                    string s_json = "{\"s_model_name\":\"o_message\",\"s_function_name\":\"f_create\", \"a_o\":[{\"s_text\":\"yes indeed\"}]}";
                    
                    var o_test = Newtonsoft.Json.JsonConvert.DeserializeObject<O_crud_operation_request>(s_json);

                    Console.WriteLine(o_test);

                    Console.WriteLine("o_test.a_o");
                    Console.WriteLine(o_test.a_o);
                    Console.WriteLine("o_test.s_function_name");
                    Console.WriteLine(o_test.s_function_name);
                    Console.WriteLine("o_test.a_o");
                    Console.WriteLine(o_test.a_o);
                    
                    // foreach (var o in o_test.a_o){
                    //     Console.WriteLine("o.s_message");
                    //     Console.WriteLine(o["s_message"]);
                    // }

                    Console.WriteLine(s_json__o_crud_operation_response);
                    Console.WriteLine(o_crud_operation_response);

                    byte[] a_n_data = Encoding.UTF8.GetBytes(s_json);
                    resp.ContentType = "text/html";
                    resp.ContentEncoding = Encoding.UTF8;
                    resp.ContentLength64 = a_n_data.LongLength;

                    // Write out to the response stream (asynchronously), then close it
                    await resp.OutputStream.WriteAsync(a_n_data, 0, a_n_data.Length);
                    resp.Close();

                }


                // // Make sure we don't increment the page views counter if `favicon.ico` is requested
                // if (req.Url.AbsolutePath != "/favicon.ico")
                //     pageViews += 1;

                // // Write the response info
                // string disableSubmit = !runServer ? "disabled" : "";
                // byte[] data = Encoding.UTF8.GetBytes(String.Format(pageData, pageViews, disableSubmit));
                // resp.ContentType = "text/html";
                // resp.ContentEncoding = Encoding.UTF8;
                // resp.ContentLength64 = data.LongLength;

                // // Write out to the response stream (asynchronously), then close it
                // await resp.OutputStream.WriteAsync(data, 0, data.Length);
                // resp.Close();
            }
        }


        public static void f_listen()
        {
            // Create a Http server and start listening for incoming connections
            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();
            Console.WriteLine("Listening for connections on {0}", url);

            // Handle requests
            Task listenTask = HandleIncomingConnections();
            listenTask.GetAwaiter().GetResult();

            // Close the listener
            listener.Close();
        }
    }
}
