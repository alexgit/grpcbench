// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcService1 {

  /// <summary>Holder for reflection information generated from Protos/greet.proto</summary>
  public static partial class GreetReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/greet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvZ3JlZXQucHJvdG8SDGVudGl0bGVtZW50cyJMChFJc0VudGl0",
            "bGVkUmVxdWVzdBISCgppZGVudGlmaWVyGAEgASgJEgwKBHZlcmIYAiABKAkS",
            "FQoNc2ltdWxhdGVfd29yaxgDIAEoCCImChJJc0VudGl0bGVkUmVzcG9uc2US",
            "EAoIZW50aXRsZWQYASABKAgyXwoMRW50aXRsZW1lbnRzEk8KCklzRW50aXRs",
            "ZWQSHy5lbnRpdGxlbWVudHMuSXNFbnRpdGxlZFJlcXVlc3QaIC5lbnRpdGxl",
            "bWVudHMuSXNFbnRpdGxlZFJlc3BvbnNlQg+qAgxHcnBjU2VydmljZTFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService1.IsEntitledRequest), global::GrpcService1.IsEntitledRequest.Parser, new[]{ "Identifier", "Verb", "SimulateWork" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService1.IsEntitledResponse), global::GrpcService1.IsEntitledResponse.Parser, new[]{ "Entitled" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IsEntitledRequest : pb::IMessage<IsEntitledRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IsEntitledRequest> _parser = new pb::MessageParser<IsEntitledRequest>(() => new IsEntitledRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IsEntitledRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService1.GreetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IsEntitledRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IsEntitledRequest(IsEntitledRequest other) : this() {
      identifier_ = other.identifier_;
      verb_ = other.verb_;
      simulateWork_ = other.simulateWork_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IsEntitledRequest Clone() {
      return new IsEntitledRequest(this);
    }

    /// <summary>Field number for the "identifier" field.</summary>
    public const int IdentifierFieldNumber = 1;
    private string identifier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Identifier {
      get { return identifier_; }
      set {
        identifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "verb" field.</summary>
    public const int VerbFieldNumber = 2;
    private string verb_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Verb {
      get { return verb_; }
      set {
        verb_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "simulate_work" field.</summary>
    public const int SimulateWorkFieldNumber = 3;
    private bool simulateWork_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SimulateWork {
      get { return simulateWork_; }
      set {
        simulateWork_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IsEntitledRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IsEntitledRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Identifier != other.Identifier) return false;
      if (Verb != other.Verb) return false;
      if (SimulateWork != other.SimulateWork) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Identifier.Length != 0) hash ^= Identifier.GetHashCode();
      if (Verb.Length != 0) hash ^= Verb.GetHashCode();
      if (SimulateWork != false) hash ^= SimulateWork.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Identifier.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Identifier);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Verb);
      }
      if (SimulateWork != false) {
        output.WriteRawTag(24);
        output.WriteBool(SimulateWork);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Identifier.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Identifier);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Verb);
      }
      if (SimulateWork != false) {
        output.WriteRawTag(24);
        output.WriteBool(SimulateWork);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Identifier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Identifier);
      }
      if (Verb.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Verb);
      }
      if (SimulateWork != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IsEntitledRequest other) {
      if (other == null) {
        return;
      }
      if (other.Identifier.Length != 0) {
        Identifier = other.Identifier;
      }
      if (other.Verb.Length != 0) {
        Verb = other.Verb;
      }
      if (other.SimulateWork != false) {
        SimulateWork = other.SimulateWork;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Identifier = input.ReadString();
            break;
          }
          case 18: {
            Verb = input.ReadString();
            break;
          }
          case 24: {
            SimulateWork = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Identifier = input.ReadString();
            break;
          }
          case 18: {
            Verb = input.ReadString();
            break;
          }
          case 24: {
            SimulateWork = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class IsEntitledResponse : pb::IMessage<IsEntitledResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IsEntitledResponse> _parser = new pb::MessageParser<IsEntitledResponse>(() => new IsEntitledResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IsEntitledResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService1.GreetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IsEntitledResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IsEntitledResponse(IsEntitledResponse other) : this() {
      entitled_ = other.entitled_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IsEntitledResponse Clone() {
      return new IsEntitledResponse(this);
    }

    /// <summary>Field number for the "entitled" field.</summary>
    public const int EntitledFieldNumber = 1;
    private bool entitled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Entitled {
      get { return entitled_; }
      set {
        entitled_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IsEntitledResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IsEntitledResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Entitled != other.Entitled) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Entitled != false) hash ^= Entitled.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Entitled != false) {
        output.WriteRawTag(8);
        output.WriteBool(Entitled);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Entitled != false) {
        output.WriteRawTag(8);
        output.WriteBool(Entitled);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Entitled != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IsEntitledResponse other) {
      if (other == null) {
        return;
      }
      if (other.Entitled != false) {
        Entitled = other.Entitled;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Entitled = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Entitled = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
