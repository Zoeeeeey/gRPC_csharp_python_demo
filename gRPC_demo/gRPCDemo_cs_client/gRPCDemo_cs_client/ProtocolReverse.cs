// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProtocolReverse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtocolReverse {

  /// <summary>Holder for reflection information generated from ProtocolReverse.proto</summary>
  public static partial class ProtocolReverseReflection {

    #region Descriptor
    /// <summary>File descriptor for ProtocolReverse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtocolReverseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b2NvbFJldmVyc2UucHJvdG8SD1Byb3RvY29sUmV2ZXJzZSImCg9Q",
            "cm90b2NvbFJlcXVlc3QSEwoLbnVtYmVyX2xpc3QYASABKAUiJAoNUHJvdG9j",
            "b2xSZXBseRITCgtwcm90b2NvbFN0chgBIAEoCTJhCgtnUlBDU2VydmljZRJS",
            "CgxQcm90b2NvbEVjaG8SIC5Qcm90b2NvbFJldmVyc2UuUHJvdG9jb2xSZXF1",
            "ZXN0Gh4uUHJvdG9jb2xSZXZlcnNlLlByb3RvY29sUmVwbHkiAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtocolReverse.ProtocolRequest), global::ProtocolReverse.ProtocolRequest.Parser, new[]{ "NumberList" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtocolReverse.ProtocolReply), global::ProtocolReverse.ProtocolReply.Parser, new[]{ "ProtocolStr" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProtocolRequest : pb::IMessage<ProtocolRequest> {
    private static readonly pb::MessageParser<ProtocolRequest> _parser = new pb::MessageParser<ProtocolRequest>(() => new ProtocolRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProtocolRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtocolReverse.ProtocolReverseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtocolRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtocolRequest(ProtocolRequest other) : this() {
      numberList_ = other.numberList_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtocolRequest Clone() {
      return new ProtocolRequest(this);
    }

    /// <summary>Field number for the "number_list" field.</summary>
    public const int NumberListFieldNumber = 1;
    private int numberList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumberList {
      get { return numberList_; }
      set {
        numberList_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProtocolRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProtocolRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NumberList != other.NumberList) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NumberList != 0) hash ^= NumberList.GetHashCode();
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
      if (NumberList != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(NumberList);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NumberList != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumberList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProtocolRequest other) {
      if (other == null) {
        return;
      }
      if (other.NumberList != 0) {
        NumberList = other.NumberList;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            NumberList = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ProtocolReply : pb::IMessage<ProtocolReply> {
    private static readonly pb::MessageParser<ProtocolReply> _parser = new pb::MessageParser<ProtocolReply>(() => new ProtocolReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProtocolReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtocolReverse.ProtocolReverseReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtocolReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtocolReply(ProtocolReply other) : this() {
      protocolStr_ = other.protocolStr_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtocolReply Clone() {
      return new ProtocolReply(this);
    }

    /// <summary>Field number for the "protocolStr" field.</summary>
    public const int ProtocolStrFieldNumber = 1;
    private string protocolStr_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProtocolStr {
      get { return protocolStr_; }
      set {
        protocolStr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProtocolReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProtocolReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProtocolStr != other.ProtocolStr) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProtocolStr.Length != 0) hash ^= ProtocolStr.GetHashCode();
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
      if (ProtocolStr.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProtocolStr);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProtocolStr.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProtocolStr);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProtocolReply other) {
      if (other == null) {
        return;
      }
      if (other.ProtocolStr.Length != 0) {
        ProtocolStr = other.ProtocolStr;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ProtocolStr = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
