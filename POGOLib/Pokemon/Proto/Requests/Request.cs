// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Requests/Request.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOLib.Pokemon.Proto.Requests {

  /// <summary>Holder for reflection information generated from Requests/Request.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class RequestReflection {

    #region Descriptor
    /// <summary>File descriptor for Requests/Request.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSZXF1ZXN0cy9SZXF1ZXN0LnByb3RvEh5QT0dPTGliLlBva2Vtb24uUHJv",
            "dG8uUmVxdWVzdHMaGlJlcXVlc3RzL1JlcXVlc3RUeXBlLnByb3RvImUKB1Jl",
            "cXVlc3QSQQoMcmVxdWVzdF90eXBlGAEgASgOMisuUE9HT0xpYi5Qb2tlbW9u",
            "LlByb3RvLlJlcXVlc3RzLlJlcXVlc3RUeXBlEhcKD3JlcXVlc3RfbWVzc2Fn",
            "ZRgCIAEoDFAAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOLib.Pokemon.Proto.Requests.RequestTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOLib.Pokemon.Proto.Requests.Request), global::POGOLib.Pokemon.Proto.Requests.Request.Parser, new[]{ "RequestType", "RequestMessage" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Request : pb::IMessage<Request> {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOLib.Pokemon.Proto.Requests.RequestReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Request(Request other) : this() {
      requestType_ = other.requestType_;
      requestMessage_ = other.requestMessage_;
    }

    public Request Clone() {
      return new Request(this);
    }

    /// <summary>Field number for the "request_type" field.</summary>
    public const int RequestTypeFieldNumber = 1;
    private global::POGOLib.Pokemon.Proto.Requests.RequestType requestType_ = 0;
    public global::POGOLib.Pokemon.Proto.Requests.RequestType RequestType {
      get { return requestType_; }
      set {
        requestType_ = value;
      }
    }

    /// <summary>Field number for the "request_message" field.</summary>
    public const int RequestMessageFieldNumber = 2;
    private pb::ByteString requestMessage_ = pb::ByteString.Empty;
    public pb::ByteString RequestMessage {
      get { return requestMessage_; }
      set {
        requestMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequestType != other.RequestType) return false;
      if (RequestMessage != other.RequestMessage) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (RequestType != 0) hash ^= RequestType.GetHashCode();
      if (RequestMessage.Length != 0) hash ^= RequestMessage.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RequestType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) RequestType);
      }
      if (RequestMessage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(RequestMessage);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RequestType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RequestType);
      }
      if (RequestMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(RequestMessage);
      }
      return size;
    }

    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.RequestType != 0) {
        RequestType = other.RequestType;
      }
      if (other.RequestMessage.Length != 0) {
        RequestMessage = other.RequestMessage;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            requestType_ = (global::POGOLib.Pokemon.Proto.Requests.RequestType) input.ReadEnum();
            break;
          }
          case 18: {
            RequestMessage = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
