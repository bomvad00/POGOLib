// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Requests/Messages/GetDownloadSettingsMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOLib.Pokemon.Proto.Requests.Messages {

  /// <summary>Holder for reflection information generated from Requests/Messages/GetDownloadSettingsMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GetDownloadSettingsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Requests/Messages/GetDownloadSettingsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetDownloadSettingsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJSZXF1ZXN0cy9NZXNzYWdlcy9HZXREb3dubG9hZFNldHRpbmdzTWVzc2Fn",
            "ZS5wcm90bxInUE9HT0xpYi5Qb2tlbW9uLlByb3RvLlJlcXVlc3RzLk1lc3Nh",
            "Z2VzIioKGkdldERvd25sb2FkU2V0dGluZ3NNZXNzYWdlEgwKBGhhc2gYASAB",
            "KAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOLib.Pokemon.Proto.Requests.Messages.GetDownloadSettingsMessage), global::POGOLib.Pokemon.Proto.Requests.Messages.GetDownloadSettingsMessage.Parser, new[]{ "Hash" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetDownloadSettingsMessage : pb::IMessage<GetDownloadSettingsMessage> {
    private static readonly pb::MessageParser<GetDownloadSettingsMessage> _parser = new pb::MessageParser<GetDownloadSettingsMessage>(() => new GetDownloadSettingsMessage());
    public static pb::MessageParser<GetDownloadSettingsMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOLib.Pokemon.Proto.Requests.Messages.GetDownloadSettingsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetDownloadSettingsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetDownloadSettingsMessage(GetDownloadSettingsMessage other) : this() {
      hash_ = other.hash_;
    }

    public GetDownloadSettingsMessage Clone() {
      return new GetDownloadSettingsMessage(this);
    }

    /// <summary>Field number for the "hash" field.</summary>
    public const int HashFieldNumber = 1;
    private string hash_ = "";
    public string Hash {
      get { return hash_; }
      set {
        hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetDownloadSettingsMessage);
    }

    public bool Equals(GetDownloadSettingsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Hash != other.Hash) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Hash.Length != 0) hash ^= Hash.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Hash.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Hash);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Hash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
      }
      return size;
    }

    public void MergeFrom(GetDownloadSettingsMessage other) {
      if (other == null) {
        return;
      }
      if (other.Hash.Length != 0) {
        Hash = other.Hash;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Hash = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
