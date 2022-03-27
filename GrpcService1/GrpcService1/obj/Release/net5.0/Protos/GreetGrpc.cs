// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService1 {
  public static partial class Entitlements
  {
    static readonly string __ServiceName = "entitlements.Entitlements";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcService1.IsEntitledRequest> __Marshaller_entitlements_IsEntitledRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService1.IsEntitledRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcService1.IsEntitledResponse> __Marshaller_entitlements_IsEntitledResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService1.IsEntitledResponse.Parser));

    static readonly grpc::Method<global::GrpcService1.IsEntitledRequest, global::GrpcService1.IsEntitledResponse> __Method_IsEntitled = new grpc::Method<global::GrpcService1.IsEntitledRequest, global::GrpcService1.IsEntitledResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsEntitled",
        __Marshaller_entitlements_IsEntitledRequest,
        __Marshaller_entitlements_IsEntitledResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService1.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Entitlements</summary>
    [grpc::BindServiceMethod(typeof(Entitlements), "BindService")]
    public abstract partial class EntitlementsBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService1.IsEntitledResponse> IsEntitled(global::GrpcService1.IsEntitledRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EntitlementsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_IsEntitled, serviceImpl.IsEntitled).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EntitlementsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_IsEntitled, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService1.IsEntitledRequest, global::GrpcService1.IsEntitledResponse>(serviceImpl.IsEntitled));
    }

  }
}
#endregion
