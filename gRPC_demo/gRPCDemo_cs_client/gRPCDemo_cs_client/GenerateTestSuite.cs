using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtocolReverse; //插件
using Google.Protobuf; //插件
using Grpc.Core;       //插件

namespace gRPCDemo_cs_client
{
    public class GenerateTestSuite
    {
        private const string ip_port = "127.0.0.1:8090";
        ProtocolReverse.gRPCService.gRPCServiceClient client = new ProtocolReverse.gRPCService.gRPCServiceClient(new Channel(ip_port, ChannelCredentials.Insecure));

        public string Protocol(string pcap_name)
        {


            int numb1;
            if (pcap_name == "okok")
            {   
                numb1 = 6;
            }
            else
            {
                numb1 = 1;
            }

            var return_string = client.ProtocolEcho(new ProtocolReverse.ProtocolRequest
            {

                NumberList = numb1
            });
            string returnstring = return_string.ProtocolStr;
            return returnstring;
        }

    }
}
