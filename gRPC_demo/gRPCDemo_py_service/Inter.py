# encoding = utf-8

# +------------------------------------------+
# | gRPC library imports                     |
# +------------------------------------------+
import grpc
from concurrent import futures
import ProtocolReverse_pb2
import ProtocolReverse_pb2_grpc

MAX_MESSAGE_LENGTH = 256 * 1024 * 1024

class gRPCService(ProtocolReverse_pb2_grpc.gRPCServiceServicer):
    def ProtocolEcho(self, request, context):
        print("==== 1. ProtocolEcho ====")
        number_data_list = request.number_list
        sum_data = 0
        sum_data = sum_data + number_data_list
        print("sum:", sum_data)
        if sum_data > 2:
            protocol_str = "finished!"
        else:
            protocol_str = "okok!"
        return ProtocolReverse_pb2.ProtocolReply(protocolStr=protocol_str)

def serve_1():
    server_1 = grpc.server(futures.ThreadPoolExecutor(max_workers=10),
                           options=[('grpc.max_send_message_length', MAX_MESSAGE_LENGTH),
                                    ('grpc.max_receive_message_length', MAX_MESSAGE_LENGTH), ])
    ProtocolReverse_pb2_grpc.add_gRPCServiceServicer_to_server(gRPCService(), server_1)
    server_1.add_insecure_port("0.0.0.0:6001")
    print("listen on 6001 port")
    server_1.start()
    server_1.wait_for_termination()

if __name__ == '__main__':
    serve_1()